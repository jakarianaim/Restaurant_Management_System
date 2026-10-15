
namespace Restaurant_Management_System
{
    partial class LogIn
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.loginPageIDlabel = new System.Windows.Forms.Label();
            this.loginPageUserIdLabel = new System.Windows.Forms.Label();
            this.showPasswordBox = new System.Windows.Forms.CheckBox();
            this.loginPageLoginButton = new System.Windows.Forms.Button();
            this.loginPagePasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginPageUserIdtextBox = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(537, 555);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // loginPageIDlabel
            // 
            this.loginPageIDlabel.AutoSize = true;
            this.loginPageIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPageIDlabel.Location = new System.Drawing.Point(543, 220);
            this.loginPageIDlabel.Name = "loginPageIDlabel";
            this.loginPageIDlabel.Size = new System.Drawing.Size(142, 31);
            this.loginPageIDlabel.TabIndex = 15;
            this.loginPageIDlabel.Text = "Password";
            // 
            // loginPageUserIdLabel
            // 
            this.loginPageUserIdLabel.AutoSize = true;
            this.loginPageUserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPageUserIdLabel.Location = new System.Drawing.Point(543, 102);
            this.loginPageUserIdLabel.Name = "loginPageUserIdLabel";
            this.loginPageUserIdLabel.Size = new System.Drawing.Size(114, 31);
            this.loginPageUserIdLabel.TabIndex = 14;
            this.loginPageUserIdLabel.Text = "User ID";
            // 
            // showPasswordBox
            // 
            this.showPasswordBox.AutoSize = true;
            this.showPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordBox.Location = new System.Drawing.Point(549, 331);
            this.showPasswordBox.Name = "showPasswordBox";
            this.showPasswordBox.Size = new System.Drawing.Size(152, 22);
            this.showPasswordBox.TabIndex = 13;
            this.showPasswordBox.Text = "Show Password";
            this.showPasswordBox.UseVisualStyleBackColor = true;
            this.showPasswordBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginPageLoginButton
            // 
            this.loginPageLoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginPageLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginPageLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPageLoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginPageLoginButton.Location = new System.Drawing.Point(549, 406);
            this.loginPageLoginButton.Name = "loginPageLoginButton";
            this.loginPageLoginButton.Size = new System.Drawing.Size(518, 39);
            this.loginPageLoginButton.TabIndex = 12;
            this.loginPageLoginButton.Text = "Login";
            this.loginPageLoginButton.UseVisualStyleBackColor = false;
            this.loginPageLoginButton.Click += new System.EventHandler(this.loginPageLoginButton_Click);
            // 
            // loginPagePasswordTextBox
            // 
            this.loginPagePasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPagePasswordTextBox.Location = new System.Drawing.Point(549, 265);
            this.loginPagePasswordTextBox.Name = "loginPagePasswordTextBox";
            this.loginPagePasswordTextBox.Size = new System.Drawing.Size(475, 37);
            this.loginPagePasswordTextBox.TabIndex = 11;
            this.loginPagePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // loginPageUserIdtextBox
            // 
            this.loginPageUserIdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPageUserIdtextBox.Location = new System.Drawing.Point(549, 150);
            this.loginPageUserIdtextBox.Name = "loginPageUserIdtextBox";
            this.loginPageUserIdtextBox.Size = new System.Drawing.Size(475, 37);
            this.loginPageUserIdtextBox.TabIndex = 10;
            // 
            // LogIn
            // 
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.loginPageIDlabel);
            this.Controls.Add(this.loginPageUserIdLabel);
            this.Controls.Add(this.showPasswordBox);
            this.Controls.Add(this.loginPageLoginButton);
            this.Controls.Add(this.loginPagePasswordTextBox);
            this.Controls.Add(this.loginPageUserIdtextBox);
            this.Controls.Add(pictureBox1);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginPageIDlabel;
        private System.Windows.Forms.Label loginPageUserIdLabel;
        private System.Windows.Forms.CheckBox showPasswordBox;
        private System.Windows.Forms.Button loginPageLoginButton;
        private System.Windows.Forms.TextBox loginPagePasswordTextBox;
        private System.Windows.Forms.TextBox loginPageUserIdtextBox;
    }
}