using Student_Attendance_System.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Student_Attendance_System
{
    internal class startupRunClass
    {
        public static bool isFirst = false;
        public static void runStartup()
        {
            startupRunClass startupRunClass = new startupRunClass();
            startupRunClass.setDBConnection();
            startupRunClass.setOutputConfig();
            if (!Properties.Settings.Default.stayLogin)
                isFirst = true;

            EnrollmentGlobalVariable.page = 0;
        }
        void setDBConnection()
        {
            databaseHelper.con = new System.Data.SqlClient.SqlConnection(Config.databaseConnection);
        }

        void setOutputConfig()
        {

            if (String.IsNullOrEmpty(Properties.Settings.Default.qrcodePath) 
                || Properties.Settings.Default.qrcodePath == Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic\qrcode")
            {
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic\qrcode");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic\picture");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic\qrcode\unenroll");
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic\picture\unenroll");
                }

                Properties.Settings.Default.qrcodePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic\qrcode";
            }
            if (String.IsNullOrEmpty(Properties.Settings.Default.picPath))
                Properties.Settings.Default.picPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\attendance_pic\picture";

            Config.qrcodePath = Properties.Settings.Default.qrcodePath;
            Config.qrcodePath_unenroll = Properties.Settings.Default.qrcodePath + @"\unenroll";
            Config.picturePath = Properties.Settings.Default.picPath;
            Config.picturePath_unenroll = Properties.Settings.Default.picPath + @"\unenroll";

            Properties.Settings.Default.Save();
        }
        public static bool persistentLogin()
        {
            //Remove comment below if login has issue
            //Properties.Settings.Default.Reset(); 
            // stop login if stay logged in is not checked
            if (Properties.Settings.Default.stayLogin == false)
                return false;

            loginHelper login = new loginHelper()
            {
                staffID = Properties.Settings.Default.loginStaffID,
                stayLogin = true
            };
            loginHelper.Password = Properties.Settings.Default.loginPassword;

            login.login();
            return true;
        }

        public static void checkInternet(Form parent)
        {
            if (!validationHelper.internetAvailability())
            {
                MessageForm msg = new MessageForm()
                {
                    header = "Ooooops!",
                    message = "Please check your internet connection",
                    messageType = "Failed",
                    isYesNo = false
                };
                Thread.Sleep(1000);
                if(msg.ShowDialog(parent) == DialogResult.OK)
                {
                    checkInternet(parent);
                }
            }
        }
    }
}
