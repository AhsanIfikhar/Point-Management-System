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

    public partial class VerifyStudent :MyDataManipulation
    {
        public OleDbConnection connection = new OleDbConnection();
        public VerifyStudent()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\Student.accdb;
         Persist Security Info=False;";
            InitializeComponent();
        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VerifyStudent_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            readfromdatabase(connection, alphaBlendTextBox1.Text, alphaBlendTextBox2.Text);
        }
        public void returnval(int c)
        {
            if (c == 1)
            {
                MessageBox.Show("Ok");
                GeneralInformation f1 = new GeneralInformation();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Management_System f1 = new Transport_Management_System();
            f1.Show();
        }
    }
}
