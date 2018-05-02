using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PIMUX {

    class Register {
        // Get AppData folder path.
        static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string PIMUX_PATH = appdata+ "\\PIMUX";
        static string PIMUX_STORE = appdata + "\\PIMUX\\main_store";
        static string PIMUX_AUTH = appdata + "\\PIMUX\\auth";
        static string PIMUX_SETTINGS = appdata + "\\PIMUX\\settings";
        static string PIMUX_STORE_NONCE = appdata + "\\PIMUX\\main_store_nonce";
        static string PIMUX_KEY = appdata + "\\PIMUX\\enc_key";
        static string PIMUX_KEY_NONCE = appdata + "\\PIMUX\\enc_key_nonce";
    
        public static void MakeUser(string masterPass, TabControl tabControl, Label statusLabel) {
            statusLabel.Text = "Processing master password";
            CreateFiles(masterPass);
            WriteSettings();
            CreateAuthHash(masterPass, tabControl, statusLabel);
        }

        // Create PIMUX directory and store file.
        private static void CreateFiles(string masterPassword) {
            Directory.CreateDirectory(PIMUX_PATH);
            File.Create(PIMUX_STORE);
        }

        // Create Argon2i hash of master password.
        private static void CreateAuthHash(string masterPassword, TabControl tabControl, Label statusLabel) {
            // Background thread is used due to intensivity of Argon2i.
            new Thread(() => {
                Thread.CurrentThread.IsBackground = true;
                var masterPasswordHash = Crypto.ArgonHash(masterPassword);
                File.WriteAllText(PIMUX_AUTH, masterPasswordHash);
                File.WriteAllText(PIMUX_STORE_NONCE, masterPasswordHash); //Insert the PIMUX_STORE_NONCE
                File.WriteAllText(PIMUX_KEY_NONCE, masterPasswordHash);
                File.WriteAllText(PIMUX_KEY, masterPasswordHash);

                statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = ""));
                tabControl.Invoke((MethodInvoker)(() => tabControl.SelectTab(0)));
                // Generate the encryption key.
                Crypto.GenerateEncryptionKey(masterPassword);
                Crypto.InitialiseNonce();
            }).Start();
        }

        // Write default configuration to settings file.
        private static void WriteSettings() {
            string defaultConfig = "HidePassword=true" + Environment.NewLine +
                "Timeout=120000" + Environment.NewLine + 
                "TimeoutEnabled=true" + Environment.NewLine + 
                "DisableLengthOfKey=False";
            File.WriteAllText(PIMUX_SETTINGS, defaultConfig);
        }
    }
}
