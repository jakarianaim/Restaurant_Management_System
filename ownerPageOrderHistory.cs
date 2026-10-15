using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ownerPageOrderHistory : Form
    {
        public ownerPageOrderHistory()
        {
            InitializeComponent();
            ShowAllData();
        }
        public void ShowAllData()
        {
            OrderHistoryData proData = new OrderHistoryData();
            List<OrderHistoryData> listData = proData.OrderHistoryDataList();
            orderHistoryDataGridView.DataSource = listData;
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

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ownerPageEmployee e1 = new ownerPageEmployee();
            e1.Visible = true;
            this.Visible = false;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ownerPageProducts p1 = new ownerPageProducts();
            p1.Visible = true;
            this.Visible = false;
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            ownerPageCategory c1 = new ownerPageCategory();
            c1.Visible = true;
            this.Visible = false; 
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            ownerPageDiscount d1 = new ownerPageDiscount();
            d1.Visible = true;
            this.Visible = false;
        }
        private void logoutOwnerBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void paymentHistoryBtn_Click(object sender, EventArgs e)
        {
            ownerPagePaymentHistory op = new ownerPagePaymentHistory();
            op.Show();
            this.Hide();
        }
    }
}
