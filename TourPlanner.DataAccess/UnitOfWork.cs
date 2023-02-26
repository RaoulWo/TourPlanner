using TourPlanner.DataAccess.Context;
using TourPlanner.DataAccess.Repositories;
using TourPlanner.DataAccess.Repositories.Interfaces;

namespace TourPlanner.DataAccess;

public class UnitOfWork : IUnitOfWork
{
    public IDifficultyRepository Difficulty { get; }

    public ILogRepository Log { get; }

    public IRatingRepository Rating { get; }

    public ITourRepository Tour { get; }

    public ITransportTypeRepository TransportType { get; }

    private readonly TourContext _context;

    public UnitOfWork(TourContext context)
    {
        _context = context;
        Difficulty = new DifficultyRepository(_context);
        Log = new LogRepository(_context);
        Rating = new RatingRepository(_context);
        Tour = new TourRepository(_context);
        TransportType = new TransportTypeRepository(_context);
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public int Save()
    {
        return _context.SaveChanges();
    }
}