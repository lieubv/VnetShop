using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class WebURLRepository : RepositoryBase<WebURL>
    {
        public WebURLRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}