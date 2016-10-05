using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class GeoFenceRepository : RepositoryBase<GeoFence>
    {
        public GeoFenceRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}