
namespace Restaurant_Management_System
{
    partial class Category
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
            this.categoryPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryPictureBox
            // 
            this.categoryPictureBox.Location = new System.Drawing.Point(3, 3);
            this.categoryPictureBox.Name = "categoryPictureBox";
            this.categoryPictureBox.Size = new System.Drawing.Size(164, 128);
            this.categoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryPictureBox.TabIndex = 0;
            this.categoryPictureBox.TabStop = false;
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Location = new System.Drawing.Point(59, 144);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(48, 16);
            this.categoryName.TabIndex = 1;
            this.categoryName.Text = "Burger";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.categoryPictureBox);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(170, 170);
            ((System.ComponentModel.ISupportInitialize)(this.categoryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox categoryPictureBox;
        private System.Windows.Forms.Label categoryName;
    }
}
