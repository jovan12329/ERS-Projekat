using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarPanelsWindGens
{
    public class SolarPanel
    {

        private double snaga;
        private DateTime vreme;

        public SolarPanel(double snaga, DateTime vreme)
        {
            this.snaga = snaga;
            this.vreme = vreme;
        }

        public double Snaga { get => snaga; set => snaga = value; }
        public DateTime Vreme { get => vreme; set => vreme = value; }

        public override string ToString()
        {
            return Snaga+" "+Vreme.ToString();
        }
    }
}
