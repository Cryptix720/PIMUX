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

    public partial class EditPasswordEntryForm : Form {

        // Separator character.
        const char Separator = ((char)007);
        static int rightClickedWebsiteRow;

        public EditPasswordEntryForm() {
            InitializeComponent();

            // Set minimum form size.
            MinimumSize = new Size(340, 350);

            // Button tool tip.
            ToolTip tt = new ToolTip();
            tt.SetToolTip(showPasswordButton, "Hold to show password");
        }

        public void UpdateTextBoxes(string username, string email, string website, string password, string notes,  int clickedRow) {
            // Update text boxes with password entry data.
            EditPassUsernameTextbox.Text = username;
            EditPassEmailTextbox.Text = email;
            EditPassWebsiteTextbox.Text = website;
            EditPassPasswordTextbox.Text = password;
            EditPassNotesTextbox.Text = notes;

            //EditPassPinTextbox.Text = pin;
            //EditPassPhoneTextbox.Text = phone;


            // Set right clicked website row.
            rightClickedWebsiteRow = clickedRow;
        }

        // Show password.
        private void ShowPasswordButton_MouseDown(object sender, MouseEventArgs e) {
            EditPassPasswordTextbox.UseSystemPasswordChar = false;
        }

        // Hide password.
        private void ShowPasswordButton_MouseUp(object sender, MouseEventArgs e) {
            EditPassPasswordTextbox.UseSystemPasswordChar = true;
        }

        private void SavePasswordButton_Click(object sender, EventArgs e) {
         
            // Create password entry.
            string passwordEntry = EditPassWebsiteTextbox.Text + Separator + EditPassUsernameTextbox.Text + Separator + EditPassEmailTextbox.Text + Separator + EditPassPasswordTextbox.Text + Separator + EditPassNotesTextbox.Text; //+ Separator + EditPassPhoneTextbox.Text + Separator + EditPassPinTexbox.Text;
            // Update the password entry.
            PasswordManage.EditPasswordStore(rightClickedWebsiteRow, passwordEntry);
            Close();
        }

        private void EditPasswordEntryForm_MouseMove(object sender, MouseEventArgs e) {
            // Reset watchdog.
            Watchdog.Reset();
        }

        private void EditPasswordEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
