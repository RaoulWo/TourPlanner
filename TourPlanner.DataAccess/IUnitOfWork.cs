using System;
using TourPlanner.DataAccess.Repositories.Interfaces;

namespace TourPlanner.DataAccess;

public interface IUnitOfWork : IDisposable
{
    IDifficultyRepository Difficulty { get; }
    ILogRepository Log { get; }
    IRatingRepository Rating { get; }
    ITourRepository Tour { get; }
    ITransportTypeRepository TransportType { get; }
    int Save();
}