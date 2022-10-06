using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            WebServiceCRUD.WebServiceCRUDSoapClient client =
           new WebServiceCRUD.WebServiceCRUDSoapClient();
            DataTable d1 = client.GetAllEmployees();
            //d1 = client.GetAllEmployees();

            dataGridView1.DataSource = d1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WebServiceCRUD.WebServiceCRUDSoapClient client =
            new WebServiceCRUD.WebServiceCRUDSoapClient();
            string text = client.InsertEmployee(textBox1.Text, textBox3.Text, textBox2.Text, decimal.Parse(textBox4.Text));
            MessageBox.Show(text);
            display();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebServiceCRUD.WebServiceCRUDSoapClient client =
            new WebServiceCRUD.WebServiceCRUDSoapClient();
            string text = client.DeleteEmployee(Convert.ToInt32(textBox5.Text));
            MessageBox.Show(text);
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebServiceCRUD.WebServiceCRUDSoapClient client =
            new WebServiceCRUD.WebServiceCRUDSoapClient();
            string text = client.UpdateEmployee(Convert.ToInt32(textBox5.Text),textBox1.Text, textBox3.Text, textBox2.Text, decimal.Parse(textBox4.Text));
            MessageBox.Show(text);
            display();
        }
    }
}
