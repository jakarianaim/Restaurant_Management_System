
namespace Restaurant_Management_System
{
    partial class Method
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
            this.MethodNamelabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.methodStatusComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MethodNamelabel
            // 
            this.MethodNamelabel.AutoSize = true;
            this.MethodNamelabel.Location = new System.Drawing.Point(62, 18);
            this.MethodNamelabel.Name = "MethodNamelabel";
            this.MethodNamelabel.Size = new System.Drawing.Size(93, 16);
            this.MethodNamelabel.TabIndex = 0;
            this.MethodNamelabel.Text = "Method Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(634, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // methodStatusComboBox
            // 
            this.methodStatusComboBox.FormattingEnabled = true;
            this.methodStatusComboBox.Location = new System.Drawing.Point(498, 14);
            this.methodStatusComboBox.Name = "methodStatusComboBox";
            this.methodStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.methodStatusComboBox.TabIndex = 2;
            // 
            // Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.methodStatusComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.MethodNamelabel);
            this.Name = "Method";
            this.Size = new System.Drawing.Size(730, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MethodNamelabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox methodStatusComboBox;
    }
}
