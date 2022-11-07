using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=INLEN8520016371\SQLEXPRESS;Initial catalog=EmployeeDB;Integrated Security=True");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source=INLEN8520016371\SQLEXPRESS;Initial catalog=EmployeeDB;Integrated Security=True");
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@City", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Contact", decimal.Parse(textBox4.Text));
                    cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(textBox5.Text));
                    int i = cmd.ExecuteNonQuery();
                    display();
                    

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();   
        }
        public void display()
        {
            using (SqlCommand cmd = new SqlCommand("sp_GetAllEmployees", connection))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source=INLEN8520016371\SQLEXPRESS;Initial catalog=EmployeeDB;Integrated Security=True");
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertEmployee", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@City", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Contact", decimal.Parse(textBox4.Text));
                    
                    int i = cmd.ExecuteNonQuery();
                    display();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source=INLEN8520016371\SQLEXPRESS;Initial catalog=EmployeeDB;Integrated Security=True");
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DeleteEmployeeByID", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", textBox5.Text);
                    int i = cmd.ExecuteNonQuery();
                    display();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
