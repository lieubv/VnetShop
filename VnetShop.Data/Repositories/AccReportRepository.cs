using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IAccReportRepository : IRepository<AccReport>
    {

    }
    public class AccReportRepository : RepositoryBase<AccReport>, IAccReportRepository
    {
        public AccReportRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}