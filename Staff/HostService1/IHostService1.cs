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
        GetShortInfo GetRowById(int id);
        
    }

    [DataContract]
    public struct GetShortInfo
    {
        [DataMember] public string Last_name;
        [DataMember] public string First_name;
        [DataMember] public string Patronic_name;
        [DataMember] public DateTime Birthday;
        [DataMember] public int Age;
        [DataMember] public string Department;
        [DataMember] public string Post;

    }    
}
