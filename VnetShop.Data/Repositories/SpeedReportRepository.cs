using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class SpeedReportRepository : RepositoryBase<SpeedReport>
    {
        public SpeedReportRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}