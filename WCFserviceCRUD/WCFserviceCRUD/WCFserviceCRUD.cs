using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCFserviceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFserviceCRUD" in both code and config file together.
    public class WCFserviceCRUD : IWCFserviceCRUD
    {
        public string DeleteEmployee(int empid)
        {
            Employee e1 = new Employee
            {
                EmpID = empid
            };
            string status = e1.DeleteEmployee();
            if (status == "PASS")
                return "Employee deleted Successfully";
            else
                return "Delete operation failed";
        }

        public DataTable GetAllEmployees()
        {
            Employee e1 = new Employee();
            DataTable list1 = e1.GetAllEmployees();
            return list1;
        }

        public string InsertEmployee(string fname, string lname, string city, decimal contact)
        {
            Employee e1 = new Employee
            {
                Firstname = fname,
                LastName = lname,
                City = city,
                Contact = contact
            };
            string status = e1.InsertIntoEmployee();
            if (status == "PASS")
                return "Employee inserted Successfully";
            else
                return "Insert operation failed";
        }

        public string UpdateEmployee(int empid, string fname, string lname, string city, decimal contact)
        {
            Employee e1 = new Employee
            {
                EmpID = empid,
                Firstname = fname,
                LastName = lname,
                City = city,
                Contact = contact
            };
            string status = e1.UpdateEmployee();
            if (status == "PASS")
                return "Employee updated Successfully";
            else
                return "Update operation failed";
        }
    }
}
