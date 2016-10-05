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

        void Delete(int id);

        IEnumerable<User> GetAll();

        IEnumerable<User> GetAllPaging(int page, int pageSize, out int totalRecord);

        User GetById(int id);

        //IEnumerable<User> GetAllByLoginNamePaging(int page, int pageSize, out int totalRecord);

        void SaveChanges();
    }

    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        IUnitOfWork _unitOfWork;
        // using best practive: dependency injection
        public UserService(IUserRepository userRepository,IUnitOfWork unitOfWork)
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

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllPaging(int page, int pageSize, out int totalRecord)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}