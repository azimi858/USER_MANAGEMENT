namespace MyApplication.Admin
{
	partial class UsersListForm
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
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 11);
			this.fullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(63, 13);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fullNameTextBox.Location = new System.Drawing.Point(82, 8);
			this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(289, 20);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Location = new System.Drawing.Point(82, 31);
			this.searchButton.Margin = new System.Windows.Forms.Padding(2);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(58, 23);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// usersListBox
			// 
			this.usersListBox.FormattingEnabled = true;
			this.usersListBox.Location = new System.Drawing.Point(14, 68);
			this.usersListBox.Margin = new System.Windows.Forms.Padding(2);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.Size = new System.Drawing.Size(358, 277);
			this.usersListBox.TabIndex = 3;
			this.usersListBox.DoubleClick += new System.EventHandler(this.UsersListBox_DoubleClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(15, 353);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 22);
			this.button2.TabIndex = 4;
			this.button2.Text = "&Delet User";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// closeButton
			// 
			this.closeButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.Location = new System.Drawing.Point(296, 352);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// UsersListForm
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(384, 387);
			this.ControlBox = false;
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.usersListBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(400, 426);
			this.MinimumSize = new System.Drawing.Size(400, 426);
			this.Name = "UsersListForm";
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
		private System.Windows.Forms.Button closeButton;
	}
}