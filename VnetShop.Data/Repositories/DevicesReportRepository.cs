using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IDevicesReportRepository : IRepository<DevicesReport>
    {

    }
    public class DevicesReportRepository : RepositoryBase<DevicesReport>, IDevicesReportRepository
    {
        public DevicesReportRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}