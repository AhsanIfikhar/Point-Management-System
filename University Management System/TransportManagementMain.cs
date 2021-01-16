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
    public partial class Transport_Management_System : Form
    {
        public Transport_Management_System()
        {
           
            InitializeComponent();
        }

        private void Transport_Management_System_Load(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerTransport f1= new ManagerTransport();
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f1 = new Home();
            f1.Show();
        }

        private void stdntbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerifyStudent f1 = new VerifyStudent();
            f1.Show();
        }

        private void Teacherbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherLogin f1 = new TeacherLogin();
            f1.Show();

        }
    }
}
