using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class DeviceProtocolRepository : RepositoryBase<DeviceProtocol>
    {
        public DeviceProtocolRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}