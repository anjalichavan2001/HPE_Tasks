using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceCRUD
{
    /// <summary>
    /// Summary description for WebServiceCRUD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCRUD : System.Web.Services.WebService
    {
        [WebMethod]    //Method to insert a new employee.
        public string InsertEmployee(string fname,string lname,string city,decimal contact)
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
        [WebMethod]    //Method to update an existing employee.
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
        [WebMethod]  //Method to delete an employee by his/her employee id.
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
        [WebMethod]  //Method to view all employee present in the table.
        public DataTable GetAllEmployees()
        {
            Employee e1 = new Employee();
            DataTable list1 = e1.GetAllEmployees();
            return list1;
        }
    }

}
