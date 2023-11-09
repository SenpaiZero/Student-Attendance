﻿using System;
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

        public static string qrcodePath = "C:\\Users\\Xeb\\Desktop\\test\\qrcode";
        public static string picturePath = "C:\\Users\\Xeb\\Desktop\\test\\picture";
        public static bool isMaximized {get; set;}
    }
}
