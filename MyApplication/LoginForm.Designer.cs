namespace MyApplication
{
    partial class LoginForm
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
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.ForeColor = System.Drawing.Color.White;
			this.UsernameLabel.Location = new System.Drawing.Point(11, 13);
			this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(65, 13);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "&Username";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.ForeColor = System.Drawing.Color.White;
			this.PasswordLabel.Location = new System.Drawing.Point(11, 37);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "&Password";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.usernameTextBox.Location = new System.Drawing.Point(80, 11);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(281, 21);
			this.usernameTextBox.TabIndex = 1;
			this.usernameTextBox.Text = "dariush";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.passwordTextBox.Location = new System.Drawing.Point(80, 34);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(281, 21);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.Text = "1234512345";
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(80, 65);
			this.loginButton.Margin = new System.Windows.Forms.Padding(2);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(65, 24);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(152, 65);
			this.resetButton.Margin = new System.Windows.Forms.Padding(2);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(65, 24);
			this.resetButton.TabIndex = 5;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(224, 65);
			this.registerButton.Margin = new System.Windows.Forms.Padding(2);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(65, 24);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "Re&gister";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.exitButton.Location = new System.Drawing.Point(296, 65);
			this.exitButton.Margin = new System.Windows.Forms.Padding(2);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(65, 24);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.CancelButton = this.exitButton;
			this.ClientSize = new System.Drawing.Size(375, 101);
			this.ControlBox = false;
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button exitButton;
    }
}