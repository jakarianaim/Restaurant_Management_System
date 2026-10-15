
namespace Restaurant_Management_System
{
    partial class ownerPageCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ownerProfileButton = new System.Windows.Forms.Button();
            this.logoutOwnerBtn = new System.Windows.Forms.Button();
            this.orderHistoryBtn = new System.Windows.Forms.Button();
            this.discountBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.categorySearchTextBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.addImageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryImagePictureBox = new System.Windows.Forms.PictureBox();
            this.categoryStatusComboBox = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.categoryIdTextbox = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.categoryNameTextbox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.ownerProfileButton);
            this.panel1.Controls.Add(this.logoutOwnerBtn);
            this.panel1.Controls.Add(this.orderHistoryBtn);
            this.panel1.Controls.Add(this.discountBtn);
            this.panel1.Controls.Add(this.employeeBtn);
            this.panel1.Controls.Add(this.categoryBtn);
            this.panel1.Controls.Add(this.productsBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 545);
            this.panel1.TabIndex = 3;
            // 
            // ownerProfileButton
            // 
            this.ownerProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.ownerProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ownerProfileButton.Image = global::Restaurant_Management_System.Properties.Resources.AdminButtonPhoto;
            this.ownerProfileButton.Location = new System.Drawing.Point(89, 7);
            this.ownerProfileButton.Name = "ownerProfileButton";
            this.ownerProfileButton.Size = new System.Drawing.Size(125, 125);
            this.ownerProfileButton.TabIndex = 9;
            this.ownerProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ownerProfileButton.UseVisualStyleBackColor = false;
            this.ownerProfileButton.Click += new System.EventHandler(this.ownerProfileButton_Click);
            // 
            // logoutOwnerBtn
            // 
            this.logoutOwnerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.logoutOwnerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutOwnerBtn.Location = new System.Drawing.Point(3, 473);
            this.logoutOwnerBtn.Name = "logoutOwnerBtn";
            this.logoutOwnerBtn.Size = new System.Drawing.Size(304, 50);
            this.logoutOwnerBtn.TabIndex = 8;
            this.logoutOwnerBtn.Text = "Logout";
            this.logoutOwnerBtn.UseVisualStyleBackColor = false;
            this.logoutOwnerBtn.Click += new System.EventHandler(this.logoutOwnerBtn_Click);
            // 
            // orderHistoryBtn
            // 
            this.orderHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.orderHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryBtn.Location = new System.Drawing.Point(0, 417);
            this.orderHistoryBtn.Name = "orderHistoryBtn";
            this.orderHistoryBtn.Size = new System.Drawing.Size(304, 50);
            this.orderHistoryBtn.TabIndex = 7;
            this.orderHistoryBtn.Text = "Order History";
            this.orderHistoryBtn.UseVisualStyleBackColor = false;
            this.orderHistoryBtn.Click += new System.EventHandler(this.orderHistoryBtn_Click);
            // 
            // discountBtn
            // 
            this.discountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.discountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBtn.Location = new System.Drawing.Point(1, 363);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(304, 50);
            this.discountBtn.TabIndex = 4;
            this.discountBtn.Text = "Discount";
            this.discountBtn.UseVisualStyleBackColor = false;
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.employeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBtn.Location = new System.Drawing.Point(0, 195);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(304, 50);
            this.employeeBtn.TabIndex = 3;
            this.employeeBtn.Text = "Employee";
            this.employeeBtn.UseVisualStyleBackColor = false;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.categoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.Location = new System.Drawing.Point(1, 307);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(304, 50);
            this.categoryBtn.TabIndex = 2;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = false;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.productsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.Location = new System.Drawing.Point(1, 251);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(304, 50);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Location = new System.Drawing.Point(0, 139);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(304, 50);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.categorySearchTextBox);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.addImageBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.categoryImagePictureBox);
            this.panel2.Controls.Add(this.categoryStatusComboBox);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.categoryGridView);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.categoryIdTextbox);
            this.panel2.Controls.Add(this.removeBtn);
            this.panel2.Controls.Add(this.categoryNameTextbox);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(307, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 545);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // categorySearchTextBox
            // 
            this.categorySearchTextBox.Location = new System.Drawing.Point(409, 7);
            this.categorySearchTextBox.Name = "categorySearchTextBox";
            this.categorySearchTextBox.Size = new System.Drawing.Size(348, 22);
            this.categorySearchTextBox.TabIndex = 59;
            this.categorySearchTextBox.TextChanged += new System.EventHandler(this.categorySearchTextBox_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(343, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(51, 16);
            this.Search.TabIndex = 58;
            this.Search.Text = "Search";
            // 
            // addImageBtn
            // 
            this.addImageBtn.BackColor = System.Drawing.Color.Yellow;
            this.addImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBtn.Location = new System.Drawing.Point(25, 467);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(218, 43);
            this.addImageBtn.TabIndex = 57;
            this.addImageBtn.Text = "Add Image";
            this.addImageBtn.UseVisualStyleBackColor = false;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Category Image";
            // 
            // categoryImagePictureBox
            // 
            this.categoryImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryImagePictureBox.Location = new System.Drawing.Point(25, 277);
            this.categoryImagePictureBox.Name = "categoryImagePictureBox";
            this.categoryImagePictureBox.Size = new System.Drawing.Size(218, 177);
            this.categoryImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryImagePictureBox.TabIndex = 55;
            this.categoryImagePictureBox.TabStop = false;
            // 
            // categoryStatusComboBox
            // 
            this.categoryStatusComboBox.FormattingEnabled = true;
            this.categoryStatusComboBox.Items.AddRange(new object[] {
            "Available",
            "Sold Out"});
            this.categoryStatusComboBox.Location = new System.Drawing.Point(26, 204);
            this.categoryStatusComboBox.Name = "categoryStatusComboBox";
            this.categoryStatusComboBox.Size = new System.Drawing.Size(217, 24);
            this.categoryStatusComboBox.TabIndex = 52;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(645, 493);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 41);
            this.clearBtn.TabIndex = 51;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToAddRows = false;
            this.categoryGridView.AllowUserToDeleteRows = false;
            this.categoryGridView.AllowUserToResizeColumns = false;
            this.categoryGridView.AllowUserToResizeRows = false;
            this.categoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.GridColor = System.Drawing.SystemColors.ControlText;
            this.categoryGridView.Location = new System.Drawing.Point(249, 40);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.RowHeadersWidth = 4;
            this.categoryGridView.RowTemplate.Height = 28;
            this.categoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGridView.Size = new System.Drawing.Size(508, 447);
            this.categoryGridView.TabIndex = 46;
            this.categoryGridView.DoubleClick += new System.EventHandler(this.categoryGridView_DoubleClick);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Red;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(564, 493);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 41);
            this.updateBtn.TabIndex = 50;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // categoryIdTextbox
            // 
            this.categoryIdTextbox.Location = new System.Drawing.Point(26, 68);
            this.categoryIdTextbox.Name = "categoryIdTextbox";
            this.categoryIdTextbox.ReadOnly = true;
            this.categoryIdTextbox.Size = new System.Drawing.Size(217, 22);
            this.categoryIdTextbox.TabIndex = 30;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(472, 493);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(86, 41);
            this.removeBtn.TabIndex = 49;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // categoryNameTextbox
            // 
            this.categoryNameTextbox.Location = new System.Drawing.Point(26, 139);
            this.categoryNameTextbox.Name = "categoryNameTextbox";
            this.categoryNameTextbox.Size = new System.Drawing.Size(217, 22);
            this.categoryNameTextbox.TabIndex = 31;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Red;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(391, 493);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 41);
            this.addBtn.TabIndex = 48;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Category ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Category Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Category Status";
            // 
            // ownerPageCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ownerPageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ownerPageCategory";
            this.Load += new System.EventHandler(this.ownerPageCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutOwnerBtn;
        private System.Windows.Forms.Button orderHistoryBtn;
        private System.Windows.Forms.Button discountBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox categorySearchTextBox;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button addImageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox categoryImagePictureBox;
        private System.Windows.Forms.ComboBox categoryStatusComboBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox categoryIdTextbox;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox categoryNameTextbox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ownerProfileButton;
    }
}