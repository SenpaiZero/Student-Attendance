using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    internal class loginHelper
    {
        public string staffID { get; set; }
        public static string Password { get; set; }
        public bool stayLogin { get; set; }

        // Only one staff can login so this is static
        public static string Name { get; set; }
        public static string Admin { get; set; }
        public static bool isLogin { get; set; }

        public loginHelper()
        {
            stayLogin = Properties.Settings.Default.stayLogin;
        }

        public bool login()
        {
            if (!checkLogin())
                return false;

            if(stayLogin)
            {
                Properties.Settings.Default.stayLogin = true;
                Properties.Settings.Default.loginStaffID = staffID;
                Properties.Settings.Default.loginPassword = Password;
                Properties.Settings.Default.loginAdmin = Admin;
                Properties.Settings.Default.Save();
            }
            return true;
        }

        public bool checkLogin()
        {
            try
            {
                if(databaseHelper.con.State != System.Data.ConnectionState.Open)
                    databaseHelper.con.Open();

                databaseHelper db = new databaseHelper();
                db.cmd = new System.Data.SqlClient.SqlCommand
                    ($"SELECT * FROM Accounts WHERE StaffID COLLATE Latin1_General_CS_AS = '{staffID}' " +
                    $"AND Password COLLATE Latin1_General_CS_AS = '{Password}'", databaseHelper.con);

                db.dr = db.cmd.ExecuteReader();

                if (db.dr.Read())
                {
                    Name = db.dr.GetString(1);
                    Admin = db.dr.GetString(10);
                    isLogin = true;
                    return true;
                }
                databaseHelper.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public void logout()
        {
            MessageForm msg = new MessageForm()
            {
                header = "Hmmm...",
                message = "Are you sure you want to logout?",
                messageType = "Information",
                isYesNo = true,

            };
            if(msg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.stayLogin = false;
                Properties.Settings.Default.loginStaffID = "";
                Properties.Settings.Default.loginPassword = "";
                Properties.Settings.Default.loginAdmin = "";
                Properties.Settings.Default.Save();
                Name = "LOGIN";
                staffID = "";
                Password = "";
                Admin = "";
                isLogin = false;
            }
        }
    }
}
