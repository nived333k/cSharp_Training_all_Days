using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace tcpserver
{
    public class remoteobjectserver
    {
        public remoteobjectserver()
        {

        }
    }

    //service class
    public class service : MarshalByRefObject
    {
        public string sayhello(string s)
        {
            return "hello" + " " + s;
        }

        public int highestnumber(int x, int y)
        {
            int maxnumber = Math.Max(x, y);
            return maxnumber;

        }
    }

    //server class 
    //it hosts the services by registering them
    class Program
    {
        static void Main(string[] args)
        {

            // create a new channel for communication
            //80 is allocated to http

         
            TcpChannel t = new TcpChannel(8089);

            //register the channel

            ChannelServices.RegisterChannel(t);

            //configure all known services 
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(service), "ourfirstremoteservice", WellKnownObjectMode.Singleton);
            Console.WriteLine("server services started at port number 8089");
            Console.WriteLine("press any key to stop the server services");
            Console.ReadLine();


        }
    }
}
