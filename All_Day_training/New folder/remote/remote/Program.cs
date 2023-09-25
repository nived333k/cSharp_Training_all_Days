using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime;
using System.Runtime.Remoting;

namespace remoteServer
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
            return "hello" + s;
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

            HttpChannel c = new HttpChannel(85);

            //register the channel

            ChannelServices.RegisterChannel(c);

            //configure all known services 
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(service),"ourfirstremoteservice",WellKnownObjectMode.Singleton);
            Console.WriteLine("server services started at port number 45");
            Console.WriteLine("press any key to stop the server services");
            Console.ReadLine();


        }
    }
}
