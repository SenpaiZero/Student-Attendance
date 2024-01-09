using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System.Classes.Helper
{
    internal class logsHelper
    {
        static string id;
        static string name;
        static DateTime date;

        static void setData()
        {
            id = Properties.Settings.Default.loginStaffID;
            name = loginHelper.Name;
            date = DateTime.Now;

        }
        private static void insertLog(String details, String category)
        {
            String insert_query = "INSERT INTO Logs (Name, StaffID, Details, Category, Date) " +
                "VALUES (@name, @id, @details, @category, @date);";
            if (databaseHelper.con.State != System.Data.ConnectionState.Open)
                databaseHelper.open();

            databaseHelper db = new databaseHelper();
            using (db.cmd = new System.Data.SqlClient.SqlCommand(insert_query, databaseHelper.con))
            {
                db.cmd.Parameters.AddWithValue("id", id);
                db.cmd.Parameters.AddWithValue("name", name.ToUpper());
                db.cmd.Parameters.AddWithValue("details", details);
                db.cmd.Parameters.AddWithValue("category", category);
                db.cmd.Parameters.AddWithValue("date", date);
                db.cmd.ExecuteNonQuery();
            }
        }

        public static void insertAddStaff(string details)
        {
            setData();
            insertLog(details, "ADD STAFF");
        }
        public static void insertDeleteStaff(string details)
        {
            setData();
            insertLog(details, "DELETE STAFF");
        }
        public static void insertUpdateStaff(string details)
        {
            setData();
            insertLog(details, "UPDATE STAFF");
        }
        public static void insertUpdateEnroll(string details)
        {
            setData();
            insertLog(details, "UPDATE ENROLL");
        }
        public static void insertUpdateStudent(string details)
        {
            setData();
            insertLog(details, "UPDATE STUDENT");
        }
        public static void insertNewEnroll(string details)
        {
            setData();
            insertLog(details, "NEW ENROLL");
        }
        public static void insertSetting(string details)
        {
            setData();
            insertLog(details, "SETTING");
        }
        public static void insertUpdateAttendance(string details)
        {
            setData();
            insertLog(details, "UPDATE ATTENDANCE");
        }
    }
}
