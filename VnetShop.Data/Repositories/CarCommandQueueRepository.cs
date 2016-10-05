using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface ICarCommandQueueRepository : IRepository<CarCommandQueue>
    {

    }
    public class CarCommandQueueRepository : RepositoryBase<CarCommandQueue>, ICarCommandQueueRepository
    {
        public CarCommandQueueRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}
