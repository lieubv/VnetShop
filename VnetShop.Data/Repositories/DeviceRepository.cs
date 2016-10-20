using System;
using System.Collections.Generic;
using System.Linq;
using VnetShop.Data.Infrastructure;
using VnetShop.Model.Models;

namespace VnetShop.Data.Repositories
{
    public interface IDeviceRepository : IRepository<Device>
    {
        Device GetBySerialNumber(string serialNumber);
    }
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public Device GetBySerialNumber(string serialNumber)
        {
            return this.DbContext.Devices.FirstOrDefault(x => x.SerialNumber == serialNumber);
        }

        //
    }
}