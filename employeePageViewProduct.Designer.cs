
namespace Restaurant_Management_System
{
    partial class employeePageViewProduct
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.semiTotalBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paymentOptioncomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.couponBox = new System.Windows.Forms.TextBox();
            this.cancelDiscountBtn = new System.Windows.Forms.Button();
            this.applyDiscountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewProductBtn = new System.Windows.Forms.Button();
            this.paymentHistoryBtn = new System.Windows.Forms.Button();
            this.orderHistoryBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ownerProfileButton = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.showProductFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.CartList = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartList)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Red;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearBtn.Location = new System.Drawing.Point(36, 171);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 38);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Red;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextBtn.Location = new System.Drawing.Point(201, 171);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(90, 38);
            this.nextBtn.TabIndex = 12;
            this.nextBtn.Text = "Payment";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(159, 44);
            this.discountBox.Name = "discountBox";
            this.discountBox.ReadOnly = true;
            this.discountBox.Size = new System.Drawing.Size(100, 22);
            this.discountBox.TabIndex = 10;
            this.discountBox.Text = "0";
            this.discountBox.Visible = false;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(159, 107);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(132, 22);
            this.totalBox.TabIndex = 9;
            this.totalBox.Text = "0.0";
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(159, 75);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(132, 22);
            this.taxBox.TabIndex = 8;
            this.taxBox.Text = "0.0";
            // 
            // semiTotalBox
            // 
            this.semiTotalBox.Location = new System.Drawing.Point(159, 11);
            this.semiTotalBox.Name = "semiTotalBox";
            this.semiTotalBox.ReadOnly = true;
            this.semiTotalBox.Size = new System.Drawing.Size(132, 22);
            this.semiTotalBox.TabIndex = 7;
            this.semiTotalBox.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Discount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tax :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semi Total : ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.paymentOptioncomboBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.couponBox);
            this.panel5.Controls.Add(this.cancelDiscountBtn);
            this.panel5.Controls.Add(this.applyDiscountBtn);
            this.panel5.Controls.Add(this.clearBtn);
            this.panel5.Controls.Add(this.nextBtn);
            this.panel5.Controls.Add(this.discountBox);
            this.panel5.Controls.Add(this.totalBox);
            this.panel5.Controls.Add(this.taxBox);
            this.panel5.Controls.Add(this.semiTotalBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(694, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 216);
            this.panel5.TabIndex = 5;
            // 
            // paymentOptioncomboBox
            // 
            this.paymentOptioncomboBox.FormattingEnabled = true;
            this.paymentOptioncomboBox.Items.AddRange(new object[] {
            "Cash",
            "Bkash",
            "Nagad"});
            this.paymentOptioncomboBox.Location = new System.Drawing.Point(159, 142);
            this.paymentOptioncomboBox.Name = "paymentOptioncomboBox";
            this.paymentOptioncomboBox.Size = new System.Drawing.Size(132, 24);
            this.paymentOptioncomboBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Payment :";
            // 
            // couponBox
            // 
            this.couponBox.Location = new System.Drawing.Point(159, 43);
            this.couponBox.Name = "couponBox";
            this.couponBox.Size = new System.Drawing.Size(100, 22);
            this.couponBox.TabIndex = 16;
            // 
            // cancelDiscountBtn
            // 
            this.cancelDiscountBtn.Location = new System.Drawing.Point(265, 45);
            this.cancelDiscountBtn.Name = "cancelDiscountBtn";
            this.cancelDiscountBtn.Size = new System.Drawing.Size(26, 23);
            this.cancelDiscountBtn.TabIndex = 15;
            this.cancelDiscountBtn.Text = "X";
            this.cancelDiscountBtn.UseVisualStyleBackColor = true;
            this.cancelDiscountBtn.Visible = false;
            this.cancelDiscountBtn.Click += new System.EventHandler(this.cancelDiscountBtn_Click);
            // 
            // applyDiscountBtn
            // 
            this.applyDiscountBtn.Location = new System.Drawing.Point(265, 43);
            this.applyDiscountBtn.Name = "applyDiscountBtn";
            this.applyDiscountBtn.Size = new System.Drawing.Size(26, 26);
            this.applyDiscountBtn.TabIndex = 14;
            this.applyDiscountBtn.Text = "✓";
            this.applyDiscountBtn.UseVisualStyleBackColor = true;
            this.applyDiscountBtn.Click += new System.EventHandler(this.applyDiscountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Take Order";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(307, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 53);
            this.panel2.TabIndex = 6;
            // 
            // viewProductBtn
            // 
            this.viewProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.viewProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProductBtn.Location = new System.Drawing.Point(0, 180);
            this.viewProductBtn.Name = "viewProductBtn";
            this.viewProductBtn.Size = new System.Drawing.Size(306, 50);
            this.viewProductBtn.TabIndex = 0;
            this.viewProductBtn.Text = "View Product";
            this.viewProductBtn.UseVisualStyleBackColor = false;
            this.viewProductBtn.Click += new System.EventHandler(this.viewProductBtn_Click);
            // 
            // paymentHistoryBtn
            // 
            this.paymentHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.paymentHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentHistoryBtn.Location = new System.Drawing.Point(0, 353);
            this.paymentHistoryBtn.Name = "paymentHistoryBtn";
            this.paymentHistoryBtn.Size = new System.Drawing.Size(307, 50);
            this.paymentHistoryBtn.TabIndex = 7;
            this.paymentHistoryBtn.Text = "Payment History";
            this.paymentHistoryBtn.UseVisualStyleBackColor = false;
            this.paymentHistoryBtn.Click += new System.EventHandler(this.paymentHistoryBtn_Click);
            // 
            // orderHistoryBtn
            // 
            this.orderHistoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.orderHistoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryBtn.Location = new System.Drawing.Point(0, 237);
            this.orderHistoryBtn.Name = "orderHistoryBtn";
            this.orderHistoryBtn.Size = new System.Drawing.Size(308, 50);
            this.orderHistoryBtn.TabIndex = 5;
            this.orderHistoryBtn.Text = "Order History";
            this.orderHistoryBtn.UseVisualStyleBackColor = false;
            this.orderHistoryBtn.Click += new System.EventHandler(this.orderHistoryBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.categoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.Location = new System.Drawing.Point(0, 295);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(307, 50);
            this.categoryBtn.TabIndex = 4;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = false;
            this.categoryBtn.Click += new System.EventHandler(this.catogoryBtn_Click);
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
            this.panel1.Controls.Add(this.categoryBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 545);
            this.panel1.TabIndex = 4;
            // 
            // ownerProfileButton
            // 
            this.ownerProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ownerProfileButton.Image = global::Restaurant_Management_System.Properties.Resources.AdminButtonPhoto;
            this.ownerProfileButton.Location = new System.Drawing.Point(89, 20);
            this.ownerProfileButton.Name = "ownerProfileButton";
            this.ownerProfileButton.Size = new System.Drawing.Size(125, 125);
            this.ownerProfileButton.TabIndex = 9;
            this.ownerProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ownerProfileButton.UseVisualStyleBackColor = true;
            this.ownerProfileButton.Click += new System.EventHandler(this.ownerProfileButton_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(171)))), ((int)(((byte)(139)))));
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(0, 411);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(309, 50);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // showProductFlow
            // 
            this.showProductFlow.BackColor = System.Drawing.Color.AliceBlue;
            this.showProductFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showProductFlow.Location = new System.Drawing.Point(307, 54);
            this.showProductFlow.Name = "showProductFlow";
            this.showProductFlow.Size = new System.Drawing.Size(387, 491);
            this.showProductFlow.TabIndex = 9;
            // 
            // CartList
            // 
            this.CartList.AllowUserToAddRows = false;
            this.CartList.AllowUserToDeleteRows = false;
            this.CartList.AllowUserToResizeColumns = false;
            this.CartList.AllowUserToResizeRows = false;
            this.CartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.Name,
            this.Quantity,
            this.Total});
            this.CartList.Location = new System.Drawing.Point(694, 53);
            this.CartList.Name = "CartList";
            this.CartList.RowHeadersWidth = 4;
            this.CartList.RowTemplate.Height = 24;
            this.CartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartList.Size = new System.Drawing.Size(387, 270);
            this.CartList.TabIndex = 10;
            // 
            // productId
            // 
            this.productId.HeaderText = "productId";
            this.productId.MinimumWidth = 7;
            this.productId.Name = "productId";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 7;
            this.Name.Name = "Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 7;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 7;
            this.Total.Name = "Total";
            // 
            // employeePageViewProduct
            // 
            this.ClientSize = new System.Drawing.Size(1080, 548);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.showProductFlow);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "employeePageViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeePageViewProduct";
            this.Load += new System.EventHandler(this.employeePageViewProduct_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox semiTotalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button viewProductBtn;
        private System.Windows.Forms.Button paymentHistoryBtn;
        private System.Windows.Forms.Button orderHistoryBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ownerProfileButton;
        private System.Windows.Forms.FlowLayoutPanel showProductFlow;
        private System.Windows.Forms.Button applyDiscountBtn;
        private System.Windows.Forms.Button cancelDiscountBtn;
        private System.Windows.Forms.TextBox couponBox;
        private System.Windows.Forms.ComboBox paymentOptioncomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView CartList;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button logoutBtn;
    }
}