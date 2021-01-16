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
    public partial class EditPointDetails : Form
    {
        public EditPointDetails()
        {
            InitializeComponent();
        }
        string route, newroute;
        private void label3_Click(object sender, EventArgs e)
        {
            route = textBox1.Text;
            newroute = textBox2.Text;
            PointsRoutes f1 = new PointsRoutes();
            f1.EditPoint(route,newroute) ;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainPage f1 = new AdminMainPage();
            f1.Show();
        }

        private void EditPointDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
