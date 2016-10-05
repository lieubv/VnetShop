using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class DeviceRepository : RepositoryBase<Device>
    {
        public DeviceRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        //
    }
}