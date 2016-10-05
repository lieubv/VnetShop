using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IIconTypeRepository : IRepository<IconType>
    {

    }
    public class IconTypeRepository : RepositoryBase<IconType>, IIconTypeRepository
    {
        public IconTypeRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}