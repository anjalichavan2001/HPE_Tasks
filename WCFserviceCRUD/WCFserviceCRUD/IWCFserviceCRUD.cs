using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFserviceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFserviceCRUD" in both code and config file together.
    [ServiceContract]
    public interface IWCFserviceCRUD
    {
        [OperationContract]
        string InsertEmployee(string fname, string lname, string city, decimal contact);

        [OperationContract]
        string UpdateEmployee(int empid, string fname, string lname, string city, decimal contact);

        [OperationContract]
        string DeleteEmployee(int empid);

        [OperationContract]
        DataTable GetAllEmployees();
    }
}
