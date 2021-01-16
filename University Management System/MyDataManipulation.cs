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
    public partial class MyDataManipulation : Form
    {
        //OleDbConnection connection = new OleDbConnection();
        public MyDataManipulation()
        {
            InitializeComponent();
        }

        private void DataManipulation_Load(object sender, EventArgs e)
        {

        }
        public void readfromdatabase(OleDbConnection connection,string val1,string val2)
        {

            connection.Open();
            try
            {
               

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from Table1 where ID='" + val1 + "'and Pass='" + val2 + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int c = 0;
                while (reader.Read())
                {
                    c = c + 1;
                }
                if (c == 1)
                {
                    MessageBox.Show("Username and Password are Correct");
                    int a = 1;
                    VerifyStudent f1 = new VerifyStudent();
                    f1.returnval(a);
                }
                else if (c > 1)
                {
                    MessageBox.Show("Too Many Username of this");

                }
                else
                {
                    MessageBox.Show("Username and Password is not Correct");
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
           

        }
        public void insertdata(OleDbConnection connection, string name, string id, string batch, string dept, string Sec, string route,string fee)
        {
            

            try
            {
                connection.Open();
              
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "insert into Table1([ID],[Name],[Batch],[Department],[Section],[RouteNo],[Fee]) values('" + id + "','" + name + "','" + batch + "','" + dept + "','" + Sec + "','" + route + "','"+fee+"')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Done!Congrats!You are Registered ");
                connection.Close();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex);
                connection.Close();
               
            }
        }
    }
}
