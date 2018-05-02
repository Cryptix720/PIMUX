using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PIMUX {

    public partial class MainForm : Form {

        static string PIMUX_PATH = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\PIMUX";
        static string PIMUX_AUTH = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\PIMUX\\auth";
        // Integer to identify the row in list view that has been selected.
        static int rightClickedWebsiteRow;
        const char Separator = ((char)007);

        public MainForm()
        {
            InitializeComponent();
            // Hide tabcontrol buttons.
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.ItemSize = new Size(0, 1);
            TabControl.SizeMode = TabSizeMode.Fixed;

            // Set minimum form size.
            MinimumSize = new Size(600, 450);


        }
    

        private void MainForm_Load(object sender, EventArgs e) {
            // Button tool tip.
            ToolTip tt = new ToolTip();
            tt.SetToolTip(showPasswordButton1, "Hold to show password");
            tt.SetToolTip(showPasswordButton2, "Hold to show password");
            tt.SetToolTip(OpenSettingsButton, "Settings");
            tt.SetToolTip(LockButton, "Lock");

            PasswordListView.Sorting = SortOrder.None;
            PasswordListView.ListViewItemSorter = null;

            // Check for existance of PIMUX directory.
            if (!Directory.Exists(PIMUX_PATH)) {
                // Go to register tab.
                TabControl.SelectTab(1);
            } else {
                ActiveControl = PassTextBox;
            }
        }

        // Create the user.
        private void CreateUserButton_Click(object sender, EventArgs e) {
            string masterPassword = RegisterTextBox.Text;
            string masterPasswordConfirm = RegisterConfirmTextBox.Text;
            if (masterPassword.Length < 10) {
                MessageBox.Show("To maintain the security of your passwords, your master password must be at least 10 characters in length", "Invalid password");
            } else if (masterPassword != masterPasswordConfirm) {
                MessageBox.Show("Your passwords don't match", "Invalid password");
            } else if (masterPassword != masterPasswordConfirm) {
                MessageBox.Show("Your passwords don't match", "Invalid password");

            } else {


                // Successful password, create user.
                Register.MakeUser(masterPassword, TabControl, registerStatusLabel);
            }

        }

        // Authenticate the user.
        private void LoginButton_Click(object sender, EventArgs e) {
            Crypto.Authenticate(PassTextBox, LoginButton, loginStatusLabel, PasswordInfoLabel, TabControl, PasswordListView);
        }

        private void ShowPasswordButton1_MouseDown(object sender, MouseEventArgs e) {
            // Show user password for all password inputs.
            PassTextBox.UseSystemPasswordChar = false;
            RegisterTextBox.UseSystemPasswordChar = false;
            RegisterConfirmTextBox.UseSystemPasswordChar = false;
        }

        private void ShowPasswordButton1_MouseUp(object sender, MouseEventArgs e) {
            // Hide user password.
            PassTextBox.UseSystemPasswordChar = true;
            RegisterTextBox.UseSystemPasswordChar = true;
            RegisterConfirmTextBox.UseSystemPasswordChar = true;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Your PIMAX master password should be the most secure password you have.\n\nTo create a password which " +
                "is very secure and easy to remember, pick >= 4 random words and put spaces between them.\n\nFor example, 'correct " +
                "Super Sized Sweets'.", "Creating a secure password");
        }

        // Function to handle add password button click.
        private void AddPasswordButton_Click(object sender, EventArgs e) {
            // Add a new password.
            AddPasswordForm passwordForm = new AddPasswordForm();
            passwordForm.ShowDialog();
        }

        // Function to login when enter key is pressed.
        private void PassTextBox_KeyDown(object sender, KeyEventArgs e) {
            // Login with enter button.
            if (e.KeyCode == Keys.Enter && LoginButton.Enabled == true) {
                LoginButton_Click(this, new EventArgs());
            }
        }

        // Function to handle right mouse clicks on passwords.
        private void PasswordListView_MouseDown(object sender, MouseEventArgs e) {
            // Check for right click on list view item.
            if (e.Button == MouseButtons.Right) {
                var hitTestInfo = PasswordListView.HitTest(e.X, e.Y);
                if (hitTestInfo.Item != null) {
                    var loc = e.Location;
                    loc.Offset(PasswordListView.Location);

                    // Get selected password website.
                    var row = hitTestInfo.Item.Index;
                    string website = hitTestInfo.Item.SubItems[0].Text;
                    rightClickedWebsiteRow = row;

                    // Show menu strip at item location.
                    ContextMenuStrip.Show(this, loc);
                }
            }
        }

        // Function to handle clicks on context menu strip.
        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // Handle menu item clicked.
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Delete") {
                // Confirm user wants to delete password entry.
                string website = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Website");
                if (MessageBox.Show("Are you sure you want to delete this password entry for " + website + "?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    // Delete the password entry.
                    PasswordManage.RemovePasswordEntry(rightClickedWebsiteRow);
                }
            } else if (item.Text == "Edit") {
                // Get desired password entry data.
                string username = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Username");
                string email = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Email");
                string website = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Website");
                string password = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Password");
                string notes = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Notes");
                string pin = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "PIN"); 
                string phone = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Phone");
                 
                // Update text boxes. And pass in right clicked website row.
                EditPasswordEntryForm editPasswordForm = new EditPasswordEntryForm();
                editPasswordForm.UpdateTextBoxes(username, email, website, password, notes, rightClickedWebsiteRow);
                // Show edit form.
                editPasswordForm.ShowDialog();
            } else if (item.Text == "Show notes") {
                // Show the notes for the password.
                string notes = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, "Notes");
                MessageBox.Show(notes, "Notes");
            }
        }

        // Function to copy items to the system clipboard.
        private void CopyMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // Handle menu item clicked.
            ToolStripItem item = e.ClickedItem;
            // Copy password to clipboard.
            string returnedValue = PasswordManage.ShowStoredItem(rightClickedWebsiteRow, item.Text);
            Clipboard.SetText(returnedValue);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e) {
            // Reset watchdog.
            Watchdog.Reset();
        }

        // Function to show / hide displayed passwords.
        private void ShowToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // Handle menu item clicked.
            ToolStripItem item = e.ClickedItem;
            if (item.Text == "Show") {
                // Allow showing of one password at once.
                PasswordManage.RefreshPasswords();
                PasswordManage.ShowPassword(rightClickedWebsiteRow);
            } else if (item.Text == "Hide") {
                // Hide password.
                PasswordManage.RefreshPasswords();
            }
        }

        // Function to open settings.
        private void OpenSettingsButton_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        // Function to lock the application.
        private void LockButton_Click(object sender, EventArgs e) {
            Crypto.Lock();
        }

        private void TitleLabel2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

  
    }
}
