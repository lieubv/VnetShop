using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class LKLocationRepository : RepositoryBase<LKLocation>
    {
        public LKLocationRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}