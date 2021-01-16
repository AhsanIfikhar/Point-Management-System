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
    public partial class AddmissionforPoint : MyDataManipulation
    {
        
        public OleDbConnection connection = new OleDbConnection();
        public AddmissionforPoint()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\Point'sStudentDetails.accdb;
         Persist Security Info=False;";
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralInformation f1 = new GeneralInformation();
            f1.Show(); 
        }
        
        
        string fee, r;
        private void label8_Click(object sender, EventArgs e)
        {
            if (r == "1" && fee == textBox6.Text)
            {
                MessageBox.Show("Fee Collected");
                insertdata(connection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, r, textBox6.Text);
                this.Hide();
                GeneralInformation f2 = new GeneralInformation();
                f2.Show();
            }
            else if (r == "2" && fee == textBox6.Text)
            {
                MessageBox.Show("Fee Collected");
                insertdata(connection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, r, textBox6.Text);
                this.Hide();
                GeneralInformation f2 = new GeneralInformation();
                f2.Show();
            }
            else if (r == "3" && fee == textBox6.Text)
            {
                MessageBox.Show("Fee Collected");
                insertdata(connection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, r, textBox6.Text);
                this.Hide();
                GeneralInformation f2 = new GeneralInformation();
                f2.Show();
            }
            else if (r == "4" && fee == textBox6.Text)
            {
                MessageBox.Show("Fee Collected");
                insertdata(connection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, r, textBox6.Text);
                this.Hide();
                GeneralInformation f2 = new GeneralInformation();
                f2.Show();
            }
            else if (r == "5" && fee == textBox6.Text)
            {
                MessageBox.Show("Fee Collected");
                insertdata(connection, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, r, textBox6.Text);
                this.Hide();
                GeneralInformation f2 = new GeneralInformation();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please Pay Correct Amount!");
            }
        }
        public void checkfee(string fee1,string r1)
        {
            fee = fee1;
            r = r1;
        }
       
        private void AddmissionforPoint_Load(object sender, EventArgs e)
        {
            
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingPointFee f1 = new AddingPointFee();
            f1.Show();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
