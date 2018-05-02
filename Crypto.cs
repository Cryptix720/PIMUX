using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using Sodium;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Permissions;


namespace PIMUX {

    // Class to handle all cryptography.
    class Crypto {
        // Get AppData folder path.
        static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string PIMUX_PATH = appdata + "\\PIMUX";
        static string PIMUX_STORE = appdata + "\\PIMUX\\main_store";
        static string PIMUX_AUTH = appdata + "\\PIMUX\\auth";
        static string PIMUX_SETTINGS = appdata + "\\PIMUX\\settings";
        static string PIMUX_STORE_NONCE = appdata + "\\PIMUX\\main_store_nonce";
        static string PIMUX_KEY = appdata + "\\PIMUX\\enc_key";
        static string PIMUX_KEY_NONCE = appdata + "\\PIMUX\\enc_key_nonce";
        static TabControl tControl;
        static Button accountLoginButton;

        // Verify that the user has entered the correct master password.
        public static void Authenticate(TextBox passTextBox, Button loginButton, Label statusLabel, Label infoLabel, TabControl tabControl, ListView passwordListView) {
            statusLabel.Text = "Authenticating your master password";



           

            // Prevent multiple login attempts at once.
            loginButton.Enabled = false;
            tControl = tabControl;
            accountLoginButton = loginButton;
            string masterPassword = passTextBox.Text;
            string masterPasswordHash = File.ReadAllText(PIMUX_AUTH);
          

            // Start a background thread to verify password.
            // Background thread is used due to intensivity of Argon2i.
            new Thread(() => {
            Thread.CurrentThread.IsBackground = true;
            if (PasswordHash.ArgonHashStringVerify(masterPasswordHash, masterPassword)) {
                // Correct master password.
                statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = ""));
                tabControl.Invoke((MethodInvoker)(() => tabControl.SelectTab(2)));
                passTextBox.Invoke((MethodInvoker)(() => passTextBox.Text = ""));
                PasswordManage pm = new PasswordManage(masterPassword, infoLabel, passwordListView);
            } else {
                // Incorrect master password.
                statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = "Invalid master password"));
                MessageBox.Show("Invalid master password");
            }
            loginButton.Invoke((MethodInvoker)(() => loginButton.Enabled = true));
            }).Start();
        }

        // Function to get the encryption key for the main store.
        private static byte[] GetKey(string masterPassword) {
            // Get encrypted encryption key and nonce.

            //byte[] encryptedKey = Convert.FromBase64String(File.ReadAllText(PIMUX_KEY));
            byte[] encryptedKey = Encoding.ASCII.GetBytes(File.ReadAllText(PIMUX_KEY));
            
            byte[] keyNonce = Encoding.ASCII.GetBytes(File.ReadAllText(PIMUX_KEY_NONCE));

            // Decrypt key with parameters stored in PIMUX_PATH.
            byte[] key = SecretAeadAes.Decrypt(encryptedKey, keyNonce, GenericHash.Hash(masterPassword, (byte[])null, 32));
       
           
            
            return key;
        }

      

        // Function to get the contents of the main store file.
        private static string[] GetStoreFileContents() {
            // Read each line from file. String array contains base64 encoded strings.
            string[] storeFileContents = File.ReadAllLines(PIMUX_STORE);
            return storeFileContents;
        }

        // Function to get the nonce for the main store.
        private static byte[] GetNonce() {
            //byte[] nonce = Convert.FromBase64String(File.ReadAllText(PIMUX_STORE_NONCE));
            byte[] nonce = Encoding.ASCII.GetBytes(File.ReadAllText(PIMUX_STORE_NONCE));

            return nonce;
        }

      

        // Function to initialise the stored 12 byte nonce to all zeros.
        public static void InitialiseNonce() {
            byte[] nonce = new byte[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            File.WriteAllText(PIMUX_STORE_NONCE, Convert.ToBase64String(nonce));
        }

        // Function to encrypt the main store.
        public static void EncryptStoreFile(string masterPassword, string[] dataToEncrypt) {
           
            // Get required variables.
            byte[] nonce = GetNonce();
            byte[] key = GetKey(masterPassword);

            // Clear main store.
            File.WriteAllText(PIMUX_STORE, "");
            
            // Encrypt each password entry.
            for (int i = 0; i < dataToEncrypt.Length; i++) {
               
                // Increment nonce so every password entry uses a different nonce.
                ByteOperation.Increment(ref nonce);
                byte[] byteDataToEnc = Encoding.ASCII.GetBytes(dataToEncrypt[i]);
                var encrypted = SecretAeadAes.Encrypt(byteDataToEnc, nonce, key);
                File.AppendAllText(PIMUX_STORE, Convert.ToBase64String(encrypted) + Environment.NewLine);
            }
            
            // Write nonce to file.
            File.WriteAllText(PIMUX_STORE_NONCE, Convert.ToBase64String(nonce));
        }

        // Function to decrypt the main store.
        public static List<string> DecryptStoreFile(string masterPassword) {
            // Get required variables.
            string[] storeFileContents = GetStoreFileContents();
            byte[] nonce = GetNonce();
            byte[] key = GetKey(masterPassword);
            List<string> decryptedList = new List<string>();
            // Decrypt each password entry. Work backwards with last nonce used, as nonce decrements.
            for (int i = storeFileContents.Length - 1; i > -1; i--) {
                byte[] dataToDecrypt = Convert.FromBase64String(storeFileContents[i]);
                var decrypted = SecretAeadAes.Decrypt(dataToDecrypt, nonce, key);
                decryptedList.Add(Encoding.ASCII.GetString(decrypted));
                // Decrement nonce to get each nonce used to encrypt password entry.
                ByteOperation.Decrement(ref nonce);
            }
            // Return list containing all decrypted password entries.
            return decryptedList;
        }

        // Function to run Argon2i.
        public static string ArgonHash(string masterPassword) {
            return PasswordHash.ArgonHashString(masterPassword, PasswordHash.StrengthArgon.Moderate);
        }

        // Function to generate encryption key.
        public static void GenerateEncryptionKey(string masterPassword) {
            // Generate random 32 byte encryption key, 12 byte random nonce and 32 byte hash to use as key from master password.
            byte[] encryptionKey = SodiumCore.GetRandomBytes(32);
            byte[] nonce = SecretAeadAes.GenerateNonce();
            byte[] key = GenericHash.Hash(masterPassword, (byte[]) null, 32);
            // Encrypt encryption key with master password.
            byte[] encryptedKey = SecretAeadAes.Encrypt(encryptionKey, nonce, key);
            // Store bytes in base64 encoding.
            File.WriteAllText(PIMUX_KEY, Convert.ToBase64String(encryptedKey));
            File.WriteAllText(PIMUX_KEY_NONCE, Convert.ToBase64String(nonce));
        }

        // Function to change the master password.
        public static void ChangeMasterPassword(string oldMasterPassword, string newMasterPassword) {
            // Get current encryption key.
            byte[] key = GetKey(oldMasterPassword);
            
            // Re-encrypt key with new master password and store.
            byte[] nonce = SecretAeadAes.GenerateNonce();
            byte[] keyToEncryptKey = GenericHash.Hash(newMasterPassword, (byte[])null, 32);
            byte[] encryptedKey = SecretAeadAes.Encrypt(key, nonce, keyToEncryptKey);
           
            // Store bytes in base64 encoding.
            File.WriteAllText(PIMUX_KEY, Convert.ToBase64String(encryptedKey));
            File.WriteAllText(PIMUX_KEY_NONCE, Convert.ToBase64String(nonce));
            
            // Change authentication hash.
            string newArgonHash = ArgonHash(newMasterPassword);
            File.WriteAllText(PIMUX_AUTH, newArgonHash);
            
            //Hashes the key in to PIMUX_KEY
            File.WriteAllText(PIMUX_KEY, newArgonHash);
        }

        // Lock the application.
        public static void Lock() {
            // Go to login tab.
            tControl.Invoke((MethodInvoker)(() => tControl.SelectTab(0)));
            // Close open forms.
            if (Application.OpenForms["EditPasswordEntryForm"] != null) {
                Application.OpenForms["EditPasswordEntryForm"].Invoke((MethodInvoker)(() => Application.OpenForms["EditPasswordEntryForm"].Close()));
            }
            if (Application.OpenForms["AddPasswordForm"] != null) {
                Application.OpenForms["AddPasswordForm"].Invoke((MethodInvoker)(() => Application.OpenForms["AddPasswordForm"].Close()));
            }
            // Enable login button.
            accountLoginButton.Invoke((MethodInvoker)(() => accountLoginButton.Enabled = true));
        }
    }
}
