using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Model;
using VnetShop.Model.Models;

namespace VnetShop.Data
{
    public class VnetShopDbContext : DbContext
    {
        public VnetShopDbContext()  : base("VnetShopConnection")
        {
            // this setting enable that when loading a parent table , no loading child tables
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<WebURL> WebURL { set; get; }
    }
}
