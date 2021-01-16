using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace University_Management_System
{
    public partial class CheckStudentMembership : MyDataManipulation
    {
        OleDbConnection connection = new OleDbConnection();
        public CheckStudentMembership()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\Point'sStudentDetails.accdb;
         Persist Security Info=False;";
            InitializeComponent();
        }

        private void CheckStudentMembership_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainPage f1 = new AdminMainPage();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            connection.Open();
            try
            {

                MessageBox.Show("Connection Successfull");
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Table1 where ID='" + alphaBlendTextBox1.Text+ "'and Name='" + alphaBlendTextBox2.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int c = 0;
                while (reader.Read())
                {
                    c = c + 1;
                }
                if (c == 1)
                {
                    MessageBox.Show("Membership Confirmed");
                  
                }
                else if (c > 1)
                {
                    MessageBox.Show("Too Many Username of this");

                }
                else
                {
                    MessageBox.Show("Student Have Not AVAILED the Transport Service");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show( ""+ ex.Message);
                connection.Close();
            }

        }
    }
}
