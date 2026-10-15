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
    public partial class Product : UserControl
    {
        public string Id { get; set; }
        public string Name
        {
            set { productName.Text = value; }
            get { return productName.Text; }
        }
        public string Price {
            set { amountLabel.Text = value; }
            get { return amountLabel.Text; }
        }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Image {
            set { productPictureBox.ImageLocation = value; }
            get { return productPictureBox.ImageLocation; }
        }
        public int Tax { get; set; }
        public int Quantity {
            set { quantityBox.Value = value; }
            get { return (int)quantityBox.Value; }
        }
        public int Stock { get; set; }
        public Product()
        {
            InitializeComponent();
        }

        public event EventHandler selected = null;
        private void addButton_Click(object sender, EventArgs e)
        {
            selected?.Invoke(this, EventArgs.Empty);
        }
    }
}
