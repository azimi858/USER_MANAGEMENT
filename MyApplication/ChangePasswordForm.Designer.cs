namespace MyApplication
{
	partial class ChangePasswordForm
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
			this.oldPasswordLabel = new System.Windows.Forms.Label();
			this.confirmNewPasswordLabel = new System.Windows.Forms.Label();
			this.newPasswordLabel = new System.Windows.Forms.Label();
			this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
			this.newPasswordTextBox = new System.Windows.Forms.TextBox();
			this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
			this.changePasswordButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// oldPasswordLabel
			// 
			this.oldPasswordLabel.AutoSize = true;
			this.oldPasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.oldPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.oldPasswordLabel.Location = new System.Drawing.Point(14, 17);
			this.oldPasswordLabel.Name = "oldPasswordLabel";
			this.oldPasswordLabel.Size = new System.Drawing.Size(84, 13);
			this.oldPasswordLabel.TabIndex = 0;
			this.oldPasswordLabel.Text = "&Old Password";
			// 
			// confirmNewPasswordLabel
			// 
			this.confirmNewPasswordLabel.AutoSize = true;
			this.confirmNewPasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmNewPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.confirmNewPasswordLabel.Location = new System.Drawing.Point(12, 65);
			this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
			this.confirmNewPasswordLabel.Size = new System.Drawing.Size(139, 13);
			this.confirmNewPasswordLabel.TabIndex = 4;
			this.confirmNewPasswordLabel.Text = "&Confirm New Password";
			// 
			// newPasswordLabel
			// 
			this.newPasswordLabel.AutoSize = true;
			this.newPasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.newPasswordLabel.Location = new System.Drawing.Point(12, 41);
			this.newPasswordLabel.Name = "newPasswordLabel";
			this.newPasswordLabel.Size = new System.Drawing.Size(89, 13);
			this.newPasswordLabel.TabIndex = 2;
			this.newPasswordLabel.Text = "&New Password";
			// 
			// confirmNewPasswordTextBox
			// 
			this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(157, 63);
			this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
			this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(249, 21);
			this.confirmNewPasswordTextBox.TabIndex = 5;
			this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// newPasswordTextBox
			// 
			this.newPasswordTextBox.Location = new System.Drawing.Point(157, 38);
			this.newPasswordTextBox.Name = "newPasswordTextBox";
			this.newPasswordTextBox.Size = new System.Drawing.Size(249, 21);
			this.newPasswordTextBox.TabIndex = 3;
			this.newPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// oldPasswordTextBox
			// 
			this.oldPasswordTextBox.Location = new System.Drawing.Point(157, 15);
			this.oldPasswordTextBox.Name = "oldPasswordTextBox";
			this.oldPasswordTextBox.Size = new System.Drawing.Size(249, 21);
			this.oldPasswordTextBox.TabIndex = 1;
			this.oldPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.Location = new System.Drawing.Point(157, 94);
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(122, 23);
			this.changePasswordButton.TabIndex = 6;
			this.changePasswordButton.Text = "Change &Password";
			this.changePasswordButton.UseVisualStyleBackColor = true;
			this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(348, 94);
			this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(58, 23);
			this.closeButton.TabIndex = 7;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// ChangePasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(421, 133);
			this.ControlBox = false;
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.changePasswordButton);
			this.Controls.Add(this.oldPasswordTextBox);
			this.Controls.Add(this.newPasswordTextBox);
			this.Controls.Add(this.confirmNewPasswordTextBox);
			this.Controls.Add(this.newPasswordLabel);
			this.Controls.Add(this.confirmNewPasswordLabel);
			this.Controls.Add(this.oldPasswordLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ChangePasswordForm";
			this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label oldPasswordLabel;
		private System.Windows.Forms.Label confirmNewPasswordLabel;
		private System.Windows.Forms.Label newPasswordLabel;
		private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
		private System.Windows.Forms.TextBox newPasswordTextBox;
		private System.Windows.Forms.TextBox oldPasswordTextBox;
		private System.Windows.Forms.Button changePasswordButton;
		private System.Windows.Forms.Button closeButton;
	}
}