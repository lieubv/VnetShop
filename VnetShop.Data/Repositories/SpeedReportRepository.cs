using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface ISpeedReportRepository : IRepository<SpeedReport>
    {

    }
    public class SpeedReportRepository : RepositoryBase<SpeedReport>, ISpeedReportRepository
    {
        public SpeedReportRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}