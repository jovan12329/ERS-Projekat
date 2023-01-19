using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HydroelectricPowerPlant
{
    
    public class Elektrana
    {

        private double elektricnaEnergijaProc;
        private DateTime vremeGenerisanja;

       

        public double ElektricnaEnergijaProc { get => elektricnaEnergijaProc; set => elektricnaEnergijaProc = value; }
        public DateTime VremeGenerisanja { get => vremeGenerisanja; set => vremeGenerisanja = value; }

        public Elektrana(double elektricnaEnergijaProc, DateTime vremeGenerisanja)
        {
            ElektricnaEnergijaProc = elektricnaEnergijaProc;
            VremeGenerisanja = vremeGenerisanja;
        }

        public Elektrana() : this(0.0, DateTime.Now) { }


        public override string ToString()
        {
            return ElektricnaEnergijaProc + " " + VremeGenerisanja + " ";
        }


    }
}
