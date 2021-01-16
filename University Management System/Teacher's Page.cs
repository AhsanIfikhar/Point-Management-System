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
    public partial class Teacher_s_Page : Form
    {
        public Teacher_s_Page()
        {
            InitializeComponent();
        }

        private void Teacher_s_Page_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PointRout f1 = new PointRout();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverConatacts f1 = new DriverConatacts();
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Management_System f1 = new Transport_Management_System();
            f1.Show();
        }
    }
}
