using System.IO;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TourPlanner.DataAccess.Context;

namespace TourPlanner.Presentation;

public partial class App : Application
{
    public static IConfiguration? Configuration { get; private set; }
    public static IHost? AppHost { get; private set; }


    public App()
    {
        var b = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        Configuration = b.Build(); 

        AppHost = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(builder =>
            {
                builder.Sources.Clear();
                builder.AddConfiguration(Configuration);
            })
            .ConfigureLogging(builder =>
            {
                builder.AddLog4Net("../../../log4net.config");
            })
            .ConfigureServices(services =>
            {
                services.AddDbContext<TourContext>(options => 
                    options.UseNpgsql(Configuration.GetConnectionString("postgres")));
                services.AddSingleton<MainWindow>();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();

        var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();

        base.OnExit(e);
    }
}