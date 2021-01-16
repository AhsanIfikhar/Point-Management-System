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
    public partial class PointRout : Form
    {
        public PointRout()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_s_Page f1 = new Teacher_s_Page();
            f1.Show();
        }

        private void PointRout_Load(object sender, EventArgs e)
        {

        }
    }
}
