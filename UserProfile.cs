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

    public partial class UserProfile : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public UserProfile()
        {
            InitializeComponent();
            showinfo();
        }

        public void showinfo()
        {
            connect.Open();
            string query = "SELECT ID,NAME,EMAIL,PASSWORD FROM Owner WHERE ID = @Id";
            if (UserAccess.Role == "Employee")
                query = "SELECT ID,NAME,EMAIL,PASSWORD FROM Employee WHERE ID = @Id";

            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@Id", UserAccess.Id);
            
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                idTextBox.Text = reader["ID"].ToString();
                nameTextBox.Text = reader["NAME"].ToString();
                emailTextBox.Text = reader["EMAIL"].ToString();
                passwordTextBox.Text = reader["PASSWORD"].ToString();
            }
            else
            {
                return;
            }
            connect.Close();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Visible = true;
            this.Visible = false;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ownerPageEmployee emp = new ownerPageEmployee();
            emp.Visible = true;
            this.Visible = false;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ownerPageProducts pro = new ownerPageProducts();
            pro.Visible = true;
            this.Visible = false;

        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageCategory cat = new ownerPageCategory();
            cat.Visible = true;
            this.Visible = false;
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            ownerPageDiscount dis= new ownerPageDiscount();
            dis.Visible = true;
            this.Visible = false;

        }

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageOrderHistory ord = new ownerPageOrderHistory();
            ord.Visible = true;
            this.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            idTextBox.ReadOnly = false;
            nameTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            passwordTextBox.ReadOnly = false;
        }

        public bool emptyField()
        {
            if (idTextBox.Text == "" || nameTextBox.Text == "" || emailTextBox.Text == "" || passwordTextBox.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            /*try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();


                string query = @"INSERT INTO Owner
                        (ID, NAME, PASSWORD, PHONE, IMAGE) 
                        VALUES (@Id, @Name, @Password, @Phone, @Image)";


                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", idTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", phoneTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Image", path);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Category Updated Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }

            */




            




          try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "UPDATE Owner SET  ID=@Id, NAME=@Name,PASSWORD=@Password,EMAIL=@Email WHERE ID=@Id";
                if (UserAccess.Role == "Employee")
                    query = "UPDATE Employee SET  ID=@Id, NAME=@Name,PASSWORD=@Password,EMAIL=@Email WHERE ID=@Id";


                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", idTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text.Trim());
                cmd.ExecuteNonQuery();

                //for users
                string query2 = "UPDATE Users SET ID=@Id,PASSWORD=@Password WHERE ID=@Id";
                SqlCommand cmd2 = new SqlCommand(query2, connect);

                cmd2.Parameters.AddWithValue("@Id", idTextBox.Text.Trim());
                cmd2.Parameters.AddWithValue("@Password", passwordTextBox.Text.Trim());
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }

        }

        private void logoutOwnerBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (UserAccess.Role == "Employee")
            {
                employeePageViewProduct v = new employeePageViewProduct();
                v.Visible = true;
                this.Visible = false;
            }
            else
            {
                Form2 v = new Form2();
                v.Visible = true;
                this.Visible = false;
            }
        }
    }
}
