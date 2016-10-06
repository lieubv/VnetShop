using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IWebURLRepository : IRepository<WebURL>
    {

    }
    public class WebURLRepository : RepositoryBase<WebURL>, IWebURLRepository
    {
        public WebURLRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}