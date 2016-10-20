using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnetShop.Model.Models;

namespace SocketService.Servers.TG102SE.Commands
{
    public class KeepAliveCommand : CommandBase<TG102SESession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                // Example Header: 242400001400
                // Package Type : HeartBeat
                return "0000"; 
            }
        }
        public override void ExecuteCommand(TG102SESession session, BinaryRequestInfo requestInfo)
        {
            
            string package = BitConverter.ToString(requestInfo.Body).Replace("-", string.Empty);
            // example data :  101016   151212  0132270012862710    582E332E302E302E    20B9    00      00          0000    FBE7        2323
            // structure    :   date    time    imei                fw_version          code    status  Reverse     SN      Checksum    EOF
            
            // Extract some information
            session._IMEI = package.Substring(12,16);

            // Get the device with this _IMEI
            Device device = session._deviceService.GetBySerialNumber(session._IMEI);
            if (device == null)
            {
                session.Send("This device is not in database.");
                return;
            }

            session.Send("Welcome " + session._IMEI);

            // Send back the full package to Device
            session.Send("This is HearBeat package: " + BitConverter.ToString(requestInfo.Body).Replace("-", string.Empty) + Environment.NewLine);
        }
    }
}
