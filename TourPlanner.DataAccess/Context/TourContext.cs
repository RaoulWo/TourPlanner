using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TourPlanner.Models.Entities;
using TourPlanner.Models.Enums;

namespace TourPlanner.DataAccess.Context;

public class TourContext : DbContext
{
    public TourContext(DbContextOptions options)
        : base(options)
    { }

    public DbSet<Difficulty> Difficulty { get; set; }
    public DbSet<Log> Log { get; set; }
    public DbSet<Rating> Rating { get; set; }
    public DbSet<Tour> Tour { get; set; }
    public DbSet<TransportType> TransportType { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Difficulty>()
            .Property(e => e.DifficultyId)
            .HasConversion<int>();

        modelBuilder
            .Entity<Difficulty>().HasData(
                Enum.GetValues(typeof(DifficultyId))
                    .Cast<DifficultyId>()
                    .Select(e => new Difficulty()
                    {
                        DifficultyId = e,
                        Name = e.ToString()
                    })
            );

        modelBuilder
            .Entity<Log>()
            .Property(e => e.DifficultyId)
            .HasConversion<int>();

        modelBuilder
            .Entity<Log>()
            .Property(e => e.RatingId)
            .HasConversion<int>();

        modelBuilder
            .Entity<Rating>()
            .Property(e => e.RatingId)
            .HasConversion<int>();

        modelBuilder
            .Entity<Rating>().HasData(
                Enum.GetValues(typeof(RatingId))
                    .Cast<RatingId>()
                    .Select(e => new Rating()
                    {
                        RatingId = e,
                        Name = e.ToString()
                    })
            );

        modelBuilder
            .Entity<Tour>()
            .Property(e => e.TransportTypeId)
            .HasConversion<int>();

        modelBuilder
            .Entity<Tour>()
            .HasMany(e => e.Logs)
            .WithOne(e => e.Tour)
            .IsRequired();

        modelBuilder
            .Entity<TransportType>()
            .Property(e => e.TransportTypeId)
            .HasConversion<int>();

        modelBuilder
            .Entity<TransportType>().HasData(
                Enum.GetValues(typeof(TransportTypeId))
                    .Cast<TransportTypeId>()
                    .Select(e => new TransportType()
                    {
                        TransportTypeId = e,
                        Name = e.ToString()
                    })
            );

        base.OnModelCreating(modelBuilder);
    }
}