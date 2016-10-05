using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IExceptionMessageRepository : IRepository<ExceptionMessage>
    {
    }

    public class ExceptionMessageRepository : RepositoryBase<ExceptionMessage>, IExceptionMessageRepository
    {
        public ExceptionMessageRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}