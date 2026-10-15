
namespace Restaurant_Management_System
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.productName = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(34, 100);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(85, 16);
            this.productName.TabIndex = 1;
            this.productName.Text = "Spicy Burger";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(34, 123);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(29, 16);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity :";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(71, 146);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(75, 22);
            this.quantityBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(40, 171);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(3, 3);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(154, 94);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productPictureBox);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(158, 198);
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Button addButton;
    }
}
