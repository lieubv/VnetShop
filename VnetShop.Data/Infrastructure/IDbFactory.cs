using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Usage:
// Khoi tao cac doi tuong Entities
//
//

namespace VnetShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        VnetShopDbContext Init();
    }
}
