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
    public partial class ownerPageDiscount : Form
    {
        SqlConnection connect1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
        public ownerPageDiscount()
        {
            InitializeComponent();
            discountIdTextbox.Text = GenerateDiscountId();
            ShowAllData();
        }
        public void ShowAllData()
        {
            DiscountData catData = new DiscountData();
            List<DiscountData> listData = catData.DiscountDataList();
            discountGridView.DataSource = listData;
        }
        public void ClearFields()
        {
            discountIdTextbox.Text = GenerateDiscountId();
            discountNameTextbox.Text = "";
            discountCouponCodeTextbox.Text = "";
            discountPercentageTextbox.Text = "";
            discountLimitTextbox.Text = "";
            maximumDiscountTextbox.Text = "";
            minimumReqTextbox.Text = "";
            StartDatePicker.Text = "";
            EndDatePicker.Text = "";
        }

        private void ownerProfileButton_Click(object sender, EventArgs e)
        {
            UserProfile owner = new UserProfile();
            owner.Visible = true;
            this.Visible = false;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
            this.Visible = false;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ownerPageEmployee o8 = new ownerPageEmployee();
            o8.Visible = true;
            this.Visible = false;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ownerPageProducts o9 = new ownerPageProducts();
            o9.Visible = true;
            this.Visible = false;
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageCategory o2 = new ownerPageCategory();
            o2.Visible = true;
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

        public bool empltyField()
        {
            if (discountIdTextbox.Text == "" || discountNameTextbox.Text == "" || discountCouponCodeTextbox.Text == "" || discountPercentageTextbox.Text == "" || discountLimitTextbox.Text == "" || maximumDiscountTextbox.Text == "" || minimumReqTextbox.Text == "" || StartDatePicker.Text == "" || EndDatePicker.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string GenerateDiscountId()
        {
            string newId = "D101";

            if (connect1.State != ConnectionState.Open)
                connect1.Open();

            string query = "SELECT ID FROM Discount ORDER BY ID DESC";

            using (SqlCommand cmd = new SqlCommand(query, connect1))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ID"].ToString();
                    int number = int.Parse(lastId.Replace("D", ""));
                    newId = "D" + (number + 1);
                }
            }
            return newId;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (empltyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            try
            {
                if (connect1.State == ConnectionState.Closed)
                {
                    connect1.Open();
                }

                string query = @"INSERT INTO Discount
                        (ID, NAME,COUPON_CODE,PERCENTAGE,LIMIT,MAXIMUM_DISCOUNT,MINIMUM_REQ,START_DATE,END_DATE) 
                        VALUES (@Id, @Name,@Coupon_Code, @Percentage,@Limit,@Maximum_Discount,@Minimum_Req,@Start_Date,@End_Date)";

                using (SqlCommand cmd = new SqlCommand(query, connect1))
                {
                    cmd.Parameters.AddWithValue("@Id", GenerateDiscountId());
                    cmd.Parameters.AddWithValue("@Name", discountNameTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Coupon_Code", discountCouponCodeTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Percentage", discountPercentageTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Limit", discountLimitTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Maximum_Discount", maximumDiscountTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Minimum_Req", minimumReqTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Start_Date", StartDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@End_Date", EndDatePicker.Value.Date);



                    cmd.ExecuteNonQuery();

                }

                MessageBox.Show("Discount Added Successfully");
                ShowAllData();
                ClearFields();
                connect1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect1.State == ConnectionState.Open)
                {
                    connect1.Close();
                }

            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (connect1.State == ConnectionState.Closed)
                connect1.Open();
            try

            {
                string id = discountGridView.CurrentRow.Cells[0].Value.ToString();


                string deleteQuery = "DELETE FROM Discount WHERE ID = '" + id + "'";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect1);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Discount Offer deleted.");
                ShowAllData();
                ClearFields();
            }

            catch (Exception exc)

            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
            finally
            {
                if (connect1.State == ConnectionState.Open)
                    connect1.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (empltyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            try
            {
                if (connect1.State == ConnectionState.Closed)
                    connect1.Open();
                 
                string query = "UPDATE Discount SET NAME=@Name, COUPON_CODE=@Coupon_Code, PERCENTAGE=@Percentage, LIMIT=@Limit, MINIMUM_REQ=@Minimum_Req, MAXIMUM_DISCOUNT=@Maximum_Discount,START_DATE=@Start_Date,END_DATE=@End_Date WHERE ID=@Id";


                SqlCommand cmd = new SqlCommand(query, connect1);

                cmd.Parameters.AddWithValue("@Id", discountIdTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", discountNameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Coupon_Code", discountCouponCodeTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Percentage", discountPercentageTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Limit", discountLimitTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Maximum_Discount", maximumDiscountTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Minimum_Req", minimumReqTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Start_Date", StartDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@End_Date", EndDatePicker.Value.Date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Discount Offer Updated Successfully");
                ShowAllData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect1.State == ConnectionState.Open)
                    connect1.Close();
            }
        }

        private void discountGridView_DoubleClick(object sender, EventArgs e)
        {
            if (discountGridView.CurrentRow != null)
            {
                try
                {
                    discountIdTextbox.Text = discountGridView.CurrentRow.Cells[0].Value?.ToString();
                    discountNameTextbox.Text = discountGridView.CurrentRow.Cells[1].Value?.ToString();
                    discountCouponCodeTextbox.Text = discountGridView.CurrentRow.Cells[2].Value?.ToString();
                    discountPercentageTextbox.Text = discountGridView.CurrentRow.Cells[3].Value?.ToString();
                    discountLimitTextbox.Text = discountGridView.CurrentRow.Cells[4].Value?.ToString();
                    maximumDiscountTextbox.Text = discountGridView.CurrentRow.Cells[5].Value?.ToString();
                    minimumReqTextbox.Text = discountGridView.CurrentRow.Cells[6].Value?.ToString();
                    StartDatePicker.Text = discountGridView.CurrentRow.Cells[7].Value?.ToString();
                    EndDatePicker.Text = discountGridView.CurrentRow.Cells[8].Value?.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product details: " + ex.Message);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void discountSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
            string q = "Select * from Discount where NAME like '%" + discountSearchTextBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            discountGridView.DataSource = dt;
        }
    }
}
