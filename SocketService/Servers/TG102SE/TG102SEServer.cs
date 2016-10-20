using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using VnetShop.Data.Infrastructure;

namespace SocketService.Servers.TG102SE
{
    /// <summary>
    /// It's a protocol like that:
    /// +-------+---+-------------------------------+
    /// |request| l |                               |
    /// | name  | e |    request body               |
    /// |  (4)  | n |                               |
    /// |       |(2)|                               |
    /// +-------+---+-------------------------------+
    /// request name: the name of the request, 4 chars, used for matching the processing command
    /// request name = SOF + Datatype: SOF (Start of Frame = 0x24 0x24 ) , and DataType means Command Type(Ex: KeepAlive, Position)
    /// len: the lenght of request data, two bytes, 0x02 0x00 = 2, 0x01 0x01 = 257
    /// request data: the body of the request
    /// </summary>
    ///
    public class TG102SEServer : AppServer<TG102SESession, BinaryRequestInfo>
    {
        // Register ReceiveFilter
        public IDbFactory dbFactory; 

        public TG102SEServer()
        : base(new DefaultReceiveFilterFactory<TG102SEReceiveFilter, BinaryRequestInfo>())
        {
            dbFactory = new DbFactory();
        }

        protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
        {
            return base.Setup(rootConfig, config);
        }

        protected override void OnStarted()
        {
            base.OnStarted();
        }

        protected override void OnStopped()
        {
            base.OnStopped();
        }

        protected override void OnNewSessionConnected(TG102SESession session)
        {
            base.OnNewSessionConnected(session);
        }
    }
}