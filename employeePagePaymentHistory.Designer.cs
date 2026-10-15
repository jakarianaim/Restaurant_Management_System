
namespace Restaurant_Management_System
{
    partial class employeePagePaymentHistory
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
            this.viewProductBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.paymentHistoryBtn = new System.Windows.Forms.Button();
            this.orderHistoryBtn = new System.Windows.Forms.Button();
            this.catogoryBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showAllOrderHistoryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.ownerProfileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(99)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ownerProfileButton);
            this.panel1.Controls.Add(this.viewProductBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.paymentHistoryBtn);
            this.panel1.Controls.Add(this.orderHistoryBtn);
            this.panel1.Controls.Add(this.catogoryBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 545);
            this.panel1.TabIndex = 11;
            // 
            // viewProductBtn
            // 
            this.viewProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.viewProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProductBtn.Location = new System.Drawing.Point(2, 180);
            this.viewProductBtn.Name = "viewProductBtn";
            this.viewProductBtn.Size = new System.Drawing.Size(304, 50);
            this.viewProductBtn.TabIndex = 0;
            this.viewProductBtn.Text = "View Product";
            this.viewProductBtn.UseVisualStyleBackColor = false;
            this.viewProductBtn.Click += new System.EventHandler(this.viewProductBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(2, 408);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(304, 50);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // paymentHistoryBtn
            // 
            this.paymentHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.paymentHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentHistoryBtn.Location = new System.Drawing.Point(2, 351);
            this.paymentHistoryBtn.Name = "paymentHistoryBtn";
            this.paymentHistoryBtn.Size = new System.Drawing.Size(304, 50);
            this.paymentHistoryBtn.TabIndex = 7;
            this.paymentHistoryBtn.Text = "Payment History";
            this.paymentHistoryBtn.UseVisualStyleBackColor = false;
            // 
            // orderHistoryBtn
            // 
            this.orderHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.orderHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryBtn.Location = new System.Drawing.Point(3, 237);
            this.orderHistoryBtn.Name = "orderHistoryBtn";
            this.orderHistoryBtn.Size = new System.Drawing.Size(304, 50);
            this.orderHistoryBtn.TabIndex = 5;
            this.orderHistoryBtn.Text = "Order History";
            this.orderHistoryBtn.UseVisualStyleBackColor = false;
            this.orderHistoryBtn.Click += new System.EventHandler(this.orderHistoryBtn_Click);
            // 
            // catogoryBtn
            // 
            this.catogoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.catogoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catogoryBtn.Location = new System.Drawing.Point(3, 294);
            this.catogoryBtn.Name = "catogoryBtn";
            this.catogoryBtn.Size = new System.Drawing.Size(304, 50);
            this.catogoryBtn.TabIndex = 4;
            this.catogoryBtn.Text = "Catogory";
            this.catogoryBtn.UseVisualStyleBackColor = false;
            this.catogoryBtn.Click += new System.EventHandler(this.catogoryBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.showAllOrderHistoryBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(307, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 63);
            this.panel3.TabIndex = 12;
            // 
            // showAllOrderHistoryBtn
            // 
            this.showAllOrderHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllOrderHistoryBtn.Location = new System.Drawing.Point(652, 27);
            this.showAllOrderHistoryBtn.Name = "showAllOrderHistoryBtn";
            this.showAllOrderHistoryBtn.Size = new System.Drawing.Size(100, 29);
            this.showAllOrderHistoryBtn.TabIndex = 1;
            this.showAllOrderHistoryBtn.Text = "Show All>>";
            this.showAllOrderHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment History";
            // 
            // paymentHistoryDataGridView
            // 
            this.paymentHistoryDataGridView.AllowUserToAddRows = false;
            this.paymentHistoryDataGridView.AllowUserToDeleteRows = false;
            this.paymentHistoryDataGridView.AllowUserToResizeColumns = false;
            this.paymentHistoryDataGridView.AllowUserToResizeRows = false;
            this.paymentHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentHistoryDataGridView.Location = new System.Drawing.Point(307, 63);
            this.paymentHistoryDataGridView.Name = "paymentHistoryDataGridView";
            this.paymentHistoryDataGridView.ReadOnly = true;
            this.paymentHistoryDataGridView.RowHeadersWidth = 4;
            this.paymentHistoryDataGridView.RowTemplate.Height = 28;
            this.paymentHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentHistoryDataGridView.Size = new System.Drawing.Size(771, 482);
            this.paymentHistoryDataGridView.TabIndex = 13;
            // 
            // ownerProfileButton
            // 
            this.ownerProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.ownerProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ownerProfileButton.Image = global::Restaurant_Management_System.Properties.Resources.AdminButtonPhoto;
            this.ownerProfileButton.Location = new System.Drawing.Point(89, 20);
            this.ownerProfileButton.Name = "ownerProfileButton";
            this.ownerProfileButton.Size = new System.Drawing.Size(125, 125);
            this.ownerProfileButton.TabIndex = 12;
            this.ownerProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ownerProfileButton.UseVisualStyleBackColor = false;
            this.ownerProfileButton.Click += new System.EventHandler(this.ownerProfileButton_Click);
            // 
            // employeePagePaymentHistory
            // 
            this.ClientSize = new System.Drawing.Size(1080, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paymentHistoryDataGridView);
            this.Name = "employeePagePaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeePagePaymentHistory";
            this.Load += new System.EventHandler(this.employeePagePaymentHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewProductBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button paymentHistoryBtn;
        private System.Windows.Forms.Button orderHistoryBtn;
        private System.Windows.Forms.Button catogoryBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button showAllOrderHistoryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView paymentHistoryDataGridView;
        private System.Windows.Forms.Button ownerProfileButton;
    }
}