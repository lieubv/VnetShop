using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Data.Infrastructure;
using VnetShop.Data.Repositories;
using VnetShop.Model.Models;
using VnetShop.Service;

namespace SocketService.Servers.TG102SE
{
    public class TG102SESession : AppSession<TG102SESession, BinaryRequestInfo>
    {
        // Declare all global variable here
        internal string _IMEI;
        internal Device _device;
        internal DeviceRepository _deviceRepository;
        internal IDeviceService _deviceService;
        internal IDbFactory _dbFactory;
        internal IUnitOfWork _unitOfWork;
        
        // Override all methods
        protected override void HandleUnknownRequest(BinaryRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
        }

        protected override void HandleException(Exception e)
        {
            base.HandleException(e);
        }

        protected override void OnSessionStarted()
        {
            this.Send("Welcome to TG102SE Server ...");
            Initialize();       
        }

       

        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
        }
        private void Initialize()
        {
            _IMEI = string.Empty ;
            _device = null;
            _dbFactory = new DbFactory();
            _unitOfWork = new UnitOfWork(_dbFactory);
            _deviceRepository = new DeviceRepository(_dbFactory);
            _deviceService = new DeviceService(_deviceRepository,_unitOfWork);            
        }

    }
}
