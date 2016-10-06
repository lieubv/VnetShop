using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Data.Infrastructure;
using VnetShop.Data.Repositories;
using VnetShop.Model.Models;
using VnetShop.Service;

namespace VnetShop.UnitTest.ServiceTest
{
    [TestClass]
    public class UserServiceTest
    {
        private Mock<IUserRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IUserService _userService;
        private List<User> _listUser;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IUserRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _userService = new UserService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listUser = new List<User>()
            {
                new User() {UserID = 1, UserName = "A" , Status = 0 },
                new User() {UserID = 2, UserName = "B" , Status = 0 },
                new User() {UserID = 3, UserName = "C" , Status = 0 },
            };
        }

        [TestMethod]
        public void User_Service_GetAll()
        {
            // Setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listUser);

            // Call method
            var result = _userService.GetAll();

            // Compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void User_Service_Create()
        {

        }
    }
}
