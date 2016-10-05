using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;
using System.Linq;

namespace VnetShop.Data.Repositories
{
    public interface IUserRepository
    {
        // list all methods which not inherited from RepositoryBase class
        // only special methods should be placed here
        // because all common methods declared in RepositoryBase<T>
        IEnumerable<User> GetByLoginName(string loginName);
    }
    //--------------------
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        // Implement methods from IUserRepository
        public IEnumerable<User> GetByLoginName(string loginName)
        {
            return this.DbContext.Users.Where(x => x.LoginName == loginName);
        }
    }
}
