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
    public partial class employeePagePaymentHistory : Form
    {
        public employeePagePaymentHistory()
        {
            InitializeComponent();
            ShowAllData();
        }
        public void ShowAllData()
        {
            PaymentHistoryData proData = new PaymentHistoryData();
            List<PaymentHistoryData> listData = proData.PaymentHistoryDataList("Select * From PaymentHistory WHERE EMPLOYEE_ID='"+UserAccess.Id+"'");
            paymentHistoryDataGridView.DataSource = listData;
        }

        private void viewProductBtn_Click(object sender, EventArgs e)
        {
            employeePageViewProduct p = new employeePageViewProduct();
            p.Visible = true;
            this.Visible = false;
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Visible = true;
            this.Visible = false;
        }

        private void employeePagePaymentHistory_Load(object sender, EventArgs e)
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
