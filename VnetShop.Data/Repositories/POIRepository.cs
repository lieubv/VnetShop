using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IPOIRepository : IRepository<POI>
    {

    }
    public class POIRepository : RepositoryBase<POI>, IPOIRepository
    {
        public POIRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}