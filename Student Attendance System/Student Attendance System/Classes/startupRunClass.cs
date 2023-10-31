using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    internal class startupRunClass
    {
        public static bool isFirst = false;
        public static void runStartup()
        {
            startupRunClass startupRunClass = new startupRunClass();
            startupRunClass.setDBConnection();

            if (!Properties.Settings.Default.stayLogin)
                isFirst = true;
        }
        void setDBConnection()
        {
            databaseHelper.con = new System.Data.SqlClient.SqlConnection(Config.databaseConnection);
        }

        public static bool persistentLogin()
        {
            //Remove comment below if login has issue
            //Properties.Settings.Default.Reset(); 
            // Don't login if stay logged in is not checked
            if (Properties.Settings.Default.stayLogin == false)
                return false;

            loginHelper login = new loginHelper()
            {
                Password = Properties.Settings.Default.loginPassword,
                staffID = Properties.Settings.Default.loginStaffID,
                stayLogin = true
            };

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
