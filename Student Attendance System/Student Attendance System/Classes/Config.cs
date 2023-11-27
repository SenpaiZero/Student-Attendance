using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class Config
    {
        // Applicatin Config
        public static String appVersion = "1.0.0";

        // Database Config
        public static String databaseConnection =
            "Server=tcp:student-attendance.database.windows.net,1433;" +
            "Initial Catalog=student-attendance;" +
            "Persist Security Info=False;" +
            "User ID=student_attendance;" +
            "Password=BSIT123sti;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";

        public static string qrcodePath = "";
        public static string qrcodePath_unenroll = "";
        public static string picturePath = "";
        public static string picturePath_unenroll = "";
    }
}
