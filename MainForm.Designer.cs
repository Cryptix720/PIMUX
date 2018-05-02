using System;

namespace PIMUX {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.showPasswordButton1 = new System.Windows.Forms.Button();
            this.loginStatusLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.showPasswordButton2 = new System.Windows.Forms.Button();
            this.registerStatusLabel = new System.Windows.Forms.Label();
            this.RegisterPasswordConfirmLabel = new System.Windows.Forms.Label();
            this.RegisterConfirmTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordLabel = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.RegisterTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LockButton = new System.Windows.Forms.Button();
            this.OpenSettingsButton = new System.Windows.Forms.Button();
            this.PasswordListView = new System.Windows.Forms.ListView();
            this.Website = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddPasswordButton = new System.Windows.Forms.Button();
            this.PasswordInfoLabel = new System.Windows.Forms.Label();
            this.PasswordTabTitleLabel = new System.Windows.Forms.Label();
            this.PIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHidePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowNotesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(20, 27);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(80, 31);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Login";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.Location = new System.Drawing.Point(288, 320);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(226, 22);
            this.PassTextBox.TabIndex = 0;
            this.PassTextBox.UseSystemPasswordChar = true;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            this.PassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassTextBox_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(322, 388);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(152, 33);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.AllowDrop = true;
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.HotTrack = true;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(785, 532);
            this.TabControl.TabIndex = 4;
            this.TabControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.BackgroundImage = global::PIMUX.Properties.Resources.PIMUXs;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.showPasswordButton1);
            this.tabPage1.Controls.Add(this.loginStatusLabel);
            this.tabPage1.Controls.Add(this.TitleLabel);
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.PassTextBox);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LoginTab";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // showPasswordButton1
            // 
            this.showPasswordButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPasswordButton1.BackgroundImage")));
            this.showPasswordButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPasswordButton1.Location = new System.Drawing.Point(520, 318);
            this.showPasswordButton1.Name = "showPasswordButton1";
            this.showPasswordButton1.Size = new System.Drawing.Size(25, 23);
            this.showPasswordButton1.TabIndex = 5;
            this.showPasswordButton1.UseVisualStyleBackColor = true;
            this.showPasswordButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordButton1_MouseDown);
            this.showPasswordButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordButton1_MouseUp);
            // 
            // loginStatusLabel
            // 
            this.loginStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginStatusLabel.AutoSize = true;
            this.loginStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStatusLabel.Location = new System.Drawing.Point(22, 458);
            this.loginStatusLabel.Name = "loginStatusLabel";
            this.loginStatusLabel.Size = new System.Drawing.Size(0, 24);
            this.loginStatusLabel.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(-2, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(774, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.TabIndexChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            this.progressBar1.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.showPasswordButton2);
            this.tabPage2.Controls.Add(this.registerStatusLabel);
            this.tabPage2.Controls.Add(this.RegisterPasswordConfirmLabel);
            this.tabPage2.Controls.Add(this.RegisterConfirmTextBox);
            this.tabPage2.Controls.Add(this.RegisterPasswordLabel);
            this.tabPage2.Controls.Add(this.CreateUserButton);
            this.tabPage2.Controls.Add(this.RegisterTextBox);
            this.tabPage2.Controls.Add(this.TitleLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RegisterTab";
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(709, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 507);
            this.panel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(271, 474);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(221, 16);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "How do I make a secure password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // showPasswordButton2
            // 
            this.showPasswordButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPasswordButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPasswordButton2.BackgroundImage")));
            this.showPasswordButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPasswordButton2.Location = new System.Drawing.Point(483, 148);
            this.showPasswordButton2.Name = "showPasswordButton2";
            this.showPasswordButton2.Size = new System.Drawing.Size(25, 23);
            this.showPasswordButton2.TabIndex = 10;
            this.showPasswordButton2.UseVisualStyleBackColor = true;
            this.showPasswordButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordButton1_MouseDown);
            this.showPasswordButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordButton1_MouseUp);
            // 
            // registerStatusLabel
            // 
            this.registerStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.registerStatusLabel.AutoSize = true;
            this.registerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerStatusLabel.Location = new System.Drawing.Point(22, 411);
            this.registerStatusLabel.Name = "registerStatusLabel";
            this.registerStatusLabel.Size = new System.Drawing.Size(0, 24);
            this.registerStatusLabel.TabIndex = 9;
            // 
            // RegisterPasswordConfirmLabel
            // 
            this.RegisterPasswordConfirmLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterPasswordConfirmLabel.AutoSize = true;
            this.RegisterPasswordConfirmLabel.Location = new System.Drawing.Point(253, 191);
            this.RegisterPasswordConfirmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterPasswordConfirmLabel.Name = "RegisterPasswordConfirmLabel";
            this.RegisterPasswordConfirmLabel.Size = new System.Drawing.Size(161, 24);
            this.RegisterPasswordConfirmLabel.TabIndex = 7;
            this.RegisterPasswordConfirmLabel.Text = "Confirm password";
            // 
            // RegisterConfirmTextBox
            // 
            this.RegisterConfirmTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterConfirmTextBox.Location = new System.Drawing.Point(251, 220);
            this.RegisterConfirmTextBox.Name = "RegisterConfirmTextBox";
            this.RegisterConfirmTextBox.Size = new System.Drawing.Size(226, 22);
            this.RegisterConfirmTextBox.TabIndex = 7;
            this.RegisterConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterPasswordLabel
            // 
            this.RegisterPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterPasswordLabel.AutoSize = true;
            this.RegisterPasswordLabel.Location = new System.Drawing.Point(253, 119);
            this.RegisterPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterPasswordLabel.Name = "RegisterPasswordLabel";
            this.RegisterPasswordLabel.Size = new System.Drawing.Size(92, 24);
            this.RegisterPasswordLabel.TabIndex = 4;
            this.RegisterPasswordLabel.Text = "Password";
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateUserButton.Location = new System.Drawing.Point(288, 258);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(152, 33);
            this.CreateUserButton.TabIndex = 8;
            this.CreateUserButton.Text = "Create";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // RegisterTextBox
            // 
            this.RegisterTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTextBox.Location = new System.Drawing.Point(251, 148);
            this.RegisterTextBox.Name = "RegisterTextBox";
            this.RegisterTextBox.Size = new System.Drawing.Size(226, 22);
            this.RegisterTextBox.TabIndex = 5;
            this.RegisterTextBox.UseSystemPasswordChar = true;
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.TitleLabel2.Location = new System.Drawing.Point(202, 41);
            this.TitleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(370, 31);
            this.TitleLabel2.TabIndex = 1;
            this.TitleLabel2.Text = "Create your master password";
            this.TitleLabel2.Click += new System.EventHandler(this.TitleLabel2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.Controls.Add(this.LockButton);
            this.tabPage3.Controls.Add(this.OpenSettingsButton);
            this.tabPage3.Controls.Add(this.PasswordListView);
            this.tabPage3.Controls.Add(this.AddPasswordButton);
            this.tabPage3.Controls.Add(this.PasswordInfoLabel);
            this.tabPage3.Controls.Add(this.PasswordTabTitleLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(777, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PasswordTab";
            this.tabPage3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // LockButton
            // 
            this.LockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LockButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LockButton.BackgroundImage")));
            this.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LockButton.Location = new System.Drawing.Point(587, 8);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(40, 40);
            this.LockButton.TabIndex = 8;
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // OpenSettingsButton
            // 
            this.OpenSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenSettingsButton.BackgroundImage")));
            this.OpenSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenSettingsButton.Location = new System.Drawing.Point(633, 8);
            this.OpenSettingsButton.Name = "OpenSettingsButton";
            this.OpenSettingsButton.Size = new System.Drawing.Size(40, 40);
            this.OpenSettingsButton.TabIndex = 7;
            this.OpenSettingsButton.UseVisualStyleBackColor = true;
            this.OpenSettingsButton.Click += new System.EventHandler(this.OpenSettingsButton_Click);
            // 
            // PasswordListView
            // 
            this.PasswordListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Website,
            this.Username,
            this.Email,
            this.Password});
            this.PasswordListView.Location = new System.Drawing.Point(25, 55);
            this.PasswordListView.Name = "PasswordListView";
            this.PasswordListView.Size = new System.Drawing.Size(724, 426);
            this.PasswordListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.PasswordListView.TabIndex = 6;
            this.PasswordListView.UseCompatibleStateImageBehavior = false;
            this.PasswordListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasswordListView_MouseDown);
            this.PasswordListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // Website
            // 
            this.Website.Text = "Website";
            this.Website.Width = 200;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 150;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 200;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 200;
            // 
            // AddPasswordButton
            // 
            this.AddPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPasswordButton.Location = new System.Drawing.Point(687, 8);
            this.AddPasswordButton.Name = "AddPasswordButton";
            this.AddPasswordButton.Size = new System.Drawing.Size(84, 40);
            this.AddPasswordButton.TabIndex = 4;
            this.AddPasswordButton.Text = "Add password";
            this.AddPasswordButton.UseVisualStyleBackColor = true;
            this.AddPasswordButton.Click += new System.EventHandler(this.AddPasswordButton_Click);
            this.AddPasswordButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // PasswordInfoLabel
            // 
            this.PasswordInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInfoLabel.Location = new System.Drawing.Point(241, 13);
            this.PasswordInfoLabel.Name = "PasswordInfoLabel";
            this.PasswordInfoLabel.Size = new System.Drawing.Size(321, 39);
            this.PasswordInfoLabel.TabIndex = 3;
            this.PasswordInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordInfoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // PasswordTabTitleLabel
            // 
            this.PasswordTabTitleLabel.AutoSize = true;
            this.PasswordTabTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTabTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.PasswordTabTitleLabel.Location = new System.Drawing.Point(18, 16);
            this.PasswordTabTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordTabTitleLabel.Name = "PasswordTabTitleLabel";
            this.PasswordTabTitleLabel.Size = new System.Drawing.Size(148, 31);
            this.PasswordTabTitleLabel.TabIndex = 2;
            this.PasswordTabTitleLabel.Text = "Passwords";
            this.PasswordTabTitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // PIN
            // 
            this.PIN.Text = "PIN";
            this.PIN.Width = 200;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 200;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenuItem,
            this.EditMenuItem,
            this.ShowHidePasswordMenuItem,
            this.ShowNotesMenuItem,
            this.DeleteMenuItem});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(171, 114);
            this.ContextMenuStrip.Text = "Options";
            this.ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
            this.ContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStrip_ItemClicked);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.usernameToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.pinToolStripMenuItem,
            this.phoneToolStripMenuItem});
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(170, 22);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CopyMenuItem_DropDownItemClicked);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.usernameToolStripMenuItem.Text = "Username";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            // 
            // pinToolStripMenuItem
            // 
            this.pinToolStripMenuItem.Name = "pinToolStripMenuItem";
            this.pinToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.phoneToolStripMenuItem.Text = "Phone";
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(170, 22);
            this.EditMenuItem.Text = "Edit";
            // 
            // ShowHidePasswordMenuItem
            // 
            this.ShowHidePasswordMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.ShowHidePasswordMenuItem.Name = "ShowHidePasswordMenuItem";
            this.ShowHidePasswordMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ShowHidePasswordMenuItem.Text = "Password visibility";
            this.ShowHidePasswordMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ShowToolStripMenuItem_DropDownItemClicked);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            // 
            // ShowNotesMenuItem
            // 
            this.ShowNotesMenuItem.Name = "ShowNotesMenuItem";
            this.ShowNotesMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ShowNotesMenuItem.Text = "Show notes";
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(170, 22);
            this.DeleteMenuItem.Text = "Delete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 532);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "PIMUX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label loginStatusLabel;
        public System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label PasswordTabTitleLabel;
        private System.Windows.Forms.Button showPasswordButton1;
        private System.Windows.Forms.Label PasswordInfoLabel;
        private System.Windows.Forms.Button AddPasswordButton;
        private System.Windows.Forms.ListView PasswordListView;
        private System.Windows.Forms.ColumnHeader Website;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader PIN;
        private System.Windows.Forms.ColumnHeader Phone;
        private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowHidePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.Button OpenSettingsButton;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.ToolStripMenuItem ShowNotesMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button showPasswordButton2;
        private System.Windows.Forms.Label registerStatusLabel;
        private System.Windows.Forms.Label RegisterPasswordConfirmLabel;
        private System.Windows.Forms.TextBox RegisterConfirmTextBox;
        private System.Windows.Forms.Label RegisterPasswordLabel;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.TextBox RegisterTextBox;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
        
    }
}

