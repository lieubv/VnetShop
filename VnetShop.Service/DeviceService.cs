using VnetShop.Data.Infrastructure;
using VnetShop.Data.Repositories;
using VnetShop.Model.Models;

namespace VnetShop.Service
{
    public interface IDeviceService
    {
        void Add(Device device);

        void Update(Device device);

        void Delete(Device device);

        Device GetById(int id);

        void SaveChanges();
    }

    public class DeviceService : IDeviceService
    {
        private IDeviceRepository _deviceRepository;
        private IUnitOfWork _unitOfWork;

        public DeviceService(IDeviceRepository deviceRepository, IUnitOfWork unitOfWork)
        {
            this._deviceRepository = deviceRepository;
            this._unitOfWork = unitOfWork;
        }

        // Implemented all methods from its interface that inherited
        public void Add(Device device)
        {
            _deviceRepository.Add(device);
        }

        public void Delete(Device device)
        {
            _deviceRepository.Delete(device);
        }

        public void Delete(int id)
        {
            _deviceRepository.Delete(id);
        }

        public Device GetById(int id)
        {
            return _deviceRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Device device)
        {
            _deviceRepository.Update(device);
        }
    }
}