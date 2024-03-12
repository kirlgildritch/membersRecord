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

namespace membersRecord
{
    public partial class Form1 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kirlg\OneDrive\Documents\dataBank-member.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();

            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.EmployeeListData();

            dataGridView1.DataSource = listData;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            if(fullname.Text == ""
                || Gender.Text == ""
                || Age.Text == ""
                ||  dateofbirth.Text == ""
                ||  address.Text == ""
                ||  dateofmembership.Text == ""
                ||  sharecapital.Text == ""
                ||  attendance.Text == "")
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
           
                


            
        }
    }
}
