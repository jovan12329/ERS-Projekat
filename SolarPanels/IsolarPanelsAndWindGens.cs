using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace SolarPanels
{

    [ServiceContract]
    public interface IsolarPanelsAndWindGens

    {
        [OperationContract]
         double generisiSnagu();


        //[OperationContract]
       //int sacuvajUBazu();
    }
}
