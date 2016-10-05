using System.Data.Entity;
using VnetShop.Model.Models;

// Usage:
//
//
//

namespace VnetShop.Data
{
    public class VnetShopDbContext : DbContext
    {
        // Create a constructor, and insert a connection string into this constructor
        public VnetShopDbContext() : base("VnetShopConnection")
        {
            // this setting enable that when loading a parent table , no Include child tables
            this.Configuration.LazyLoadingEnabled = false;
        }

        // all Tables
        public DbSet<AccReport> AccReport { set; get; }
        public DbSet<CarCommandQueue> CarCommandQueue { set; get; }
        public DbSet<CommandDictionary> CommandDictionary { set; get; }
        public DbSet<Device> Devices { set; get; }
        public DbSet<DeviceProtocol> DeviceProtocol { set; get; }
        public DbSet<DevicesReport> DevicesReport { set; get; }
        public DbSet<ExceptionMessage> ExceptionMessage { set; get; }
        public DbSet<GeoFence> GeoFence { set; get; }
        public DbSet<Group> Group { set; get; }
        public DbSet<IconType> IconType { set; get; }
        public DbSet<LKLocation> LKLocation { set; get; }
        public DbSet<POI> POI { set; get; }
        public DbSet<SpeedReport> SpeedReport { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<UserLog> UserLog { set; get; }
        public DbSet<WebURL> WebURL { set; get; }

        // run when we make an instance of Entity Framework
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }
    }
}