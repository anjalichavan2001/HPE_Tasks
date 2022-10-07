using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServiceCRUD
{
    
    public class Employee
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public decimal Contact { get; set; }
        public int EmpID { get; set; }

        string conStr = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
        public Employee() 
        {
        
        }

        public string InsertIntoEmployee()
        {
            string conStr = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", Firstname);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Contact",Contact);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    return "PASS";
                else
                    return "FAIL";
            }
        }
        public string UpdateEmployee()
        {
            //string conStr = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", Firstname);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@City", City);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@EmployeeID", EmpID);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    return "PASS";
                else
                    return "FAIL";
            }
        }
        public string DeleteEmployee()
        {
            //string conStr = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteEmployeeByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", EmpID);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    return "PASS";
                else
                    return "FAIL";
            }
        }
        public DataTable GetAllEmployees()
        {
            List<Employee> lstemployee = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetAllEmployees", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable("MyDataTable");
                sqlAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}