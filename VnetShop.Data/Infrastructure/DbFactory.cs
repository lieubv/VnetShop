using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using : best practice

namespace VnetShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private VnetShopDbContext dbContext;

        public VnetShopDbContext Init()
        {
            // if dbContext is null, create a new one.
            return dbContext ?? (dbContext = new VnetShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
