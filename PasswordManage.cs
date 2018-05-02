using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Threading;

namespace PIMUX {

    // Class for managing passwords once logged in.
    class PasswordManage {
        public static string masterPassword;
        const char Separator = ((char)007);
        static ListView passwordView;
        // 2-dimensional array containing all stored passwords.
        static string[][] allStoredPasswords;
        static Label passInfoLabel;
        static Boolean hidePassword;
        
        public PasswordManage(string masterPass, Label infoLabel, ListView passwordListView) {
            // Set the master password and tree view.
            masterPassword = masterPass;
            passwordView = passwordListView;
            passInfoLabel = infoLabel;

            RefreshPasswords();
            // Start watchdog.
            Watchdog wd = new Watchdog();
        }

        // Refresh passwords displayed.
        public static void RefreshPasswords() {
            passInfoLabel.Invoke((MethodInvoker)(() => passInfoLabel.Text = "Loading passwords"));
            // Get settings variables.
            hidePassword = SettingsForm.GetHidePassword();

            passwordView.Invoke((MethodInvoker)(() => passwordView.View = View.Details));
            // Clear current list view and recreate.
            passwordView.Invoke((MethodInvoker)(() => passwordView.Items.Clear()));
            string[] decryptedStore = Crypto.DecryptStoreFile(masterPassword).ToArray();
            // Show no passwords text if required.
            if (decryptedStore.Length == 0) {
                passInfoLabel.Invoke((MethodInvoker)(() => passInfoLabel.Text = "You don't have any stored passwords"));
                return;
            }


            // Make a list containing password entries for easy lookup.
            List<string[]> allPasswords = new List<string[]>();
            foreach (string s in decryptedStore) {
                // Get contents.
                string[] contents = s.Split(Separator);
                // Don't use 'contents' because otherwise 'allPasswords' will be changed to *******.
                allPasswords.Add(s.Split(Separator));
                if (hidePassword) {
                    // Hide password.
                    contents[3] = new String('*', contents[3].Length);
                }
                var entry = new ListViewItem(contents);
                passwordView.Invoke((MethodInvoker)(() => passwordView.Items.Add(entry)));
            }
            allStoredPasswords = allPasswords.ToArray();
            passInfoLabel.Invoke((MethodInvoker)(() => passInfoLabel.Text = ""));
        }

        // Show password.
        public static void ShowPassword(int row) {
            string password = allStoredPasswords[row][3];
            passwordView.Items[row].SubItems[3].Text = password;
        }

        // Show desired item from main store.
        public static string ShowStoredItem(int row, string item) {
            // Get index of item to show.
            string[] items = new string[] { "Website", "Username", "Email", "Password", "Notes", "PIN", "Phone" };
            return allStoredPasswords[row][Array.IndexOf(items, item)];
        }
        
        // Store the password entry.
        public static void StorePassword(string username, string email, string password, string website, string notes) {
            // Create password entry, using Separator to separate username email and password.
            // Format: <website><username><email><password><notes>.
            // Get current main store.
            List<string> mainStore = Crypto.DecryptStoreFile(masterPassword);
            string newEntry = website + Separator + username + Separator + email + Separator + password + Separator + notes;
            mainStore.Add(newEntry);
            Crypto.EncryptStoreFile(masterPassword, mainStore.ToArray());
        }

        public static void RemovePasswordEntry(int passwordStoreRow) {
            // Get the current password store.
            List<string> mainStore = Crypto.DecryptStoreFile(masterPassword);
            // Remove desired password entry.
            mainStore.RemoveAt(passwordStoreRow);
            // Re-store and encrypt new main store.
            Crypto.EncryptStoreFile(masterPassword, mainStore.ToArray());
            RefreshPasswords();
        }

        public static void EditPasswordStore(int passwordStoreRow, string editedPasswordEntry) {
            // Get the current password store.
            List<string> mainStore = Crypto.DecryptStoreFile(masterPassword);
            // Edit desired password entry.
            mainStore[passwordStoreRow] = editedPasswordEntry;
            // Re-store and encrypt new main store.
            Crypto.EncryptStoreFile(masterPassword, mainStore.ToArray());
            RefreshPasswords();
        }
    }
}
