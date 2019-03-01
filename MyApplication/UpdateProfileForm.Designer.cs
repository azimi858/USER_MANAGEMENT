namespace MyApplication
{
	partial class UpdateProfileForm
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
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(19, 17);
			this.fullNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(74, 17);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full name";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descriptionLabel.ForeColor = System.Drawing.Color.White;
			this.descriptionLabel.Location = new System.Drawing.Point(19, 48);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(82, 17);
			this.descriptionLabel.TabIndex = 2;
			this.descriptionLabel.Text = "&Discription";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(481, 207);
			this.saveButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(113, 30);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "&Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Location = new System.Drawing.Point(121, 13);
			this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(468, 24);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(121, 48);
			this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(468, 149);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(375, 207);
			this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(96, 30);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// UpdateProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(604, 241);
			this.ControlBox = false;
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.fullNameLabel);
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximumSize = new System.Drawing.Size(622, 288);
			this.MinimumSize = new System.Drawing.Size(622, 288);
			this.Name = "UpdateProfileForm";
			this.Text = "Update Profile";
			this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Button closeButton;
	}
}