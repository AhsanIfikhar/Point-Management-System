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
    public partial class Point_sDriverContacts : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public Point_sDriverContacts()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\PointDriver'sContacts.accdb;
         Persist Security Info=False;";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Table1";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
           

        }

        private void Point_sDriverContacts_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralInformation f1 = new GeneralInformation();
            f1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
