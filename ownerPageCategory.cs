using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ownerPageCategory : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");

        public ownerPageCategory()
        {

            InitializeComponent();
            categoryIdTextbox.Text = GenerateCategoryId();
            ShowAllData();
        }
        public void ShowAllData()
        {
            CategoryData catData = new CategoryData();
            List<CategoryData> listData = catData.CategoryDataList();
            categoryGridView.DataSource = listData;
        }
        public void ClearFields()
        {
            categoryIdTextbox.Text = GenerateCategoryId();
            categoryNameTextbox.Text = "";
            categoryStatusComboBox.Text = "";
            categoryImagePictureBox.ImageLocation = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            ownerPageEmployee o3 = new ownerPageEmployee();
            o3.Visible = true;
            this.Visible = false;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ownerPageProducts o4 = new ownerPageProducts();
            o4.Visible = true;
            this.Visible = false;
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            ownerPageDiscount o5 = new ownerPageDiscount();
            o5.Visible = true;
            this.Visible = false;
        }

        
        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageOrderHistory h1 = new ownerPageOrderHistory();
            h1.Visible = true;
            this.Visible = false;
        }
        //missing93

        public bool empltyField()
        {
            if (categoryIdTextbox.Text == "" || categoryNameTextbox.Text == "" || categoryStatusComboBox.Text == "" || categoryImagePictureBox.ImageLocation == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string GenerateCategoryId()
        {
            string newId = "C101";

            if (connect.State != ConnectionState.Open)
                connect.Open();

            string query = "SELECT ID FROM Category ORDER BY ID DESC";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ID"].ToString();
                    int number = int.Parse(lastId.Replace("C", ""));
                    newId = "C" + (number + 1);
                }
            }
            return newId;
        }
        string path = "";


        

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            try

            {
                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";



                if (open.ShowDialog() == DialogResult.OK)

                {

                    path = open.FileName;

                    categoryImagePictureBox.ImageLocation = path;

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
        private void ownerPageCategory_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            try

            {
                string id = categoryGridView.CurrentRow.Cells[0].Value.ToString();


                string deleteQuery = "DELETE FROM Category WHERE ID = '" + id + "'";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Category deleted.");
                ShowAllData();
                ClearFields();
            }

            catch (Exception exc)

            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void categoryGridView_DoubleClick(object sender, EventArgs e)
        {
            if (categoryGridView.CurrentRow != null)
            {
                try
                {
                    categoryIdTextbox.Text = categoryGridView.CurrentRow.Cells[0].Value?.ToString();
                    categoryNameTextbox.Text = categoryGridView.CurrentRow.Cells[1].Value?.ToString();
                    categoryStatusComboBox.Text = categoryGridView.CurrentRow.Cells[2].Value?.ToString();
                    categoryImagePictureBox.ImageLocation = categoryGridView.CurrentRow.Cells[3].Value?.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading category details: " + ex.Message);
                }
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
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "UPDATE Category SET NAME=@Name, STATUS=@Status,IMAGE=@Image WHERE ID=@Id";


                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@ID", categoryIdTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", categoryNameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@STATUS", categoryStatusComboBox.Text.Trim());
                cmd.Parameters.AddWithValue("@IMAGE", path.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Category Updated Successfully");
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
                if (empltyField())
                {
                    MessageBox.Show("Please Fill All The Fields");
                    return;
                }

                try
                {
                    connect.Open();

                    string query = @"INSERT INTO Category
                        (ID, NAME,STATUS, IMAGE) 
                        VALUES (@Id, @Name,@Category_Status, @Category_Image)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Id", GenerateCategoryId());
                        cmd.Parameters.AddWithValue("@Name", categoryNameTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category_Status", categoryStatusComboBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category_Image", path.Trim());


                        cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Category Added Successfully");
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
                    connect.Close();
                }
            }

        private void categoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutOwnerBtn_Click(object sender, EventArgs e)
        {

        }

        private void categorySearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
            string q = "Select * from Category where NAME like '%" + categorySearchTextBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            categoryGridView.DataSource = dt;
        }
    }
}
