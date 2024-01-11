using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System.Classes.Helper
{
    internal class securityHelper
    {
        public Startup.loginForm loginForm
        {
            get => default;
            set
            {
            }
        }

        public Forms.changePasswordForm changePasswordForm
        {
            get => default;
            set
            {
            }
        }

        public static string HashPassword(string password)
        {
            // SHA-256 (Secure Hash Algorithm 256-bit)
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
