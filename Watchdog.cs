using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace PIMUX {

    // Class to create watchdog.
    class Watchdog {
        public static Stopwatch stopwatch = new Stopwatch();
        public static long timeoutTime = SettingsForm.GetTimeout();

        public Watchdog() {
            // Restart the stopwatch timing from 0.
            stopwatch.Restart();
            Boolean locked = false;
            do {
                if (TimedOut()) {
                    // Check timeout feature is enabled.
                    if (SettingsForm.GetTimeoutEnabled()) {
                        // If stopwatch has reached the timeout, lock the password manager.
                        Crypto.Lock();
                        locked = true;
                    }
                }
                Thread.Sleep(1000);
            } while (!locked);
        }

        private static Boolean TimedOut() {
            // Check stopwatch hasn't reached timeout.
            long milliseconds = stopwatch.ElapsedMilliseconds;
            if (milliseconds > timeoutTime) {
                return true;
            }
            return false;
        }

        public static void Reset() {
            // Restart the stopwatch timing from 0.
            stopwatch.Restart();
        }
    }
}
