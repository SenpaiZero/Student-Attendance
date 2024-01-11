using Student_Attendance_System.Forms.Enroll;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System.Classes
{
    internal class EnrollmentGlobalVariable
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
        public static string studentType { get; set; }

        public moreDetailsForm moreDetailsForm
        {
            get => default;
            set
            {
            }
        }

        public guardianDetails guardianDetails
        {
            get => default;
            set
            {
            }
        }

        public personalDetails personalDetails
        {
            get => default;
            set
            {
            }
        }

        public Forms.studentPictureForm studentPictureForm
        {
            get => default;
            set
            {
            }
        }

        public Forms.Modals.previewEnrollmentData previewEnrollmentData
        {
            get => default;
            set
            {
            }
        }

        public static void defaultData()
        {
            EnrollmentGlobalVariable.page = 0;
            //page 1
            EnrollmentGlobalVariable.firstName = "";
            EnrollmentGlobalVariable.middleName = "";
            EnrollmentGlobalVariable.lastName = "";

            EnrollmentGlobalVariable.birthday = "";
            EnrollmentGlobalVariable.age = "";
            EnrollmentGlobalVariable.religion = "";
            EnrollmentGlobalVariable.gender = "";
            EnrollmentGlobalVariable.address = "";
            EnrollmentGlobalVariable.phone = "";
            EnrollmentGlobalVariable.email = "";
            personalDetails.checkAttemp = new bool[] { false, false, false, false, false, false, false };

            //Page 2
            EnrollmentGlobalVariable.fatherfName = "";
            EnrollmentGlobalVariable.fathermName = "";
            EnrollmentGlobalVariable.fatherlName = "";
            EnrollmentGlobalVariable.fatherEmail = "";
            EnrollmentGlobalVariable.fatherPhone = "";
            EnrollmentGlobalVariable.fatherOccupation = "";


            EnrollmentGlobalVariable.motherfName = "";
            EnrollmentGlobalVariable.mothermName = "";
            EnrollmentGlobalVariable.motherlName = "";
            EnrollmentGlobalVariable.motherEmail = "";
            EnrollmentGlobalVariable.motherPhone = "";
            EnrollmentGlobalVariable.motherOccupation = "";
            guardianDetails.checkAttemp = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };


            //Page 3
            EnrollmentGlobalVariable.section = "";
            EnrollmentGlobalVariable.year = "";
            EnrollmentGlobalVariable.id = "";
            EnrollmentGlobalVariable.moreDetails = "";
            EnrollmentGlobalVariable.frame = null;
            EnrollmentGlobalVariable.QRCode = null;
            moreDetailsForm.checkAttemp = new bool[] { false, false };
        }
    }
}
