using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMUX {

    public partial class AddPasswordForm : Form {

        // Constructor.
        public AddPasswordForm() {
            InitializeComponent();

            // Set minimum form size.
            MinimumSize = new Size(340, 350);

            // Button tool tip.
            ToolTip tt = new ToolTip();
            tt.SetToolTip(showPasswordButton, "Hold to show password");
        }

        // Show password.
        private void ShowPasswordButton_MouseDown(object sender, MouseEventArgs e) {
            NewPassPasswordTextbox.UseSystemPasswordChar = false;
        }

        // Hide password.
        private void ShowPasswordButton_MouseUp(object sender, MouseEventArgs e) {
            NewPassPasswordTextbox.UseSystemPasswordChar = true;
        }

        // Add the new password.
        private void AddPasswordButton_Click(object sender, EventArgs e) {
            // Get password entry info.
            string username = NewPassUsernameTextbox.Text;
            string email = NewPassEmailTextbox.Text;
            string website = NewPassWebsiteTextbox.Text;
            string password = NewPassPasswordTextbox.Text;
            string notes = NewPassNotesTextbox.Text;
            //string pin = NewPassPinTextbox.Text;
            //string phone = NewPassPhoneTextbox.Text;

            if (username == "" || email == "" || password == "" || website == "" ) {
                // One if the fields is missing.
                MessageBox.Show("At least one of the fields is empty.", "Missing field");
            } else {
                // Store the password entry.
                PasswordManage.StorePassword(username, email, password, website, notes);
                // Refresh displayed passwords.
                PasswordManage.RefreshPasswords();
                Close();
            }
        }

        private void AddPasswordForm_MouseMove(object sender, MouseEventArgs e) {
            // Reset watchdog.
            Watchdog.Reset();
        }

        private void AddPasswordForm_Load(object sender, EventArgs e)
        {

        }

    
    }
}