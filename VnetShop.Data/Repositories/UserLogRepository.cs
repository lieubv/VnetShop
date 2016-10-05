using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class UserLogRepository : RepositoryBase<UserLog>
    {
        public UserLogRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}