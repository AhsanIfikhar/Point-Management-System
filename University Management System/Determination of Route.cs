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
    public partial class AddingPointFee : Form
    {
        public AddingPointFee()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection();
        string route;
        
       
        private void AddingPointFee_Load(object sender, EventArgs e)
        {
           

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

           

            route = textBox2.Text;
            if (route == "1" || route == "01")
            {
                
                MessageBox.Show("Fee =Rs,30000");
                AddmissionforPoint f1 = new AddmissionforPoint();
                f1.checkfee("30000", "1");
                this.Hide();
                f1.Show();
            }
            else if (route == "2" || route == "02")
            {
                MessageBox.Show("Fee =Rs.24000");
                AddmissionforPoint f1 = new AddmissionforPoint();
                f1.checkfee("24000", "2");
                this.Hide();
                f1.Show();
            }
            else if (route == "3" || route == "03")
            {
                MessageBox.Show("Fee =Rs.25000");
                AddmissionforPoint f1 = new AddmissionforPoint();


                f1.checkfee("25000", "3");
                this.Hide();
                f1.Show();
            }
            else if (route == "4" || route == "4")
            {
                MessageBox.Show("Fee =Rs.22200");
                AddmissionforPoint f1 = new AddmissionforPoint();


                f1.checkfee("22200", "4");
                this.Hide();
                f1.Show();
            }
            else if (route == "5" || route == "05")
            {
                MessageBox.Show("Fee =Rs.26000");
                AddmissionforPoint f1 = new AddmissionforPoint();


                f1.checkfee("26000", "5");
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Route Please Select From 1-5 or Check Route");
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralInformation f1 = new GeneralInformation();
            f1.Show();
        }
    }
}
