namespace MyApplication
{
    partial class RegisterForm
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
			this.usernameLable = new System.Windows.Forms.Label();
			this.passwordLable = new System.Windows.Forms.Label();
			this.fullnameLable = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.fullnameTextBox = new System.Windows.Forms.TextBox();
			this.registerButton = new System.Windows.Forms.Button();
			this.resetBotton = new System.Windows.Forms.Button();
			this.loginBotton = new System.Windows.Forms.Button();
			this.exitBotton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLable
			// 
			this.usernameLable.AutoSize = true;
			this.usernameLable.ForeColor = System.Drawing.Color.White;
			this.usernameLable.Location = new System.Drawing.Point(13, 14);
			this.usernameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.usernameLable.Name = "usernameLable";
			this.usernameLable.Size = new System.Drawing.Size(74, 13);
			this.usernameLable.TabIndex = 0;
			this.usernameLable.Text = "&Username :";
			// 
			// passwordLable
			// 
			this.passwordLable.AutoSize = true;
			this.passwordLable.ForeColor = System.Drawing.Color.White;
			this.passwordLable.Location = new System.Drawing.Point(13, 38);
			this.passwordLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.passwordLable.Name = "passwordLable";
			this.passwordLable.Size = new System.Drawing.Size(70, 13);
			this.passwordLable.TabIndex = 2;
			this.passwordLable.Text = "&Password :";
			// 
			// fullnameLable
			// 
			this.fullnameLable.AutoSize = true;
			this.fullnameLable.ForeColor = System.Drawing.Color.White;
			this.fullnameLable.Location = new System.Drawing.Point(13, 63);
			this.fullnameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fullnameLable.Name = "fullnameLable";
			this.fullnameLable.Size = new System.Drawing.Size(72, 13);
			this.fullnameLable.TabIndex = 4;
			this.fullnameLable.Text = "&Full Name :";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.usernameTextBox.Location = new System.Drawing.Point(89, 11);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(319, 21);
			this.usernameTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.passwordTextBox.Location = new System.Drawing.Point(89, 35);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(319, 21);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// fullnameTextBox
			// 
			this.fullnameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.fullnameTextBox.Location = new System.Drawing.Point(89, 60);
			this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.fullnameTextBox.MaxLength = 50;
			this.fullnameTextBox.Name = "fullnameTextBox";
			this.fullnameTextBox.Size = new System.Drawing.Size(319, 21);
			this.fullnameTextBox.TabIndex = 5;
			// 
			// registerButton
			// 
			this.registerButton.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.registerButton.Location = new System.Drawing.Point(89, 88);
			this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(75, 24);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "&Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// resetBotton
			// 
			this.resetBotton.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.resetBotton.Location = new System.Drawing.Point(169, 88);
			this.resetBotton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.resetBotton.Name = "resetBotton";
			this.resetBotton.Size = new System.Drawing.Size(75, 24);
			this.resetBotton.TabIndex = 7;
			this.resetBotton.Text = "Re&set";
			this.resetBotton.UseVisualStyleBackColor = true;
			this.resetBotton.Click += new System.EventHandler(this.ResetBotton_Click);
			// 
			// loginBotton
			// 
			this.loginBotton.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.loginBotton.Location = new System.Drawing.Point(250, 88);
			this.loginBotton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loginBotton.Name = "loginBotton";
			this.loginBotton.Size = new System.Drawing.Size(75, 24);
			this.loginBotton.TabIndex = 8;
			this.loginBotton.Text = "&Login";
			this.loginBotton.UseVisualStyleBackColor = true;
			this.loginBotton.Click += new System.EventHandler(this.LoginBotton_Click);
			// 
			// exitBotton
			// 
			this.exitBotton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitBotton.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.exitBotton.Location = new System.Drawing.Point(330, 88);
			this.exitBotton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.exitBotton.Name = "exitBotton";
			this.exitBotton.Size = new System.Drawing.Size(75, 24);
			this.exitBotton.TabIndex = 9;
			this.exitBotton.Text = "E&xit";
			this.exitBotton.UseVisualStyleBackColor = true;
			this.exitBotton.Click += new System.EventHandler(this.ExitBotton_Click);
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.registerButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.CancelButton = this.exitBotton;
			this.ClientSize = new System.Drawing.Size(424, 128);
			this.ControlBox = false;
			this.Controls.Add(this.exitBotton);
			this.Controls.Add(this.loginBotton);
			this.Controls.Add(this.resetBotton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.fullnameTextBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.fullnameLable);
			this.Controls.Add(this.passwordLable);
			this.Controls.Add(this.usernameLable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "RegisterForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.Label fullnameLable;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button resetBotton;
        private System.Windows.Forms.Button loginBotton;
        private System.Windows.Forms.Button exitBotton;
    }
}