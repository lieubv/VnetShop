using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class GroupRepository : RepositoryBase<Group>
    {
        public GroupRepository(DbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
