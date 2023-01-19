using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace PowerDistributionSystem
{
    [DataContract]
    public class Uredjaj
    {
        private string naziv;
        private int kwph;


        [DataMember]
        public int Kwph { get => kwph; set => kwph = value; }
        [DataMember]
        public string Naziv { get => naziv; set => naziv = value; }

        public Uredjaj(string naziv, int kwph)
        {
            Naziv = naziv;
            Kwph = kwph;
           
        }

       

        public Uredjaj() : this("", 0) { }




        public override string ToString()
        {
            return Naziv + " " + Kwph + " ";
        }


    }
}
