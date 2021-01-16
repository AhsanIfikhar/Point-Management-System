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
    public partial class AdminMainPage :Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPointDetails f1 = new EditPointDetails();
            f1.Show();
        }
        private void AdminMainPage_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transport_Management_System f1 = new Transport_Management_System();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDriver_PointInfo f1 = new EditDriver_PointInfo();
            f1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckStudentMembership f1 = new CheckStudentMembership();
            f1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudentRecords f1 = new EditStudentRecords();
            f1.Show();
        }
    }
}
