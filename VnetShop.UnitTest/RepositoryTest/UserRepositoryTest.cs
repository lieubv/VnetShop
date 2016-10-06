using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using VnetShop.Data.Infrastructure;
using VnetShop.Data.Repositories;
using VnetShop.Model.Models;

namespace VnetShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class UserRepositoryTest
    {
        private IDbFactory dbFactory;
        private IUserRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new UserRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void User_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();

            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void User_Repository_Create()
        {
            User user = new User();
            user.FirstName = "lieu";
            user.LastName = "bui van";
            user.LoginName = "lieubv";
            user.Password = "lieubv678";

            var result = objRepository.Add(user);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.UserID);
        }

        //--
    }
}