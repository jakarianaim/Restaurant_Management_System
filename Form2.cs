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
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public Form2()
        {
            InitializeComponent();
            updateDashBoard();
            showEmployeeData();
        }
        private void updateDashBoard()
        {
            if (connect.State != ConnectionState.Open)
                connect.Open();

            string query = "SELECT NAME FROM Product ORDER BY TOTAL_SOLD";
            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    topSaleProductLabel.Text = reader.GetString(0);
                }
            }


            string query2 = "SELECT COUNT(*) FROM Category";
            using (SqlCommand cmd2 = new SqlCommand(query2, connect))
            {
                totalCategoryNumber.Text = cmd2.ExecuteScalar().ToString();
            }



            string query3 = "SELECT COUNT(*) FROM Product";
            using (SqlCommand cmd3 = new SqlCommand(query3, connect))
            {
                totalProductsNumber.Text = cmd3.ExecuteScalar().ToString();
            }



            string query4 = "SELECT COUNT(*) FROM Employee";
            using (SqlCommand cmd4 = new SqlCommand(query4, connect))
            {
                employeeNumber.Text = cmd4.ExecuteScalar().ToString();
            }



            string query5 = "SELECT COUNT(*) FROM OrderHistory";
            using (SqlCommand cmd5 = new SqlCommand(query5, connect))
            {
                orderCompleteNumber.Text = cmd5.ExecuteScalar().ToString();
            }



            string query6 = "SELECT SUM(AMOUNT) FROM PaymentHistory";
            using (SqlCommand cmd6 = new SqlCommand(query6, connect))
            {
                totalSalesNumber.Text = cmd6.ExecuteScalar().ToString();
            }


            if (connect.State != ConnectionState.Closed)
                connect.Close();
        }

        private void showEmployeeData()
        {
            try
            {
                employeeHistoryGird.Controls.Clear();

                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                
                string sql = "SELECT ID, NAME, JOIN_DATE FROM Employee";
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (employeeHistoryGird == null)
                {
                    MessageBox.Show("FlowLayoutPanel is not initialized.");
                    return;
                }


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string name = reader["NAME"].ToString();
                    DateTime joinDate = Convert.ToDateTime(reader["JOIN_DATE"]);
                    int workingDays = (DateTime.Today - joinDate).Days;

                    int completeOrder = 0;
                    using (SqlConnection conn2 = new SqlConnection(connect.ConnectionString))
                    {
                        conn2.Open();
                        string orderQuery = "SELECT COUNT(*) FROM OrderHistory WHERE EMPLOYEE_ID=@EmpId";
                        using (SqlCommand cmd2 = new SqlCommand(orderQuery, conn2))
                        {
                            cmd2.Parameters.AddWithValue("@EmpId", id);
                            object result = cmd2.ExecuteScalar();
                            if (result != null)
                                completeOrder = Convert.ToInt32(result);
                        }
                    }

                    employeeHistoryGird.Rows.Add(id, name, completeOrder, workingDays);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();
            }
        }


        

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void ownerProfileButton_Click(object sender, EventArgs e)
        {
            UserProfile owner = new UserProfile();
            owner.Visible = true;
            this.Visible = false;

        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ownerPageEmployee o1 = new ownerPageEmployee();
            o1.Visible = true;
            this.Visible = false;
        }

 

        private void productsBtn_Click_1(object sender, EventArgs e)
        {
            ownerPageProducts o2 = new ownerPageProducts();
            o2.Visible = true;
            this.Visible = false;
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageCategory o5 = new ownerPageCategory();
            o5.Visible = true;
            this.Visible = false;
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            ownerPageDiscount o3 = new ownerPageDiscount();
            o3.Visible = true;
            this.Visible = false;
        }

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageOrderHistory h1 = new ownerPageOrderHistory();
            h1.Visible = true;
            this.Visible = false;
        }

        private void logoutOwnerBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {

            updateDashBoard();
            showEmployeeData();

        }
    }
}
