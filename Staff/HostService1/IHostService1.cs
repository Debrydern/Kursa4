using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace HostService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHostService1" in both code and config file together.
    [ServiceContract]
    public interface IHostService1
    {
        [OperationContract]
        int Summator( int a, int b);

        [OperationContract]
        string GetRowById(int id); 
    }
}
