using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Data.Infrastructure;
using VnetShop.Data.Repositories;
using VnetShop.Model.Models;

namespace VnetShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class DeviceRepositoryTest
    {
        private IDbFactory dbFactory;
        private IUnitOfWork unitOfWork;
        private DeviceRepository objRepository;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            unitOfWork = new UnitOfWork(dbFactory);
            objRepository = new DeviceRepository(dbFactory);
        }

        [TestMethod]
        public void Device_Repository_Create()
        {
            Device dev = new Device();
            dev.CarUserName = "Toyota";
            dev.UserID = 12;
            dev.Status = 1;
            dev.CarNum = "34E1-175.10";

            var result = objRepository.Add(dev);
            unitOfWork.Commit();           

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.DeviceID);
        }

        [TestMethod]
        public void Device_Repository_GetAll()
        {
            Device dev = new Device();
            dev.CarUserName = "Toyota";
            dev.UserID = 12;
            dev.Status = 1;
            dev.CarNum = "34E1-175.10";

            var result = objRepository.GetAll().ToList();
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }
    }
}
