using SimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCP_IP_Server.ViewController
{
    public class ServerConfig
    {
        public static string ConfiguracoesServidor()
        {

            string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString() + ":80";          
            return myIP;
        }
    }
}
