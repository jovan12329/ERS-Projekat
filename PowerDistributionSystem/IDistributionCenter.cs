using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace PowerDistributionSystem
{
    [ServiceContract]
    public interface IDistributionCenter
    {
        [OperationContract]
        string TraziZahtjev(Uredjaj u);
        
    
       
    }
}
