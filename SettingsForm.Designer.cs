namespace PIMUX {
    partial class SettingsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsTimeoutTextbox = new System.Windows.Forms.TextBox();
            this.SettingsTimeoutLabel = new System.Windows.Forms.Label();
            this.SettingsTitleLabel = new System.Windows.Forms.Label();
            this.TimeoutGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.MasterPasswordGroupbox = new System.Windows.Forms.GroupBox();
            this.SettingShowPasswordButton = new System.Windows.Forms.Button();
            this.CurrentPasswordLabel = new System.Windows.Forms.Label();
            this.CurrentPasswordTextbox = new System.Windows.Forms.TextBox();
            this.SettingsChangePasswordButton = new System.Windows.Forms.Button();
            this.SettingsPasswordLabel = new System.Windows.Forms.Label();
            this.SettingsPasswordTextbox = new System.Windows.Forms.TextBox();
            this.SettingsConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.SettingsConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HidePasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeoutGroupBox.SuspendLayout();
            this.MasterPasswordGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTimeoutTextbox
            // 
            this.SettingsTimeoutTextbox.Location = new System.Drawing.Point(13, 81);
            this.SettingsTimeoutTextbox.Name = "SettingsTimeoutTextbox";
            this.SettingsTimeoutTextbox.Size = new System.Drawing.Size(217, 22);
            this.SettingsTimeoutTextbox.TabIndex = 2;
            this.SettingsTimeoutTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsTimeoutLabel
            // 
            this.SettingsTimeoutLabel.AutoSize = true;
            this.SettingsTimeoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTimeoutLabel.Location = new System.Drawing.Point(10, 62);
            this.SettingsTimeoutLabel.Name = "SettingsTimeoutLabel";
            this.SettingsTimeoutLabel.Size = new System.Drawing.Size(114, 16);
            this.SettingsTimeoutLabel.TabIndex = 20;
            this.SettingsTimeoutLabel.Text = "Timeout time (ms)";
            this.SettingsTimeoutLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsTitleLabel
            // 
            this.SettingsTitleLabel.AutoSize = true;
            this.SettingsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTitleLabel.Location = new System.Drawing.Point(12, 13);
            this.SettingsTitleLabel.Name = "SettingsTitleLabel";
            this.SettingsTitleLabel.Size = new System.Drawing.Size(76, 24);
            this.SettingsTitleLabel.TabIndex = 22;
            this.SettingsTitleLabel.Text = "Settings";
            this.SettingsTitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // TimeoutGroupBox
            // 
            this.TimeoutGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeoutGroupBox.Controls.Add(this.TimeoutCheckBox);
            this.TimeoutGroupBox.Controls.Add(this.SettingsTimeoutLabel);
            this.TimeoutGroupBox.Controls.Add(this.SettingsTimeoutTextbox);
            this.TimeoutGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeoutGroupBox.Location = new System.Drawing.Point(12, 46);
            this.TimeoutGroupBox.Name = "TimeoutGroupBox";
            this.TimeoutGroupBox.Size = new System.Drawing.Size(293, 122);
            this.TimeoutGroupBox.TabIndex = 23;
            this.TimeoutGroupBox.TabStop = false;
            this.TimeoutGroupBox.Text = "Timeout";
            this.TimeoutGroupBox.Enter += new System.EventHandler(this.TimeoutGroupBox_Enter);
            // 
            // TimeoutCheckBox
            // 
            this.TimeoutCheckBox.AutoSize = true;
            this.TimeoutCheckBox.Location = new System.Drawing.Point(13, 32);
            this.TimeoutCheckBox.Name = "TimeoutCheckBox";
            this.TimeoutCheckBox.Size = new System.Drawing.Size(76, 20);
            this.TimeoutCheckBox.TabIndex = 1;
            this.TimeoutCheckBox.Text = "Timeout";
            this.TimeoutCheckBox.UseVisualStyleBackColor = true;
            this.TimeoutCheckBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // MasterPasswordGroupbox
            // 
            this.MasterPasswordGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterPasswordGroupbox.Controls.Add(this.SettingShowPasswordButton);
            this.MasterPasswordGroupbox.Controls.Add(this.CurrentPasswordLabel);
            this.MasterPasswordGroupbox.Controls.Add(this.CurrentPasswordTextbox);
            this.MasterPasswordGroupbox.Controls.Add(this.SettingsChangePasswordButton);
            this.MasterPasswordGroupbox.Controls.Add(this.SettingsPasswordLabel);
            this.MasterPasswordGroupbox.Controls.Add(this.SettingsPasswordTextbox);
            this.MasterPasswordGroupbox.Controls.Add(this.SettingsConfirmPasswordLabel);
            this.MasterPasswordGroupbox.Controls.Add(this.SettingsConfirmPasswordTextbox);
            this.MasterPasswordGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterPasswordGroupbox.Location = new System.Drawing.Point(12, 244);
            this.MasterPasswordGroupbox.Name = "MasterPasswordGroupbox";
            this.MasterPasswordGroupbox.Size = new System.Drawing.Size(293, 232);
            this.MasterPasswordGroupbox.TabIndex = 24;
            this.MasterPasswordGroupbox.TabStop = false;
            this.MasterPasswordGroupbox.Text = "Change your master password";
            // 
            // SettingShowPasswordButton
            // 
            this.SettingShowPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingShowPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingShowPasswordButton.BackgroundImage")));
            this.SettingShowPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingShowPasswordButton.Location = new System.Drawing.Point(235, 51);
            this.SettingShowPasswordButton.Name = "SettingShowPasswordButton";
            this.SettingShowPasswordButton.Size = new System.Drawing.Size(25, 23);
            this.SettingShowPasswordButton.TabIndex = 26;
            this.SettingShowPasswordButton.UseVisualStyleBackColor = true;
            this.SettingShowPasswordButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingShowPasswordButton_MouseDown);
            this.SettingShowPasswordButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            this.SettingShowPasswordButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SettingShowPasswordButton_MouseUp);
            // 
            // CurrentPasswordLabel
            // 
            this.CurrentPasswordLabel.AutoSize = true;
            this.CurrentPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPasswordLabel.Location = new System.Drawing.Point(9, 31);
            this.CurrentPasswordLabel.Name = "CurrentPasswordLabel";
            this.CurrentPasswordLabel.Size = new System.Drawing.Size(112, 16);
            this.CurrentPasswordLabel.TabIndex = 25;
            this.CurrentPasswordLabel.Text = "Current password";
            this.CurrentPasswordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // CurrentPasswordTextbox
            // 
            this.CurrentPasswordTextbox.Location = new System.Drawing.Point(12, 51);
            this.CurrentPasswordTextbox.Name = "CurrentPasswordTextbox";
            this.CurrentPasswordTextbox.Size = new System.Drawing.Size(217, 22);
            this.CurrentPasswordTextbox.TabIndex = 4;
            this.CurrentPasswordTextbox.UseSystemPasswordChar = true;
            this.CurrentPasswordTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsChangePasswordButton
            // 
            this.SettingsChangePasswordButton.Location = new System.Drawing.Point(13, 196);
            this.SettingsChangePasswordButton.Name = "SettingsChangePasswordButton";
            this.SettingsChangePasswordButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsChangePasswordButton.TabIndex = 7;
            this.SettingsChangePasswordButton.Text = "Change";
            this.SettingsChangePasswordButton.UseVisualStyleBackColor = true;
            this.SettingsChangePasswordButton.Click += new System.EventHandler(this.SettingsChangePasswordButton_Click);
            this.SettingsChangePasswordButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsPasswordLabel
            // 
            this.SettingsPasswordLabel.AutoSize = true;
            this.SettingsPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsPasswordLabel.Location = new System.Drawing.Point(10, 83);
            this.SettingsPasswordLabel.Name = "SettingsPasswordLabel";
            this.SettingsPasswordLabel.Size = new System.Drawing.Size(97, 16);
            this.SettingsPasswordLabel.TabIndex = 22;
            this.SettingsPasswordLabel.Text = "New password";
            this.SettingsPasswordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsPasswordTextbox
            // 
            this.SettingsPasswordTextbox.Location = new System.Drawing.Point(13, 103);
            this.SettingsPasswordTextbox.Name = "SettingsPasswordTextbox";
            this.SettingsPasswordTextbox.Size = new System.Drawing.Size(217, 22);
            this.SettingsPasswordTextbox.TabIndex = 5;
            this.SettingsPasswordTextbox.UseSystemPasswordChar = true;
            this.SettingsPasswordTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsConfirmPasswordLabel
            // 
            this.SettingsConfirmPasswordLabel.AutoSize = true;
            this.SettingsConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsConfirmPasswordLabel.Location = new System.Drawing.Point(10, 137);
            this.SettingsConfirmPasswordLabel.Name = "SettingsConfirmPasswordLabel";
            this.SettingsConfirmPasswordLabel.Size = new System.Drawing.Size(142, 16);
            this.SettingsConfirmPasswordLabel.TabIndex = 20;
            this.SettingsConfirmPasswordLabel.Text = "Confirm new password";
            this.SettingsConfirmPasswordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsConfirmPasswordTextbox
            // 
            this.SettingsConfirmPasswordTextbox.Location = new System.Drawing.Point(13, 157);
            this.SettingsConfirmPasswordTextbox.Name = "SettingsConfirmPasswordTextbox";
            this.SettingsConfirmPasswordTextbox.Size = new System.Drawing.Size(217, 22);
            this.SettingsConfirmPasswordTextbox.TabIndex = 6;
            this.SettingsConfirmPasswordTextbox.UseSystemPasswordChar = true;
            this.SettingsConfirmPasswordTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.HidePasswordsCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 69);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passwords visibility";
            // 
            // HidePasswordsCheckBox
            // 
            this.HidePasswordsCheckBox.AutoSize = true;
            this.HidePasswordsCheckBox.Location = new System.Drawing.Point(13, 32);
            this.HidePasswordsCheckBox.Name = "HidePasswordsCheckBox";
            this.HidePasswordsCheckBox.Size = new System.Drawing.Size(222, 20);
            this.HidePasswordsCheckBox.TabIndex = 3;
            this.HidePasswordsCheckBox.Text = "Hide passwords when displayed";
            this.HidePasswordsCheckBox.UseVisualStyleBackColor = true;
            this.HidePasswordsCheckBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MasterPasswordGroupbox);
            this.Controls.Add(this.TimeoutGroupBox);
            this.Controls.Add(this.SettingsTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            this.TimeoutGroupBox.ResumeLayout(false);
            this.TimeoutGroupBox.PerformLayout();
            this.MasterPasswordGroupbox.ResumeLayout(false);
            this.MasterPasswordGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SettingsTimeoutTextbox;
        private System.Windows.Forms.Label SettingsTimeoutLabel;
        private System.Windows.Forms.Label SettingsTitleLabel;
        private System.Windows.Forms.GroupBox TimeoutGroupBox;
        private System.Windows.Forms.CheckBox TimeoutCheckBox;
        private System.Windows.Forms.GroupBox MasterPasswordGroupbox;
        private System.Windows.Forms.Button SettingsChangePasswordButton;
        private System.Windows.Forms.Label SettingsPasswordLabel;
        private System.Windows.Forms.TextBox SettingsPasswordTextbox;
        private System.Windows.Forms.Label SettingsConfirmPasswordLabel;
        private System.Windows.Forms.TextBox SettingsConfirmPasswordTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox HidePasswordsCheckBox;
        private System.Windows.Forms.Label CurrentPasswordLabel;
        private System.Windows.Forms.TextBox CurrentPasswordTextbox;
        private System.Windows.Forms.Button SettingShowPasswordButton;
    }
}