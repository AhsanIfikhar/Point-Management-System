using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class GeneralInformation : Form
    {
        public GeneralInformation()
        {
            InitializeComponent();
        }

        private void GeneralInformation_Load(object sender, EventArgs e)
        {
          
        }
        
      
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
         
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Management_System f1 = new Transport_Management_System();
            f1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AddingPointFee f1 = new AddingPointFee();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
                
        }

        private void GeneralInformation_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            PointsRoutes f1 = new PointsRoutes();
            f1.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Point_sDriverContacts f1 = new Point_sDriverContacts();
            f1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingPointFee f1 = new AddingPointFee();
            f1.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Management_System f1 = new Transport_Management_System();
            f1.Show();
        }
    }
}

