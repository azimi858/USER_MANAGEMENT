namespace MyApplication.Admin
{
	partial class deleteUsersButton
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
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.usersListBox = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(15, 14);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(75, 17);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullNameTextBox.Location = new System.Drawing.Point(106, 11);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(371, 23);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(106, 41);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 25);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// usersListBox
			// 
			this.usersListBox.FormattingEnabled = true;
			this.usersListBox.ItemHeight = 17;
			this.usersListBox.Location = new System.Drawing.Point(18, 89);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.Size = new System.Drawing.Size(459, 361);
			this.usersListBox.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(18, 457);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 26);
			this.button2.TabIndex = 4;
			this.button2.Text = "&Delet User";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// deleteUsersButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(494, 490);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.usersListBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.Name = "deleteUsersButton";
			this.Text = "Users List";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ListBox usersListBox;
		private System.Windows.Forms.Button button2;
	}
}