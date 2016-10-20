using SuperSocket.Common;
using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Text;

namespace SocketService.Servers.TG102SE
{
    public class TG102SEReceiveFilter : FixedHeaderReceiveFilter<BinaryRequestInfo>
    {
        public TG102SEReceiveFilter()
            : base(6)
        {
            // Get only 6 first bytes to get other information
            // Package Type
            // Package Length

        }

        protected override int GetBodyLengthFromHeader(byte[] header, int offset, int length)
        {
            int bodyLength = (int)header[offset + 4] + (int)header[offset + 5] * 256;
            return bodyLength + 12; // including Serial Number, CRC and Footer
        }

        protected override BinaryRequestInfo ResolveRequestInfo(ArraySegment<byte> header, byte[] bodyBuffer, int offset, int length)
        {
            // Make a new instance of BinaryRequestInfo with inputs as key and body
            // key  : is Package Type 
            // body : 
            //string test = BitConverter.ToString(header.Array).Replace("-", string.Empty);


            string key = BitConverter.ToString(header.Array).Replace("-", string.Empty).Substring(4,4);
            byte[] body = bodyBuffer.CloneRange(offset, length);

            return new BinaryRequestInfo(key /*Encoding.UTF8.GetString(header.Array, header.Offset, 4)*/, body /* bodyBuffer.CloneRange(offset, length)*/);
        }
    }
}