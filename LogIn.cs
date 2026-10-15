using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class LogIn : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
        public LogIn()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (loginPagePasswordTextBox.UseSystemPasswordChar == false)
            {
                loginPagePasswordTextBox.UseSystemPasswordChar = true;
            }
            else if (loginPagePasswordTextBox.UseSystemPasswordChar == true)
            {
                loginPagePasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void loginPageLoginButton_Click(object sender, EventArgs e)
        {
            if (loginPageUserIdtextBox.Text == "" || loginPagePasswordTextBox.Text == "")
            {
                MessageBox.Show("Please enter ID & Password");
                return;
            }

            try
            {
                connect.Open();

                string oquery = "SELECT ROLE,STATUS FROM Users WHERE ID = @Id AND PASSWORD = @Password";

                SqlCommand ocmd = new SqlCommand(oquery, connect);
                ocmd.Parameters.AddWithValue("@Id", loginPageUserIdtextBox.Text);
                ocmd.Parameters.AddWithValue("@Password", loginPagePasswordTextBox.Text);

                using (SqlDataReader reader = ocmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader["ROLE"].ToString();
                        string status = reader["STATUS"].ToString();


                        if (status == "Active")
                        {

                            UserAccess.Id = loginPageUserIdtextBox.Text;
                            UserAccess.Role = role;

                            if (role == "Employee")
                            {
                                MessageBox.Show("Login Sucessful");
                                employeePageViewProduct own = new employeePageViewProduct();
                                own.Show();
                                this.Hide();
                                return;
                            }
                            else if (role == "Owner")
                            {
                                MessageBox.Show("Login Sucessful");
                                Form2 own = new Form2();
                                own.Show();
                                this.Hide();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("You are Fired");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong ID or Password");
                        return;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            }
    } 
}


