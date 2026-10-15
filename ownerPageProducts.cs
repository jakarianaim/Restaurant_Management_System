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
    public partial class ownerPageProducts : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public ownerPageProducts()
        {
            InitializeComponent();
            ShowAllData();
            productIdTextbox.Text = GenerateProductId();
            loadCategory();
            productCategoryComboBox.SelectedIndex = 0;
        }

        private void loadCategory()
        {
            string query = "SELECT NAME FROM Category";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    productCategoryComboBox.Items.Add(reader["NAME"].ToString());
                }
            }
        }

        public void ShowAllData()
        {
            ProductData proData = new ProductData();
            List<ProductData> listData = proData.ProductDataList();
            productGridView.DataSource = listData;
        }

        public bool empltyField()
        {
            if (productNameTextbox.Text == "" || productPriceTextbox.Text == "" || productCategoryComboBox.Text == "" || productStockTextbox.Text == "" ||productImagePictureBox.ImageLocation == "" || productTaxTextbox.Text == "" || productStatusComboBox.Text == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Text clear korar jonno
        public void ClearFields()
        {
            productIdTextbox.Text = GenerateProductId();
            productNameTextbox.Text = "";
            productPriceTextbox.Text = "";
            productCategoryComboBox.Text = "";
            productStockTextbox.Text = "";
            productImagePictureBox.ImageLocation = "";
            productTaxTextbox.Text = "";
            productStatusComboBox.Text = "";
        }
        // ID Auto generate 
        private string GenerateProductId()
        {
            string newId = "P101";

            if (connect.State != ConnectionState.Open)
                connect.Open();

            string query = "SELECT ID FROM Product ORDER BY ID DESC";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ID"].ToString();
                    int number = int.Parse(lastId.Replace("P", ""));
                    newId = "P" + (number + 1);
                }
            }
            return newId;
        }

        private void ownerProfileButton_Click(object sender, EventArgs e)
        {
            UserProfile owner = new UserProfile();
            owner.Visible = true;
            this.Visible = false;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ownerPageEmployee f1 = new ownerPageEmployee();
            f1.Visible = true;
            this.Visible = false;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Form2 o1 = new Form2();
            o1.Visible = true;
            this.Visible = false;
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageCategory o7 = new ownerPageCategory();
            o7.Visible = true;
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


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (empltyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string query = @"INSERT INTO Product
                        (ID, NAME, PRICE, CATEGORY, STOCK, IMAGE, TAX, STATUS,TOTAL_SOLD) 
                        VALUES (@Id, @Name, @Price, @Category, @Stock, @Product_Image, @Product_Tax, @Product_Status,@Total_Sold)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Id", GenerateProductId());
                    cmd.Parameters.AddWithValue("@Name", productNameTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(productPriceTextbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Category", productCategoryComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(productStockTextbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Product_Image", path.Trim());
                    cmd.Parameters.AddWithValue("@Product_Tax", Convert.ToDouble(productTaxTextbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Product_Status", productStatusComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Total_Sold", 0);
                   

                    cmd.ExecuteNonQuery();

                }

                MessageBox.Show("Product Added Successfully");
                ShowAllData();
                ClearFields();
                connect.Close();
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

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void logoutOwnerBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
        }

        string path = "";
        private void addImageBtn_Click(object sender, EventArgs e)
        {
            try

            {
                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
                


                if (open.ShowDialog() == DialogResult.OK)

                {

                    path = open.FileName;

                    productImagePictureBox.ImageLocation = path;

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                connect.Close();
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try

            {
                string id = productGridView.CurrentRow.Cells[0].Value.ToString();

                connect.Open();

                string deleteQuery = "DELETE FROM product WHERE ID = '" + id + "'";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Product deleted.");
                ShowAllData();
                ClearFields();

            }

            catch (Exception exc)

            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
            finally
            {
                connect.Close();
            }

        }

        private void productGridView_DoubleClick(object sender, EventArgs e)
        {
            if (productGridView.CurrentRow != null)
            {
                try
                {
                    productIdTextbox.Text = productGridView.CurrentRow.Cells[0].Value?.ToString();
                    productNameTextbox.Text = productGridView.CurrentRow.Cells[1].Value?.ToString();
                    productPriceTextbox.Text = productGridView.CurrentRow.Cells[2].Value?.ToString();
                    productCategoryComboBox.Text = productGridView.CurrentRow.Cells[3].Value?.ToString();
                    productStockTextbox.Text = productGridView.CurrentRow.Cells[4].Value?.ToString();
                    productImagePictureBox.ImageLocation = productGridView.CurrentRow.Cells[5].Value?.ToString();
                    productTaxTextbox.Text = productGridView.CurrentRow.Cells[6].Value?.ToString();
                    productStatusComboBox.Text = productGridView.CurrentRow.Cells[7].Value?.ToString();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (empltyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string query = "UPDATE Product SET NAME=@Name, PRICE=@Price, CATEGORY=@Category, STOCK=@Stock, IMAGE=@Product_Image, TAX=@Product_Tax, STATUS=@Product_Status WHERE ID=@Id";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", productIdTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", productNameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(productPriceTextbox.Text.Trim()));
                cmd.Parameters.AddWithValue("@Category", productCategoryComboBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(productStockTextbox.Text.Trim()));
                cmd.Parameters.AddWithValue("@Product_Image", path);
                cmd.Parameters.AddWithValue("@Product_Tax", Convert.ToDouble(productTaxTextbox.Text.Trim()));
                cmd.Parameters.AddWithValue("@Product_Status", productStatusComboBox.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Updated Successfully");
                ShowAllData();
                ClearFields();
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

        private void productImagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void productsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
            string q = "Select * from Product where NAME like '%" + productsSearchTextBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            productGridView.DataSource = dt;
        }


    }
}
