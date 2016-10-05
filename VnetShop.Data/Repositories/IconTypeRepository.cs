using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class IconTypeRepository : RepositoryBase<IconType>
    {
        public IconTypeRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}