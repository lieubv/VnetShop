using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketService.Servers.TG102SE.Commands
{
    public class BasicGPSCommand : CommandBase<TG102SESession, BinaryRequestInfo>
    {
        public override string Name
        {
            get
            {
                return "3300";
            }
        }

        public override void ExecuteCommand(TG102SESession session, BinaryRequestInfo requestInfo)
        {
            session.Send("This is Basic GPS package: " + BitConverter.ToString(requestInfo.Body).Replace("-", string.Empty) + Environment.NewLine);
            // Extract Information


            // Check whether to insert into Database

            // Save into history Database
        }
    }
}
