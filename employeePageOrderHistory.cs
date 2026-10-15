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
    public partial class employeePageOrderHistory : Form
    {
        public employeePageOrderHistory()
        {
            InitializeComponent();
            ShowAllData();
        }
        public void ShowAllData()
        {
            OrderHistoryData proData = new OrderHistoryData();
            List<OrderHistoryData> listData = proData.OrderHistoryDataList("Select * From OrderHistory WHERE EMPLOYEE_ID='" + UserAccess.Id + "'");
            orderHistoryDataGridView2.DataSource = listData;
        }


        private void ownerProfileButton_Click(object sender, EventArgs e)
        {
            UserProfile owner = new UserProfile();
            owner.Visible = true;
            this.Visible = false;
        }


        private void employeePageOrderHistory_Load(object sender, EventArgs e)
        {

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

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
        }

        private void paymentHistoryBtn_Click(object sender, EventArgs e)
        {
            employeePagePaymentHistory pay = new employeePagePaymentHistory();
            pay.Visible = true;
            this.Visible = false;
        }

        private void catogoryBtn_Click(object sender, EventArgs e)
        {
            employeePageCategory c = new employeePageCategory();
            c.Visible = true;
            this.Visible = false;

        }

        private void showAllOrderHistoryBtn_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        
    }
}
