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
    public partial class employeePageViewProduct : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public employeePageViewProduct()
        {
            InitializeComponent();
            getAllProduct();
            paymentOptioncomboBox.SelectedIndex = 0;
        }

        private void employeePageViewProduct_Load(object sender, EventArgs e)
        {










        }

        private void viewProductBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            employeePageOrderHistory o = new employeePageOrderHistory();
            o.Visible = true;
            this.Visible = false;
        }

        private void catogoryBtn_Click(object sender, EventArgs e)
        {
            employeePageCategory c = new employeePageCategory();
            c.Visible = true;
            this.Visible = false;
        }

        private void paymentHistoryBtn_Click(object sender, EventArgs e)
        {
            employeePagePaymentHistory pay = new employeePagePaymentHistory();
            pay.Visible = true;
            this.Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
        }

        private void ownerProfileButton_Click(object sender, EventArgs e)
        {
            UserProfile owner = new UserProfile();
            owner.Visible = true;
            this.Visible = false;
        }


        private void addProduct(string id, string name, string price, string category,string status,string img,int tax,int stock)
        {
            try
            {
                Product p = new Product()
                {
                    Id = id,
                    Name = name,
                    Price = price,
                    Category = category,
                    Status = status,
                    Image = img,
                    Tax = tax,
                    Stock = stock,
                };

                showProductFlow.Controls.Add(p);

                p.selected += (sender, args) =>
                {
                    Product selectedProduct = (Product)sender;

                    if (selectedProduct.Quantity <= 0)
                    {
                        MessageBox.Show("Select a valid quantity.");
                        return;
                    }
                    // Parameterized query
                    try
                    {

                        if (connect.State == ConnectionState.Closed)
                            connect.Open();

                        string sql = "SELECT * FROM Product WHERE NAME = @Name";

                        SqlCommand cmd = new SqlCommand(sql, connect);
                        cmd.Parameters.AddWithValue("@Name", selectedProduct.Name);
                        int productStock =0;
                        double productPrice = 0;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productPrice = Convert.ToDouble(reader["PRICE"]);
                                productStock = Convert.ToInt32(reader["STOCK"]);
                            }
                        }

                    if (productStock < selectedProduct.Quantity)
                    {
                        MessageBox.Show($"Limited stock.\nStock: {productStock}");
                        return;
                    }

                    double total = selectedProduct.Quantity * productPrice;

                    // Update DataGridView
                    bool found = false;
                    foreach (DataGridViewRow row in CartList.Rows)
                    {
                        if (row.Cells["productId"].Value?.ToString() == selectedProduct.Id)
                        {
                            row.Cells["Name"].Value = selectedProduct.Name;
                            row.Cells["Quantity"].Value = selectedProduct.Quantity;
                            row.Cells["Total"].Value = total;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        CartList.Rows.Add(selectedProduct.Id, selectedProduct.Name, selectedProduct.Quantity, total);
                    }
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

                    updateSemiTotal();
                    updateTax();
                    updateTotalPrice();
                };
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }

        }

        public void getAllProduct(string sql = @"SELECT * FROM Product")
        {
            try
            {
                showProductFlow.Controls.Clear();
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (showProductFlow == null)
                {
                    MessageBox.Show("FlowLayoutPanel is not initialized.");
                    return;
                }

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["Id"].ToString();
                    string name = reader["Name"].ToString();
                    string price = reader["Price"].ToString();
                    int tax = int.Parse(reader["Tax"].ToString());
                    int stock = int.Parse(reader["Stock"].ToString());
                    string category = reader["Category"].ToString();
                    string img = reader["Image"].ToString();
                    string status = reader["Status"].ToString();

                    addProduct(id, name, price, category, status, img,tax, stock);
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

        private void updateProductStock()
        {
            foreach (DataGridViewRow row in CartList.Rows)
            {
                if (row.Cells["productId"].Value != null)
                {
                    try
                    {
                        string id = row.Cells["productId"].Value.ToString();


                        int oldStock = 0, newStock = 0, totalSold = 0;


                        if (connect.State == ConnectionState.Closed)
                            connect.Open();

                        string selectSql = "SELECT STOCK,TOTAL_SOLD FROM Product WHERE ID=@Id";
                        SqlCommand cmd = new SqlCommand(selectSql, connect);

                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                oldStock = reader.GetInt32(0);
                                totalSold = reader.GetInt32(1);
                            }
                        }

                        newStock = oldStock - Convert.ToInt32(row.Cells["Quantity"].Value);

                        string sql = "UPDATE Product SET STOCK=@Stock,TOTAL_SOLD=@Total_Sold WHERE ID=@Id";
                        SqlCommand cmd2 = new SqlCommand(sql, connect);
                        cmd2.Parameters.AddWithValue("@Id", id);
                        cmd2.Parameters.AddWithValue("@Stock", newStock);
                        cmd2.Parameters.AddWithValue("@Total_Sold", ++totalSold);
                        cmd2.ExecuteNonQuery();
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
            }

        }
        private string GeneratePaymentId()
        {
            string newId = "PI101";

            if (connect.State != ConnectionState.Open)
                connect.Open();

            string query = "SELECT PAYMENT_ID FROM PaymentHistory ORDER BY PAYMENT_ID DESC";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["PAYMENT_ID"].ToString();
                    int number = int.Parse(lastId.Replace("PI", ""));
                    newId = "PI" + (number + 1);
                }
            }
            return newId;
        }
        private string GenerateOrderId()
        {
            string newId = "OI101";

            if (connect.State != ConnectionState.Open)
                connect.Open();

            string query = "SELECT ORDER_ID FROM OrderHistory ORDER BY ORDER_ID DESC";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ORDER_ID"].ToString();
                    int number = int.Parse(lastId.Replace("OI", ""));
                    newId = "OI" + (number + 1);
                }
            }
            return newId;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                DateTime date = DateTime.Now;
                string id = UserAccess.Id;

                string query = @"INSERT INTO PaymentHistory (PAYMENT_ID, AMOUNT, TYPE, ORDER_ID, EMPLOYEE_ID, TIME) VALUES (@PaymentId, @Amount, @Type, @OrderId, @EmployeeId, @Time)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@PaymentId", GeneratePaymentId());
                    cmd.Parameters.AddWithValue("@Amount", double.Parse(totalBox.Text));
                    cmd.Parameters.AddWithValue("@Type", paymentOptioncomboBox.Text);
                    cmd.Parameters.AddWithValue("@OrderId", GenerateOrderId());
                    cmd.Parameters.AddWithValue("@EmployeeId", id);
                    cmd.Parameters.AddWithValue("@Time", date);

                    cmd.ExecuteNonQuery();
                }



                //Order History 
                string query2 = @"INSERT INTO OrderHistory (ORDER_ID, DATE, PRODUCTS, PAYMENT_ID, EMPLOYEE_ID) VALUES (@OrderId, @Date, @Products, @PaymentId, @EmployeeId)";
                string productList = "";
                foreach (DataGridViewRow row in CartList.Rows)
                {
                    if (CartList.Rows.Count != 0)
                    {
                        string proId = row.Cells["productId"].Value.ToString();
                        string quantity = row.Cells["Quantity"].Value.ToString();
                        string price = row.Cells["Total"].Value.ToString();

                        productList += (proId + "," + quantity + "," + price) + " | ";
                    }
                    
                }
                using (SqlCommand cmd2 = new SqlCommand(query2, connect))
                {
                    cmd2.Parameters.AddWithValue("@OrderId", GenerateOrderId());
                    cmd2.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@Products", productList);
                    cmd2.Parameters.AddWithValue("@PaymentId", GeneratePaymentId());
                    cmd2.Parameters.AddWithValue("@EmployeeId", UserAccess.Id);

                    cmd2.ExecuteNonQuery();
                }


                MessageBox.Show("Order is completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }

            }


            updateProductStock();
            UpdateDiscount();
            getAllProduct();
            CartList.Rows.Clear();
            semiTotalBox.Text = "0,0";
            taxBox.Text = "0.0";
            totalBox.Text = "0,0";
            cancelDiscountBtn.Visible = false;
            applyDiscountBtn.Visible = true;
            discountBox.Visible = false;
            couponBox.Visible = true;
            discountBox.Text = "0";
            couponBox.Text = "";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            getAllProduct();
            CartList.Rows.Clear();
            semiTotalBox.Text = "0,0";
            taxBox.Text = "0.0";
            totalBox.Text = "0,0";
            cancelDiscountBtn.Visible = false;
            applyDiscountBtn.Visible = true;
            discountBox.Visible = false;
            couponBox.Visible = true;
            discountBox.Text = "0";
            couponBox.Text = "";

        }
        private void updateSemiTotal ()
        {
            double totalprice = 0;
            foreach (DataGridViewRow row in CartList.Rows)
            {
                double price = Convert.ToDouble(row.Cells["Total"].Value);
                totalprice += price;
            }
            semiTotalBox.Text = totalprice.ToString();
        }
        private void updateTax()
        {
            try
            {
                double totalTax = 0;
                foreach (DataGridViewRow row in CartList.Rows)
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    if (row.IsNewRow) continue;
                    string proId = row.Cells["productId"].Value.ToString();
                    int quan = (int)row.Cells["Quantity"].Value;
                    double price = Convert.ToDouble(row.Cells["Total"].Value);

                    string sql = @"SELECT * FROM Product WHERE ID = '" + proId + "';";

                    SqlCommand cmd = new SqlCommand(sql, connect);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        double taxPercentage = double.Parse(reader["TAX"].ToString());
                        double tax = (price * (taxPercentage / 100));
                        totalTax += tax;
                    }

                    taxBox.Text = totalTax.ToString();
                    connect.Close();
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
        private void updateTotalPrice()
        {
            double semiprice = Convert.ToDouble(semiTotalBox.Text);
            double discount = Convert.ToDouble(discountBox.Text);
            double tax = Convert.ToDouble(taxBox.Text);

            double total = (semiprice + tax) - discount;
            totalBox.Text = total.ToString();
        }

        private void DicountOparation()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string code = couponBox.Text.ToUpper();
                string sql = @"SELECT * FROM Discount WHERE COUPON_CODE = '" + code + "';";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader reader = cmd.ExecuteReader();

                DateTime today = DateTime.Now,endDate;

                int limit, maxDiscount, minReq;
                double percentage;
                string couponCode,id;

                if (reader.Read())
                {
                    endDate = (DateTime)reader["END_DATE"];
                    limit = Convert.ToInt32(reader["LIMIT"].ToString());
                    id = reader["ID"].ToString();
                    maxDiscount = Convert.ToInt32(reader["MAXIMUM_DISCOUNT"].ToString());
                    minReq = Convert.ToInt32(reader["MINIMUM_REQ"].ToString());
                    percentage = Convert.ToInt32(reader["PERCENTAGE"].ToString());
                    couponCode = reader["COUPON_CODE"].ToString().ToUpper();

                    
                    if (endDate > today)
                    {
                        if (limit > 0)
                        {
                            int total = Convert.ToInt32(totalBox.Text);
                            if (total >= minReq)
                            {
                                double discount = total * (percentage / 100);
                                if (discount > maxDiscount)
                                {
                                    discountBox.Text = maxDiscount.ToString();
                                }
                                else
                                {
                                    discountBox.Text = discount.ToString();
                                }
                                ClaimedDiscount.Id = id;
                                ClaimedDiscount.Limit = limit-1;
                                cancelDiscountBtn.Visible = true;
                                applyDiscountBtn.Visible = false;
                                discountBox.Visible = true;
                                couponBox.Visible = false;
                                updateTotalPrice();
                            }
                            else
                            {
                                MessageBox.Show("For grab the coupon code. Buy " + (minReq - total) + " BDT.");

                            }
                        }
                        else
                        {
                            MessageBox.Show("This offer reached the maximum limit.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Offer time is end.");
                    }
                }
                else
                {
                    MessageBox.Show("Coupon code is expired.");
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
        private void UpdateDiscount()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open(); 
                
                string query = "UPDATE Discount SET LIMIT=@Limit WHERE ID = @Id";

                SqlCommand cmd = new SqlCommand(query, connect);

                if (ClaimedDiscount.Id != null)
                {
                    cmd.Parameters.AddWithValue("@Id", ClaimedDiscount.Id);
                    cmd.Parameters.AddWithValue("@Limit", ClaimedDiscount.Limit);

                    cmd.ExecuteNonQuery();
                }
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
        private void applyDiscountBtn_Click(object sender, EventArgs e)
        {
            DicountOparation();
        }

        private void cancelDiscountBtn_Click(object sender, EventArgs e)
        {
            cancelDiscountBtn.Visible = false;
            applyDiscountBtn.Visible = true;
            discountBox.Visible = false;
            couponBox.Visible = true;
            discountBox.Text = "0";
            updateTotalPrice();
        }

        
    }
}
