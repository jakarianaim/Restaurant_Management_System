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
    public partial class ownerPagePaymentHistory : Form
    {
        public ownerPagePaymentHistory()
        {
            InitializeComponent();
            ShowAllData();
        }

        public void ShowAllData()
        {
            PaymentHistoryData proData = new PaymentHistoryData();
            List<PaymentHistoryData> listData = proData.PaymentHistoryDataList();
            paymentHistoryDataGridView.DataSource = listData;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ownerPageOrderHistory order = new ownerPageOrderHistory();
            order.Show();
            this.Hide();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void paymentHistoryBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
