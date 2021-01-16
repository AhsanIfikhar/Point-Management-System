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
    public partial class EditStudentRecords : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public EditStudentRecords()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University Management System\University Management System\obj\Debug\Point'sStudentDetails.accdb;
         Persist Security Info=False;";
            InitializeComponent();
        }

        private void EditStudentRecords_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
               
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "insert into Table1([ID],[Name],[Batch],[Department],[Section],[RouteNo],[Fee]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                command.CommandText = query;
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Record Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                connection.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("E" + ex.Message);
            }
           
            connection.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Table1 where ID='" + textBox1.Text + "'";
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

        private void label12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" || textBox2.Text == "" || textBox3.Text=="" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {
                try
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand();

                    command.Connection = connection;


                    string query = "UPDATE Table1 SET ID='" + textBox1.Text + "',Name='" + textBox2.Text + "',Batch='" + textBox3.Text + "',Department='" + textBox4.Text + "',[RouteNo]='" + textBox6.Text + "',[Section]='" + textBox5.Text + "',[Fee]='" + textBox7.Text + "'WHERE ID='" + textBox8.Text + "'";
                    command.CommandText = query;

                    command.ExecuteNonQuery();
                    //,Name='" + textBox2.Text + "',Batch='" + textBox3.Text + "',Department='" + textBox4.Text + "',Section='"+textBox5.Text+ "',Route No='" + textBox6.Text + "',Fee='" + textBox7.Text + "'
                    connection.Close();
                    MessageBox.Show("Record Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                    connection.Close();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainPage f1 = new AdminMainPage();
            f1.Show();
        }
    }
}
