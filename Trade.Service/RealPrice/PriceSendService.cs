
using System.Net;
using System.Net.Sockets;
using System.Web;
using Trade.Model;

namespace Trade.Service
{
    /// <summary>
    /// 提供数据主动推送服务
    /// </summary>
    public class PriceSendService
    {
        internal void SendUdpPrice(QuoteCard card)
        {
            HttpApplicationState app = HttpContext.Current.Application;

            Model.LoginInfoMany many = app[ApplicationKey.LoginMany] as Model.LoginInfoMany;

            if (many == null)
            {
                return;
            }

            LoginInfo[] infos = many.GetAllUser();
            

            UdpClient client = new System.Net.Sockets.UdpClient();
            IPEndPoint ip = new System.Net.IPEndPoint(
                System.Net.IPAddress.Parse("127.0.0.1"), 10001);

            int a = client.Send(new byte[100], 100, ip);


        }

        internal void SendToClient(QuoteCard card)
        {
         
        }
    }
}