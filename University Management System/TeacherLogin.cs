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
    public partial class TeacherLogin : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public TeacherLogin()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\Teacher.accdb;
         Persist Security Info=False;";
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {

              
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Table1 where Email='" + alphaBlendTextBox1.Text + "'and Pass='" + alphaBlendTextBox2.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int c = 0;
                while (reader.Read())
                {
                    c = c + 1;
                }
                if (c == 1)
                {
                    MessageBox.Show("Username and Password are Correct");
                    
                    this.Hide();
                    Teacher_s_Page f1 = new Teacher_s_Page();
                    f1.Show();
                }
                else if (c > 1)
                {
                    MessageBox.Show("Too Many Username of this");

                }
                else
                {
                    MessageBox.Show("Username and Password is not Correct");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void TeacherLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Management_System f1 = new Transport_Management_System();
            f1.Show();
        }
    }
}
