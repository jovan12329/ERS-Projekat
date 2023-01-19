using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerDistributionSystem;
using SolarPanels;
using DistroHidro;
using System.ServiceModel;
using System.IO;

namespace DistributionCenter
{
    public class DistroCenterServicescs : IDistributionCenter
    {

        
        public string TraziZahtjev(Uredjaj u)
        {

            int kwh = u.Kwph;
            double cena = (double)(54.258 * kwh);
            double snaga = 0;

            string adresa = "net.tcp://localhost:3999/Solar";
            NetTcpBinding binding = new NetTcpBinding();
            ChannelFactory<IsolarPanelsAndWindGens> channel =
                new ChannelFactory<IsolarPanelsAndWindGens>(binding, adresa);
            IsolarPanelsAndWindGens proxy = channel.CreateChannel();
           
            string adresa1 = "net.tcp://localhost:3998/Hidro";
            NetTcpBinding binding1 = new NetTcpBinding();
            ChannelFactory<IHidroelectricPower> channel1 =
                new ChannelFactory<IHidroelectricPower>(binding1, adresa1);
            IHidroelectricPower proxy1 = channel1.CreateChannel();

            

            snaga += proxy.generisiSnagu();

            double ElektricnaEnergija = proxy1.PotraznjaZaGenerisanje(snaga,(double)kwh);

            snaga += ElektricnaEnergija;


            if (!(kwh > snaga))
            {

                Obracun o = new Obracun(u, cena, DateTime.Now.ToString());
                Random r = new Random();
                int rb = r.Next(1, 10000);
                while (DistributionCentreDataBase.uredjaji.ContainsKey(rb))
                {

                    rb = r.Next(1, 10000);

                }

                DistributionCentreDataBase.uredjaji.Add(rb, u);
                snaga = 0;

                using (StreamWriter sw = new StreamWriter("DistroEvidence.txt"))
                {


                    foreach (Uredjaj t in DistributionCentreDataBase.uredjaji.Values)
                    {

                        sw.WriteLine(t);

                    }



                }

                return "Odobren je zahtjev za uredjaj: " + o.ToString();
            }

            else
            {
                snaga = 0;
                return "Zahtjev odbijen";
            }
           

            

        }
    }
}
