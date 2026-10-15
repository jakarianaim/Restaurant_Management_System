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
    public partial class Category : UserControl
    {
        public string Id { get; set; }
        public string Name
        {
            set { categoryName.Text = value; }
            get { return categoryName.Text; }
        }
        public string Status { get; set; }
        public string Image
        {
            set { categoryPictureBox.ImageLocation = value; }
            get { return categoryPictureBox.ImageLocation; }
        }

        public Category()
        {
            InitializeComponent();
            this.Click += Category_Click;
            categoryPictureBox.Click += Category_Click;
        }

        
        public event EventHandler selected = null;
        private void Category_Click(object sender, EventArgs e)
        {
            selected?.Invoke(this, EventArgs.Empty);
        }
    }
}
