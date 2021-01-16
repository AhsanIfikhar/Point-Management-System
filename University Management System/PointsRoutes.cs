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
    public partial class PointsRoutes : Form
    {
        public PointsRoutes()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralInformation f1 = new GeneralInformation();
            f1.Show();
        }

        private void PointsRoutes_Load(object sender, EventArgs e)
        {
           
        }
        public void EditPoint(string route,string newroute)
        {
            if(route=="1")
            {
                label1.Text = newroute;
                MessageBox.Show("Route Updated!");

            }
            else if(route=="2")
            {
                label2.Text = newroute;
                MessageBox.Show("Route Updated!");
            }
            else if (route == "3")
            {
                label3.Text = newroute;
                MessageBox.Show("Route Updated!");
            }
            else if (route == "4")
            {
                label4.Text = newroute;
                
                MessageBox.Show("Route Updated!");
            }
            else if(route=="5")
            {
                lable5.Text = newroute;
            }
            else
            {
                MessageBox.Show("Invalid Route");
            }
          
        }
    }
}
