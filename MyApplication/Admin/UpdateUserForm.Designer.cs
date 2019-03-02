namespace MyApplication.Admin
{
	partial class UpdateUserForm
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
			this.fullNameLable = new System.Windows.Forms.Label();
			this.descriptionLable = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.saveAndCloseButton = new System.Windows.Forms.Button();
			this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
			this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameLable
			// 
			this.fullNameLable.AutoSize = true;
			this.fullNameLable.ForeColor = System.Drawing.Color.White;
			this.fullNameLable.Location = new System.Drawing.Point(14, 9);
			this.fullNameLable.Name = "fullNameLable";
			this.fullNameLable.Size = new System.Drawing.Size(63, 13);
			this.fullNameLable.TabIndex = 0;
			this.fullNameLable.Text = "&Full Name";
			// 
			// descriptionLable
			// 
			this.descriptionLable.AutoSize = true;
			this.descriptionLable.ForeColor = System.Drawing.Color.White;
			this.descriptionLable.Location = new System.Drawing.Point(14, 37);
			this.descriptionLable.Name = "descriptionLable";
			this.descriptionLable.Size = new System.Drawing.Size(71, 13);
			this.descriptionLable.TabIndex = 0;
			this.descriptionLable.Text = "&Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(112, 245);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "label1";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Location = new System.Drawing.Point(94, 6);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(398, 21);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(94, 34);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.descriptionTextBox.Size = new System.Drawing.Size(399, 178);
			this.descriptionTextBox.TabIndex = 2;
			// 
			// saveAndCloseButton
			// 
			this.saveAndCloseButton.Location = new System.Drawing.Point(95, 264);
			this.saveAndCloseButton.Name = "saveAndCloseButton";
			this.saveAndCloseButton.Size = new System.Drawing.Size(114, 23);
			this.saveAndCloseButton.TabIndex = 3;
			this.saveAndCloseButton.Text = "&Save And Close";
			this.saveAndCloseButton.UseVisualStyleBackColor = true;
			this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
			// 
			// isActiveCheckBox
			// 
			this.isActiveCheckBox.AutoSize = true;
			this.isActiveCheckBox.ForeColor = System.Drawing.Color.White;
			this.isActiveCheckBox.Location = new System.Drawing.Point(95, 218);
			this.isActiveCheckBox.Name = "isActiveCheckBox";
			this.isActiveCheckBox.Size = new System.Drawing.Size(61, 17);
			this.isActiveCheckBox.TabIndex = 4;
			this.isActiveCheckBox.Text = "Active";
			this.isActiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// isAdminCheckBox
			// 
			this.isAdminCheckBox.AutoSize = true;
			this.isAdminCheckBox.ForeColor = System.Drawing.Color.White;
			this.isAdminCheckBox.Location = new System.Drawing.Point(95, 241);
			this.isAdminCheckBox.Name = "isAdminCheckBox";
			this.isAdminCheckBox.Size = new System.Drawing.Size(62, 17);
			this.isAdminCheckBox.TabIndex = 5;
			this.isAdminCheckBox.Text = "Admin";
			this.isAdminCheckBox.UseVisualStyleBackColor = true;
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(417, 264);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 6;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// UpdateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(512, 305);
			this.ControlBox = false;
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.isAdminCheckBox);
			this.Controls.Add(this.isActiveCheckBox);
			this.Controls.Add(this.saveAndCloseButton);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.descriptionLable);
			this.Controls.Add(this.fullNameLable);
			this.Name = "UpdateUserForm";
			this.Text = "Update User";
			this.Load += new System.EventHandler(this.UpdateUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fullNameLable;
		private System.Windows.Forms.Label descriptionLable;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Button saveAndCloseButton;
		private System.Windows.Forms.CheckBox isActiveCheckBox;
		private System.Windows.Forms.CheckBox isAdminCheckBox;
		private System.Windows.Forms.Button closeButton;
	}
}