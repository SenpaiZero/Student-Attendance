using Microsoft.Win32;
using System.Windows.Forms;

namespace Student_Attendance_System.Classes.Helper
{
    internal class startupHelper : startupRunClass
    {
        // Startup registry key and value
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "MyApplicationName";

        public static void SetStartup()
        {
            // Set the application to run at startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        }

        public static void RemoveStartup()
        {
            // Remove the application from startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.DeleteValue(StartupValue, false);
        }
    }
}
