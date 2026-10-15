
namespace Restaurant_Management_System
{
    partial class Form2
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
            this.reloadBtn = new System.Windows.Forms.Button();
            this.lebelDashboard = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeHistoryGird = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.employeeNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.totalProductsNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalCategoryNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.topSaleProductLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderCompleteNumber = new System.Windows.Forms.Label();
            this.totalSalesNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeHistoryGird)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // ownerProfileButton
            // 
            this.ownerProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.ownerProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ownerProfileButton.Image = global::Restaurant_Management_System.Properties.Resources.AdminButtonPhoto;
            this.ownerProfileButton.Location = new System.Drawing.Point(93, 8);
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
            this.discountBtn.Location = new System.Drawing.Point(3, 361);
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
            this.employeeBtn.Location = new System.Drawing.Point(2, 193);
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
            this.categoryBtn.Location = new System.Drawing.Point(3, 305);
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
            this.productsBtn.Location = new System.Drawing.Point(3, 249);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(304, 50);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click_1);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Location = new System.Drawing.Point(2, 137);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(304, 50);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.reloadBtn);
            this.panel2.Controls.Add(this.lebelDashboard);
            this.panel2.Location = new System.Drawing.Point(307, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 40);
            this.panel2.TabIndex = 1;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(652, 11);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(75, 23);
            this.reloadBtn.TabIndex = 1;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // lebelDashboard
            // 
            this.lebelDashboard.AutoSize = true;
            this.lebelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebelDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lebelDashboard.Location = new System.Drawing.Point(5, 8);
            this.lebelDashboard.Name = "lebelDashboard";
            this.lebelDashboard.Size = new System.Drawing.Size(87, 17);
            this.lebelDashboard.TabIndex = 0;
            this.lebelDashboard.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.employeeHistoryGird);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(307, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 545);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(42, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Employee History";
            // 
            // employeeHistoryGird
            // 
            this.employeeHistoryGird.AllowUserToAddRows = false;
            this.employeeHistoryGird.AllowUserToDeleteRows = false;
            this.employeeHistoryGird.AllowUserToResizeColumns = false;
            this.employeeHistoryGird.AllowUserToResizeRows = false;
            this.employeeHistoryGird.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeHistoryGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeHistoryGird.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.CompleteOrder,
            this.WorkingDays});
            this.employeeHistoryGird.Location = new System.Drawing.Point(45, 279);
            this.employeeHistoryGird.Name = "employeeHistoryGird";
            this.employeeHistoryGird.ReadOnly = true;
            this.employeeHistoryGird.RowHeadersWidth = 4;
            this.employeeHistoryGird.RowTemplate.Height = 28;
            this.employeeHistoryGird.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeHistoryGird.Size = new System.Drawing.Size(680, 174);
            this.employeeHistoryGird.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 7;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 7;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // CompleteOrder
            // 
            this.CompleteOrder.HeaderText = "Complete Order";
            this.CompleteOrder.MinimumWidth = 7;
            this.CompleteOrder.Name = "CompleteOrder";
            this.CompleteOrder.ReadOnly = true;
            // 
            // WorkingDays
            // 
            this.WorkingDays.HeaderText = "Working Days";
            this.WorkingDays.MinimumWidth = 7;
            this.WorkingDays.Name = "WorkingDays";
            this.WorkingDays.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.totalSalesNumber);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(525, 133);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-1, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total sales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.orderCompleteNumber);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(285, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-1, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Order Complete";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.employeeNumber);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(45, 133);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 2;
            // 
            // employeeNumber
            // 
            this.employeeNumber.Location = new System.Drawing.Point(-1, 60);
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Size = new System.Drawing.Size(200, 16);
            this.employeeNumber.TabIndex = 3;
            this.employeeNumber.Text = "0";
            this.employeeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-1, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.totalProductsNumber);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(527, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 1;
            // 
            // totalProductsNumber
            // 
            this.totalProductsNumber.Location = new System.Drawing.Point(-1, 55);
            this.totalProductsNumber.Name = "totalProductsNumber";
            this.totalProductsNumber.Size = new System.Drawing.Size(200, 16);
            this.totalProductsNumber.TabIndex = 2;
            this.totalProductsNumber.Text = "0";
            this.totalProductsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-1, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Products";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.totalCategoryNumber);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(287, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 1;
            // 
            // totalCategoryNumber
            // 
            this.totalCategoryNumber.Location = new System.Drawing.Point(-1, 55);
            this.totalCategoryNumber.Name = "totalCategoryNumber";
            this.totalCategoryNumber.Size = new System.Drawing.Size(200, 16);
            this.totalCategoryNumber.TabIndex = 2;
            this.totalCategoryNumber.Text = "0";
            this.totalCategoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.topSaleProductLabel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(47, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // topSaleProductLabel
            // 
            this.topSaleProductLabel.Location = new System.Drawing.Point(-1, 55);
            this.topSaleProductLabel.Name = "topSaleProductLabel";
            this.topSaleProductLabel.Size = new System.Drawing.Size(200, 16);
            this.topSaleProductLabel.TabIndex = 1;
            this.topSaleProductLabel.Text = "-----";
            this.topSaleProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Sale Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderCompleteNumber
            // 
            this.orderCompleteNumber.Location = new System.Drawing.Point(-1, 60);
            this.orderCompleteNumber.Name = "orderCompleteNumber";
            this.orderCompleteNumber.Size = new System.Drawing.Size(200, 16);
            this.orderCompleteNumber.TabIndex = 4;
            this.orderCompleteNumber.Text = "0";
            this.orderCompleteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSalesNumber
            // 
            this.totalSalesNumber.Location = new System.Drawing.Point(1, 60);
            this.totalSalesNumber.Name = "totalSalesNumber";
            this.totalSalesNumber.Size = new System.Drawing.Size(200, 16);
            this.totalSalesNumber.TabIndex = 5;
            this.totalSalesNumber.Text = "0";
            this.totalSalesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1080, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ownerPageDashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeHistoryGird)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Label lebelDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label topSaleProductLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalProductsNumber;
        private System.Windows.Forms.Label totalCategoryNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView employeeHistoryGird;
        private System.Windows.Forms.Label employeeNumber;
        private System.Windows.Forms.Button ownerProfileButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompleteOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingDays;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label totalSalesNumber;
        private System.Windows.Forms.Label orderCompleteNumber;
    }
}