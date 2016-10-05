using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class POIRepository : RepositoryBase<POI>
    {
        public POIRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}