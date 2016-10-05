using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IDeviceRepository : IRepository<Device>
    {

    }
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        //
    }
}