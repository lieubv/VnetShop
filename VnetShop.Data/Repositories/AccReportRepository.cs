using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public class AccReportRepository : RepositoryBase<AccReport>
    {
        public AccReportRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}