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

    public partial class ManagerTransport :MyDataManipulation
    {
        OleDbConnection connection = new OleDbConnection();
        public ManagerTransport()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\LoginManagerTransport.accdb;
            Persist Security Info=False;";
            InitializeComponent();
        }


        private void ManagerTransport_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connection Suucesfull");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Not Opened" + ex);
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Management_System f2 = new Transport_Management_System();
            f2.Show();
        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Table1 where ID='" + alphaBlendTextBox1.Text + "'and Password='" + alphaBlendTextBox2.Text + "'";
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
                AdminMainPage f1 = new AdminMainPage();
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
    }
}
