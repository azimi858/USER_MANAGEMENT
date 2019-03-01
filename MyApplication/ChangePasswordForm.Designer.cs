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
			this.oldPasswordLabel.Location = new System.Drawing.Point(21, 17);
			this.oldPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.oldPasswordLabel.Name = "oldPasswordLabel";
			this.oldPasswordLabel.Size = new System.Drawing.Size(103, 17);
			this.oldPasswordLabel.TabIndex = 0;
			this.oldPasswordLabel.Text = "&Old Password";
			// 
			// confirmNewPasswordLabel
			// 
			this.confirmNewPasswordLabel.AutoSize = true;
			this.confirmNewPasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmNewPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.confirmNewPasswordLabel.Location = new System.Drawing.Point(18, 80);
			this.confirmNewPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
			this.confirmNewPasswordLabel.Size = new System.Drawing.Size(169, 17);
			this.confirmNewPasswordLabel.TabIndex = 4;
			this.confirmNewPasswordLabel.Text = "&Confirm New Password";
			// 
			// newPasswordLabel
			// 
			this.newPasswordLabel.AutoSize = true;
			this.newPasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newPasswordLabel.ForeColor = System.Drawing.Color.White;
			this.newPasswordLabel.Location = new System.Drawing.Point(18, 48);
			this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.newPasswordLabel.Name = "newPasswordLabel";
			this.newPasswordLabel.Size = new System.Drawing.Size(109, 17);
			this.newPasswordLabel.TabIndex = 2;
			this.newPasswordLabel.Text = "&New Password";
			// 
			// confirmNewPasswordTextBox
			// 
			this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(195, 77);
			this.confirmNewPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
			this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(328, 24);
			this.confirmNewPasswordTextBox.TabIndex = 5;
			this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// newPasswordTextBox
			// 
			this.newPasswordTextBox.Location = new System.Drawing.Point(195, 44);
			this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.newPasswordTextBox.Name = "newPasswordTextBox";
			this.newPasswordTextBox.Size = new System.Drawing.Size(328, 24);
			this.newPasswordTextBox.TabIndex = 3;
			this.newPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// oldPasswordTextBox
			// 
			this.oldPasswordTextBox.Location = new System.Drawing.Point(195, 14);
			this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.oldPasswordTextBox.Name = "oldPasswordTextBox";
			this.oldPasswordTextBox.Size = new System.Drawing.Size(328, 24);
			this.oldPasswordTextBox.TabIndex = 1;
			this.oldPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.Location = new System.Drawing.Point(366, 118);
			this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4);
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(157, 30);
			this.changePasswordButton.TabIndex = 6;
			this.changePasswordButton.Text = "Change &Password";
			this.changePasswordButton.UseVisualStyleBackColor = true;
			this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(284, 118);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 30);
			this.closeButton.TabIndex = 7;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// ChangePasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(536, 153);
			this.ControlBox = false;
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.changePasswordButton);
			this.Controls.Add(this.oldPasswordTextBox);
			this.Controls.Add(this.newPasswordTextBox);
			this.Controls.Add(this.confirmNewPasswordTextBox);
			this.Controls.Add(this.newPasswordLabel);
			this.Controls.Add(this.confirmNewPasswordLabel);
			this.Controls.Add(this.oldPasswordLabel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(554, 200);
			this.MinimumSize = new System.Drawing.Size(554, 200);
			this.Name = "ChangePasswordForm";
			this.Text = "Change Password";
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