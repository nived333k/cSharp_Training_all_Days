using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

using remoteServer;
using System.Runtime.Remoting.Channels.Http;

namespace remoteclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a channel with port
           HttpChannel c1 = new HttpChannel(8002);

            //regeister channel 
            ChannelServices.RegisterChannel(c1);

            //create a service class object
            service Service =(service)Activator.GetObject(typeof(service), "http://localhost:85/ourfirstremoteservice");

            //start calling  the function of the service class
            Console.WriteLine(Service.sayhello("hellow remote"));
            Console.WriteLine(Service.highestnumber(20,24));
            Console.ReadLine();

        }
    }
}
