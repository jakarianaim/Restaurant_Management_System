
namespace Restaurant_Management_System
{
    partial class ownerPagePaymentHistory
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
            this.paymentHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentHistoryDataGridView
            // 
            this.paymentHistoryDataGridView.AllowUserToAddRows = false;
            this.paymentHistoryDataGridView.AllowUserToDeleteRows = false;
            this.paymentHistoryDataGridView.AllowUserToResizeColumns = false;
            this.paymentHistoryDataGridView.AllowUserToResizeRows = false;
            this.paymentHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentHistoryDataGridView.Location = new System.Drawing.Point(-1, 57);
            this.paymentHistoryDataGridView.Name = "paymentHistoryDataGridView";
            this.paymentHistoryDataGridView.ReadOnly = true;
            this.paymentHistoryDataGridView.RowHeadersWidth = 4;
            this.paymentHistoryDataGridView.RowTemplate.Height = 24;
            this.paymentHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentHistoryDataGridView.Size = new System.Drawing.Size(1080, 489);
            this.paymentHistoryDataGridView.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.showAllBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 56);
            this.panel2.TabIndex = 7;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(964, 9);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(104, 36);
            this.showAllBtn.TabIndex = 1;
            this.showAllBtn.Text = "Show all>>";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment History";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 36);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ownerPagePaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 548);
            this.Controls.Add(this.paymentHistoryDataGridView);
            this.Controls.Add(this.panel2);
            this.Name = "ownerPagePaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ownerPagePaymentHistory";
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentHistoryDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Label label1;
    }
}