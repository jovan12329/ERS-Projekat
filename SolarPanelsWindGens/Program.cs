using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using SolarPanels;




namespace SolarPanelsWindGens
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SolarPanelsAndWindGensServices)))
            {
                
                string adresa = "net.tcp://localhost:3999/Solar";
                NetTcpBinding binding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(IsolarPanelsAndWindGens), binding, adresa);
                host.Open();
                Console.WriteLine("Solar panel je otvoren");

                Console.ReadLine();

                

            }


        }
    }
}
