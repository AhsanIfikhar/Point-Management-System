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
    public partial class EditDriver_PointInfo : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public EditDriver_PointInfo()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\PointDriver'sContacts.accdb;
         Persist Security Info=False;";
            InitializeComponent();
        }

        private void EditDriver_PointInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
              
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "insert into Table1([Name],[PhoneNumber],[RouteNo],[PointNo]) values('" + textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                
                connection.Close();
                MessageBox.Show("Record Saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                connection.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
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
                MessageBox.Show("E" + ex.Message);
            }
          

        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Table1 where Name='"+textBox1.Text+"'";
                command.CommandText = query;
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Record Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query ="UPDATE Table1 SET Name='"+textBox1.Text+"',PhoneNumber='"+textBox2.Text+"',RouteNo='"+textBox3.Text+"',PointNo='"+textBox4.Text+"'WHERE Name='"+textBox8.Text+"'";
                command.CommandText = query;
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Record Updated Successfully");
            }
            catch (Exception ex)
            {
               MessageBox.Show("" + ex.Message);
                connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainPage f1 = new AdminMainPage();
            f1.Show();

        }
    }
}
