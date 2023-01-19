using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using PowerDistributionSystem;

namespace DistributionCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(DistroCenterServicescs)))
            {

                string adresa = "net.tcp://localhost:4000/DistroCenterServicescs";
                NetTcpBinding binding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(IDistributionCenter), binding, adresa);
                host.Open();
                Console.WriteLine("Servis je otvoren");

                Console.ReadLine();

                host.Close();

            }


        }



        


    }
}
