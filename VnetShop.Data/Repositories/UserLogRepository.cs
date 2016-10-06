using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IUserLogRepository : IRepository<UserLog>
    {

    }
    public class UserLogRepository : RepositoryBase<UserLog>,IUserLogRepository
    {
        public UserLogRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}