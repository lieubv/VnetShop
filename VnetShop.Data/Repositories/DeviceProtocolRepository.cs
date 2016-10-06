using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IDeviceProtocolRepository : IRepository<DeviceProtocol>
    {

    }
    public class DeviceProtocolRepository : RepositoryBase<DeviceProtocol>, IDeviceProtocolRepository
    {
        public DeviceProtocolRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}