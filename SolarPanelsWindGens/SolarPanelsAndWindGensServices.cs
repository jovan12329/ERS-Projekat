using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarPanels;
using System.Threading;
using System.IO;

namespace SolarPanelsWindGens
{
    class SolarPanelsAndWindGensServices : IsolarPanelsAndWindGens
    {
        


        public double generisiSnagu() {

            Random rnd = new Random();

            int WSEnergijaProc = 0;

            double WSEnergija = 0;

            double maxWSEnergija = 406.5;



            WSEnergijaProc = rnd.Next(0, 101);

            WSEnergija = maxWSEnergija * ((double)WSEnergijaProc / 100);



            

            Console.WriteLine("Trenutno generisana snaga u procentima: " + WSEnergijaProc + "%");
            Console.WriteLine("Trenutna snaga generisana u KW: " + WSEnergija + "KW");

            SolarPanel s = new SolarPanel(WSEnergija, DateTime.Now);
            Random r = new Random();
            int rb = r.Next(1, 10000);
            while (SolarPanelsDataBase.spwg.ContainsKey(rb))
            {

                rb = r.Next(1, 10000);

            }
            SolarPanelsDataBase.spwg.Add(rb, s);



            return WSEnergija;
        }

        

    }
}
