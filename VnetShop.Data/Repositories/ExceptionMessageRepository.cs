using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class ExceptionMessageRepository : RepositoryBase<ExceptionMessage>
    {
        public ExceptionMessageRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}