using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System.Classes
{
    internal class ErnployeesGlobalVariable
    {
        //Config
        public static int page { get; set; }
        // Personal Details
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string middleName { get; set; }
        public static string date { get; set; }
        public static string age { get; set; }
        public static string email { get; set; }
        public static string phone { get; set; }
        public static string gender { get; set; }
        public static string religion { get; set; }

        // Guardian Details

        // Father Detail
        public static string fatherName { get; set; }
        public static string fatherEmail { get; set; }
        public static string fatherPhone { get; set; }

        // Mother Detail
        public static string motherName { get; set; }
        public static string motherPhone { get; set; }
        public static string motherEmail { get;set; }

        // More Details
        public static Bitmap frame { get; set; }


    }
}
