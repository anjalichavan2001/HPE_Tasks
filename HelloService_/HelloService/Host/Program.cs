//Hosting a WCF service using Console Application.

using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        public static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
