using DistroHidro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroelectricPowerPlant
{
    public class HydroelectricPowerPlantServices : IHidroelectricPower
    {
        public double PotraznjaZaGenerisanje(double b,double c)
        {
          
            double elektricnaEnergija = 0;

            double potrebnaElektricnaEnergija = c - b;

            if (potrebnaElektricnaEnergija <= 0)
            {


                return 0.0;


            }

            elektricnaEnergija = (100*potrebnaElektricnaEnergija)/c;

           
            Random r = new Random();
            int rb = r.Next(1, 10000);
            Elektrana e = new Elektrana(elektricnaEnergija,DateTime.Now);
            
            while (HydroelectricPowerPlantDataBase.hidros.ContainsKey(rb))
            {

                rb = r.Next(1, 10000);

            }

            HydroelectricPowerPlantDataBase.hidros.Add(rb,e);
            

            Console.WriteLine("Trenutno generisana elektricna energija u procentima: " + elektricnaEnergija + "%");
            Console.WriteLine("Trenutna elektricna energija u kWh: " + potrebnaElektricnaEnergija + "kWh");
            
            using (StreamWriter sw = new StreamWriter("HidroEvidence.txt")) {


                foreach (Elektrana t in HydroelectricPowerPlantDataBase.hidros.Values) {

                    sw.WriteLine(t.ElektricnaEnergijaProc+" "+t.VremeGenerisanja);
                
                }
            
            
            
            }



                return potrebnaElektricnaEnergija;
        }
    }
}

              

