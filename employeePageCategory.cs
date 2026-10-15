using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class employeePageCategory : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
        public employeePageCategory()
        {
            InitializeComponent();
            getAllCategory();
        }
        private void addCategory(string id, string name, string status, string img)
        {
            try
            {
                Category p = new Category()
                {
                    Id = id,
                    Name = name,
                    Status = status,
                    Image = img,
                };

                categoryFlowLayout.Controls.Add(p);

                p.selected += (sender, args) =>
                {
                    Category selectedCategory = (Category)sender;
                    showProduct(selectedCategory.Name);
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showProduct(string category)
        {
            try
            {
                productShowFlowLayout.Controls.Clear();

                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string sql = "SELECT * FROM Product WHERE CATEGORY = @cat";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.AddWithValue("@cat", category.Trim());

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product()
                    {
                        Id = reader["Id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Price = reader["Price"].ToString(),
                        Category = reader["Category"].ToString(),
                        Status = reader["Status"].ToString(),
                        Image = reader["Image"].ToString(),
                        Tax = Convert.ToInt32(reader["Tax"]),
                        Stock = Convert.ToInt32(reader["Stock"])
                    };

                    productShowFlowLayout.Controls.Add(p);
                }

                reader.Close();
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

        public void getAllCategory(string sql = @"SELECT * FROM Category")
        {
            try
            {
                categoryFlowLayout.Controls.Clear();
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (categoryFlowLayout == null)
                {
                    MessageBox.Show("FlowLayoutPanel is not initialized.");
                    return;
                }

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["Id"].ToString();
                    string name = reader["Name"].ToString();
                    string img = reader["Image"].ToString();
                    string status = reader["Status"].ToString();

                    addCategory(id, name, status, img);
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }
        private void employeePageCategory_Load(object sender, EventArgs e)
        {

        }

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            employeePageOrderHistory o = new employeePageOrderHistory();
            o.Visible = true;
            this.Visible = false;
        }

        private void paymentHistoryBtn_Click(object sender, EventArgs e)
        {
            employeePagePaymentHistory pay = new employeePagePaymentHistory();
            pay.Visible = true;
            this.Visible = false; 
        }

        private void viewProductBtn_Click(object sender, EventArgs e)
        {
            employeePageViewProduct p = new employeePageViewProduct();
            p.Visible = true;
            this.Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void ownerProfileButton_Click(object sender, EventArgs e)
        {
            UserProfile owner = new UserProfile();
            owner.Visible = true;
            this.Visible = false;
        }
    }
}
