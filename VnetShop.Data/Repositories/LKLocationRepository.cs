using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface ILKLocationRepository : IRepository<LKLocation>
    {

    }
    public class LKLocationRepository : RepositoryBase<LKLocation>, ILKLocationRepository
    {
        public LKLocationRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}