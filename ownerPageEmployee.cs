using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class ownerPageEmployee : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
        public ownerPageEmployee()
        {
            InitializeComponent();
            ShowAllData();
            ClearFields();
        }


        public void ShowAllData()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.EmployeeDataList();
            EmployeeGridView.DataSource = listData;
        }

        private void ownerProfileButton_Click(object sender, EventArgs e)
        {
            UserProfile owner = new UserProfile();
            owner.Visible = true;
            this.Visible = false;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Visible = true;
            this.Visible = false;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ownerPageProducts o2 = new ownerPageProducts();
            o2.Visible = true;
            this.Visible=false;
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageCategory o6 = new ownerPageCategory();
            o6.Visible = true;
            this.Visible = false;
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            ownerPageDiscount o4 = new ownerPageDiscount();
            o4.Visible = true;
            this.Visible = false;
        }

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageOrderHistory h3 = new ownerPageOrderHistory();
            h3.Visible = true;
            this.Visible = false;
        }

        private void ownerPageEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void EmployeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool empltyField()
        {
            if (employeePasswordTextbox.Text == "" || employeeNameTextbox.Text == "" || employeeEmailTextbox.Text == "" || employeeSalaryTextbox.Text == "" || employeeGenderComboBox.Text == "" || employeeJoinDateTextBox.Text == "" || employeeRoleComboBox.Text == "" || employeeStatusComboBox.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ClearFields()
        {
            employeeIdTextbox.Text = GenerateEmployeeId();
            employeePasswordTextbox.Text = "";
            employeeNameTextbox.Text = "";
            employeeEmailTextbox.Text = "";
            employeeSalaryTextbox.Text = "";
            employeeGenderComboBox.Text = "";
            employeeJoinDateTextBox.Text = "";
            employeeRoleComboBox.Text = "";
            employeeStatusComboBox.Text = "";
        }
        // ID Auto generate 
        private string GenerateEmployeeId()
        {
            string newId = "E101";

            if (connect.State != ConnectionState.Open)
                connect.Open();

            string query = "SELECT ID FROM Employee ORDER BY ID DESC";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ID"].ToString();
                    int number = int.Parse(lastId.Replace("E", ""));
                    newId = "E" + (number + 1);
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
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string empId = GenerateEmployeeId();

                string query = @"INSERT INTO Employee 
                        (ID, PASSWORD, NAME, EMAIL, SALARY, GENDER, JOIN_DATE, ROLE, STATUS) 
                        VALUES (@Id, @Pass, @Name, @Email, @Salary, @Gender, @JoinDate, @Role, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Id", empId);
                    cmd.Parameters.AddWithValue("@Pass", employeePasswordTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", employeeNameTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", employeeEmailTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Salary", int.Parse(employeeSalaryTextbox.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Gender", employeeGenderComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@JoinDate", employeeJoinDateTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Role", employeeRoleComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", employeeStatusComboBox.Text.Trim());

                    cmd.ExecuteNonQuery();
                }


                string queryUser = @"INSERT INTO Users (ID, PASSWORD, ROLE, STATUS) VALUES (@Id, @Pass, @Role, @Status)";

                using (SqlCommand cmd = new SqlCommand(queryUser, connect))
                {
                    cmd.Parameters.AddWithValue("@Id", empId);
                    cmd.Parameters.AddWithValue("@Pass", employeePasswordTextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Role", employeeRoleComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", employeeStatusComboBox.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Employee Added Successfully");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            if (connect.State == ConnectionState.Closed)
                connect.Open();
            try

            {
                string id = EmployeeGridView.CurrentRow.Cells[0].Value.ToString();

                //employee table
                string deleteQuery = "DELETE FROM Employee WHERE ID = '" + id + "'";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect);
                deleteCmd.ExecuteNonQuery();

                //users table
                string deleteQuery2 = "DELETE FROM Users WHERE ID = '" + id + "'";
                SqlCommand deleteCmd2 = new SqlCommand(deleteQuery2, connect);
                deleteCmd.ExecuteNonQuery();

                MessageBox.Show("Employee deleted.");
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

        private void logoutOwnerBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
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
                if(connect.State == ConnectionState.Closed)
                    connect.Open();
                
                string query = "UPDATE Employee SET PASSWORD=@Pass, NAME=@Name, EMAIL=@Email, SALARY=@Salary, GENDER=@Gender, JOIN_DATE=@JoinDate, ROLE=@Role, STATUS=@Status WHERE ID=@Id";


                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", employeeIdTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Pass", employeePasswordTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", employeeNameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", employeeEmailTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Salary", int.Parse(employeeSalaryTextbox.Text.Trim()));
                cmd.Parameters.AddWithValue("@Gender", employeeGenderComboBox.Text.Trim());
                cmd.Parameters.AddWithValue("@JoinDate", employeeJoinDateTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", employeeRoleComboBox.Text.Trim());
                cmd.Parameters.AddWithValue("@Status", employeeStatusComboBox.Text.Trim());

                cmd.ExecuteNonQuery();


                //for users
                string queryuser = "UPDATE Users SET PASSWORD=@Pass, ROLE=@Role, STATUS=@Status WHERE ID=@Id";
                SqlCommand cmd2 = new SqlCommand(queryuser, connect);
                cmd2.Parameters.AddWithValue("@Id", employeeIdTextbox.Text.Trim());
                cmd2.Parameters.AddWithValue("@Pass", employeePasswordTextbox.Text.Trim());
                cmd2.Parameters.AddWithValue("@Role", employeeRoleComboBox.Text.Trim());
                cmd2.Parameters.AddWithValue("@Status", employeeStatusComboBox.Text.Trim());
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Employee Updated Successfully");
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

        private void EmployeeGridView_DoubleClick(object sender, EventArgs e)
        {
            if (EmployeeGridView.CurrentRow != null)
            {
                try
                {
                    employeeIdTextbox.Text = EmployeeGridView.CurrentRow.Cells[0].Value?.ToString();
                    employeePasswordTextbox.Text = EmployeeGridView.CurrentRow.Cells[1].Value?.ToString();
                    employeeNameTextbox.Text = EmployeeGridView.CurrentRow.Cells[2].Value?.ToString();
                    employeeEmailTextbox.Text = EmployeeGridView.CurrentRow.Cells[3].Value?.ToString();
                    employeeSalaryTextbox.Text = EmployeeGridView.CurrentRow.Cells[4].Value?.ToString();
                    employeeGenderComboBox.Text = EmployeeGridView.CurrentRow.Cells[5].Value?.ToString();
                    employeeJoinDateTextBox.Text = EmployeeGridView.CurrentRow.Cells[6].Value?.ToString();
                    employeeRoleComboBox.Text = EmployeeGridView.CurrentRow.Cells[7].Value?.ToString();
                    employeeStatusComboBox.Text = EmployeeGridView.CurrentRow.Cells[8].Value?.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product details: " + ex.Message);
                }
            }
        }

        private void employeeSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\Restaurant MS.mdf;Integrated Security=True;Connect Timeout=30");
            string q = "Select * from Employee where NAME like '%" + employeeSearchTextBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(q, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeGridView.DataSource = dt;
        }
    }
}
