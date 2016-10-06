using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IGeoFenceRepository : IRepository<GeoFence>
    {

    }
    public class GeoFenceRepository : RepositoryBase<GeoFence>, IGeoFenceRepository
    {
        public GeoFenceRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}