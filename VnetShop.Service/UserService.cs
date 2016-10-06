using System;
using System.Collections.Generic;
using VnetShop.Data.Infrastructure;
using VnetShop.Data.Repositories;
using VnetShop.Model.Models;

namespace VnetShop.Service
{
    public interface IUserService
    {
        void Add(User user);

        void Update(User user);

        void Delete(User user);

        void Delete(int id);

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
        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
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

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public IEnumerable<User> GetAll()
        {
           return  _userRepository.GetAll();
        }
    }
}