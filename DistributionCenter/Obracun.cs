using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerDistributionSystem;
namespace DistributionCenter
{
   public  class Obracun
    {

            Uredjaj u;
            double cena;
            string datum;

        public Obracun(Uredjaj u, double cena,string datum) {

            this.u = u;
            this.cena = cena;
            this.datum = datum;
        
        }


        public override string ToString()
        {
            

            return "Uredjaj:"+this.u + " "+"Cena:"+ this.cena + " " +"Datum:"+datum+" ";
        }



    }


    
}
