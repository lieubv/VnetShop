using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class DevicesReportRepository : RepositoryBase<DevicesReport>
    {
        public DevicesReportRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}