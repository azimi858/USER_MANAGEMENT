namespace MyApplication
{
    partial class MainForm
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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.welcomeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.identifireListBox = new System.Windows.Forms.ListBox();
			this.mainMenuStrip.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.adminToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.mainMenuStrip.Size = new System.Drawing.Size(1115, 24);
			this.mainMenuStrip.TabIndex = 1;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.settingToolStripMenuItem.Text = "&Setting";
			// 
			// updateProfileToolStripMenuItem
			// 
			this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
			this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.updateProfileToolStripMenuItem.Text = "&Update Profile";
			this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.UpdateProfileToolStripMenuItem_Click);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.changePasswordToolStripMenuItem.Text = "&Change Password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.logoutToolStripMenuItem.Text = "Lo&gout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem});
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem.Text = "A&dmin";
			// 
			// usersListToolStripMenuItem
			// 
			this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
			this.usersListToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.usersListToolStripMenuItem.Text = "Users &List";
			this.usersListToolStripMenuItem.Click += new System.EventHandler(this.UsersListToolStripMenuItem_Click);
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 534);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.mainStatusStrip.Size = new System.Drawing.Size(1115, 22);
			this.mainStatusStrip.TabIndex = 2;
			this.mainStatusStrip.Text = "statusStrip1";
			// 
			// welcomeToolStripStatusLabel
			// 
			this.welcomeToolStripStatusLabel.Name = "welcomeToolStripStatusLabel";
			this.welcomeToolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
			this.welcomeToolStripStatusLabel.Text = "----";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.button1.ForeColor = System.Drawing.Color.DimGray;
			this.button1.Location = new System.Drawing.Point(1023, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 64);
			this.button1.TabIndex = 4;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 39);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 36);
			this.button2.TabIndex = 4;
			this.button2.Text = "کارسازی با یک حساب";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 82);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(147, 20);
			this.textBox1.TabIndex = 8;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(13, 127);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(259, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// identifireListBox
			// 
			this.identifireListBox.FormattingEnabled = true;
			this.identifireListBox.Location = new System.Drawing.Point(13, 157);
			this.identifireListBox.Name = "identifireListBox";
			this.identifireListBox.Size = new System.Drawing.Size(259, 186);
			this.identifireListBox.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 556);
			this.ControlBox = false;
			this.Controls.Add(this.identifireListBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.mainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersListToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel welcomeToolStripStatusLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListBox identifireListBox;
	}
}