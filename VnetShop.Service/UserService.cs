using System;
using System.Collections.Generic;
using VnetShop.Data.Infrastructure;
using VnetShop.Data.Repositories;
using VnetShop.Model.Models;

namespace VnetShop.Service
{
    public interface IUserService
    {
        User Add(User user);

        void Update(User user);

        User Delete(User user);

        User Delete(int id);

        User GetById(int id);

        IEnumerable<User> GetAll();

        //IEnumerable<User> GetAllPaging(int pageIndex, int pageSize, out int totalRecord);

        //IEnumerable<User> GetAllByLoginNamePaging(int page, int pageSize, out int totalRecord);

        void SaveChanges();
    }

    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IUnitOfWork _unitOfWork;

        // using best practive: dependency injection
        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this._userRepository = userRepository;
            this._unitOfWork = unitOfWork;
        }

        // implemented
        public User Add(User user)
        {
            return _userRepository.Add(user);
        }

        public User Delete(int id)
        {
            return _userRepository.Delete(id);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public User GetById(int id)
        {
            return _userRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public User Delete(User user)
        {
           return _userRepository.Delete(user);
        }

        public IEnumerable<User> GetAll()
        {
           return  _userRepository.GetAll();
        }
    }
}