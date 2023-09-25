using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using tcpserver;

namespace tcpclient
{
    class Program
    {
        class tcpclient
        {
            static void Main(string[] args)
            {
                //create a channel with port
                TcpChannel tc = new TcpChannel();

                //regeister channel 
                ChannelServices.RegisterChannel(tc);

                //create a service class object
                service Service = (service)Activator.GetObject(typeof(service), "tcp://localhost:8089/ourfirstremoteservice");

                //start calling  the function of the service class
                Console.WriteLine(Service.sayhello("hellow remote"));
                Console.WriteLine(Service.highestnumber(20, 24));
                Console.ReadLine();

            }
        }
    }
}
