using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace DistroHidro
{
    [ServiceContract]
    public interface IHidroelectricPower
    {
        [OperationContract]
        double PotraznjaZaGenerisanje(double b,double c);
    }
}
