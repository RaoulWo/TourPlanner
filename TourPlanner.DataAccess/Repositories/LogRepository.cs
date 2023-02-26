using TourPlanner.DataAccess.Context;
using TourPlanner.DataAccess.Repositories.Interfaces;
using TourPlanner.Models.Entities;

namespace TourPlanner.DataAccess.Repositories;

public class LogRepository : Repository<Log>, ILogRepository
{
    public LogRepository(TourContext context)
        : base(context) { }
}