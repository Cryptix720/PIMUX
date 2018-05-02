using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace PIMUX {

    public partial class SettingsForm : Form {
        // Get AppData folder path.
        static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string PIMUX_SETTINGS = appdata + "\\PIMUX\\settings";

        public SettingsForm() {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            // Set form control values to those in settings file.
            SettingsTimeoutTextbox.Text = Convert.ToString(GetTimeout());
            HidePasswordsCheckBox.Checked = GetHidePassword();
            TimeoutCheckBox.Checked = GetTimeoutEnabled();
        }

        // Function to get setting value from settings file.
        public static string GetSettingValue(string setting) {
            // Read settings file.
            string[] settings = File.ReadAllLines(PIMUX_SETTINGS);
            for (int i = 0; i < settings.Length; i++) {
                string[] settingContents = settings[i].Split('=');
                string settingName = settingContents[0];
                if (settingName == setting) {
                    return settingContents[1];
                }
            }
            return null;
        }

        // Function to get timeout from settings file.
        public static long GetTimeout() {
            try {
                long timeout = Convert.ToInt64(GetSettingValue("Timeout"));
                return timeout;
            } catch {
                // Invalid setting value. Return default.
                UpdateSetting("Timeout", "120000");
                MessageBox.Show("Invalid timeout value found in settings. Defaulting to 120000ms", "Error");
                return 120000;
            }
        }

        // Function to get hide password boolean from settings file.
        public static Boolean GetHidePassword() {
            try {
                Boolean hidePassword = Convert.ToBoolean(GetSettingValue("HidePassword"));
                return hidePassword;
            } catch {
                // Invalid setting value. Return default.
                UpdateSetting("HidePassword", "True");
                MessageBox.Show("Invalid hide password value found in settings. Defaulting to true", "Error");
                return true;
            }
        }

        // Function to get timeout enabled boolean from settings file.
        public static Boolean GetTimeoutEnabled() {
            try {
                Boolean timeoutEnabled = Convert.ToBoolean(GetSettingValue("TimeoutEnabled"));
                return timeoutEnabled;
            } catch {
                // Invalid setting value. Return default.
                UpdateSetting("TimeoutEnabled", "True");
                MessageBox.Show("Invalid timeout enabled value found in settings. Defaulting to true", "Error");
                return true;
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            // Form is being closed, apply settings to setting file.
            // Get settings from form control values.
            string hidePasswordValue = Convert.ToString(HidePasswordsCheckBox.Checked);
            string timeoutValue = Convert.ToString(SettingsTimeoutTextbox.Text);
            // Check timeout value is an integer.
            if (!timeoutValue.All(char.IsDigit)) {
                MessageBox.Show("Timeout value must be an integer", "Error");
                return;
            }
            string timeoutEnabledValue = Convert.ToString(TimeoutCheckBox.Checked);
            string settingsConfig = "HidePassword=" + hidePasswordValue + Environment.NewLine +
                "Timeout=" + timeoutValue + Environment.NewLine + 
                "TimeoutEnabled=" + timeoutEnabledValue;
            // Write settings to config file.
            File.WriteAllText(PIMUX_SETTINGS, settingsConfig);
            // Set new timeout time on watchdog.
            Watchdog.timeoutTime = GetTimeout();
            // Refresh passwords.
            PasswordManage.RefreshPasswords();
        }

        private static void UpdateSetting(string setting, string value) {
            // Get the current settings content from file.
            List<string> settings = File.ReadAllLines(PIMUX_SETTINGS).ToList();
            // Update individual setting.
            settings[settings.FindIndex(x => x.StartsWith(setting))] = setting + "=" + value;
            string settingsConfig = settings[0] + Environment.NewLine +
                settings[1] + Environment.NewLine +
                settings[2] + Environment.NewLine;
            // Write to settings file.
            File.WriteAllText(PIMUX_SETTINGS, settingsConfig);
        }

        private void SettingsChangePasswordButton_Click(object sender, EventArgs e) {
            // Change the master password.
            // First check the two passwords match.
            string newMasterPassword = SettingsPasswordTextbox.Text;
            string newMasterPasswordConfirm = SettingsConfirmPasswordTextbox.Text;
            string currentMasterPassword = PasswordManage.masterPassword;
            string confirmCurrentPassword = CurrentPasswordTextbox.Text;
            if (newMasterPassword.Length < 15) {
                MessageBox.Show("To maintain the security of your passwords, your master password must be at least 15 characters in length", "Invalid password");
            } else if (newMasterPassword != newMasterPasswordConfirm) {
                MessageBox.Show("Your passwords don't match", "Invalid password");
            } else if (newMasterPassword == currentMasterPassword) {
                MessageBox.Show("Your new master password has to be different to your current master password", "Invalid password");
            } else if (confirmCurrentPassword != currentMasterPassword) {
                MessageBox.Show("The current master password you entered is incorrect", "Invalid password");
            } else {
                // Successful password, create user.
                Crypto.ChangeMasterPassword(currentMasterPassword, newMasterPassword);
                MessageBox.Show("Your master password has been changed successfully", "Success");
                PasswordManage.masterPassword = newMasterPassword;
                Close();
            }
        }

        private void SettingShowPasswordButton_MouseDown(object sender, MouseEventArgs e) {
            // Show password.
            CurrentPasswordTextbox.UseSystemPasswordChar = false;
            SettingsPasswordTextbox.UseSystemPasswordChar = false;
            SettingsConfirmPasswordTextbox.UseSystemPasswordChar = false;
        }

        private void SettingShowPasswordButton_MouseUp(object sender, MouseEventArgs e) {
            // Hide password.
            CurrentPasswordTextbox.UseSystemPasswordChar = true;
            SettingsPasswordTextbox.UseSystemPasswordChar = true;
            SettingsConfirmPasswordTextbox.UseSystemPasswordChar = true;
        }

        private void SettingsForm_MouseMove(object sender, MouseEventArgs e) {
            // Reset watchdog.
            Watchdog.Reset();
        }

        private void TimeoutGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
