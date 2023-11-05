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
        public static bool isNext {get; set; }
        // Personal Details
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string middleName { get; set; }
        public static string birthday { get; set; }
        public static string age { get; set; }
        public static string email { get; set; }
        public static string phone { get; set; }
        public static string gender { get; set; }
        public static string religion { get; set; }
        public static string address { get; set; }

        // Guardian Details

        // Father Detail
        public static string fatherfName { get; set; }
        public static string fatherlName { get; set; }
        public static string fathermName { get; set; }
        public static string fatherEmail { get; set; }
        public static string fatherPhone { get; set; }
        public static string fatherOccupation { get; set; }

        // Mother Detail
        public static string motherfName { get; set; }
        public static string motherlName { get; set; }
        public static string mothermName { get; set; }
        public static string motherPhone { get; set; }
        public static string motherEmail { get;set; }
        public static string motherOccupation { get; set; }

        // More Details
        public static Bitmap frame { get; set; }
        public static Bitmap QRCode { get; set; }
        public static string section { get; set; }
        public static string year { get; set; }
        public static string moreDetails { get; set; }
        public static string id { get; set; }


    }
}
