using Student_Attendance_System.Forms;
using Student_Attendance_System.Startup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_Attendance_System.Classes.Helper
{
    internal class attendanceHelper
    {
        public static void attendance(String id)
        {
            Bitmap lastCap = splitPopup.lastCapture;
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss"); // e.g., 15:30:00
            string formattedDate = currentTime.ToShortDateString(); // e.g., 2023-06-08

            if (databaseHelper.con.State != System.Data.ConnectionState.Open)
                databaseHelper.open();

            databaseHelper db = new databaseHelper();
            String query_checkExist = $"" +
                    $"SELECT TimeOut " +
                    $"FROM attendance " +
                    $"WHERE StudentID = @id " +
                    $"AND Date = @date " +
                    $"ORDER BY date DESC";
            using (db.cmd = new SqlCommand(query_checkExist, databaseHelper.con))
            {
                db.cmd.Parameters.AddWithValue("id", id);
                db.cmd.Parameters.AddWithValue("date", formattedDate);
                SqlDataReader dr = db.cmd.ExecuteReader();

                if (dr.Read())
                {
                    if(dr.IsDBNull(0))
                    {
                        dr.Close();
                        string query2 = $"UPDATE attendance SET TimeOut = @out," +
                                    $" TimeOutPic = @timeoutPic" +
                                    $" WHERE StudentID = @id AND TimeOut IS NULL";


                        using (SqlCommand cmd2 = new SqlCommand(query2, databaseHelper.con))
                        {
                            cmd2.Parameters.AddWithValue("@out", formattedTime);
                            cmd2.Parameters.AddWithValue("@id", id);
                            cmd2.Parameters.AddWithValue("@timeoutPic", databaseHelper.bitmapToVarBinary(lastCap));
                            cmd2.ExecuteNonQuery();
                            Config.colorPopupLabel = 2;

                            Task.Run(() =>
                            {
                                emailHelper.sendEmail(id, formattedTime, "TIME OUT");
                            });
                        }
                    }
                    else
                    {
                        Config.colorPopupLabel = 3;
                        dr.Close();
                    }
                }
                else
                {
                    dr.Close();
                    //  TIME IN
                    String query_newRow = "INSERT INTO attendance (StudentID, Date, TimeIn, TimeInPic) " +
                                            "VALUES (@id, @date, @timein, @timeInPic)";

                    using (SqlCommand cmdNewRow = new SqlCommand(query_newRow, databaseHelper.con))
                    {
                        cmdNewRow.Parameters.AddWithValue("id", id);
                        cmdNewRow.Parameters.AddWithValue("date", formattedDate);
                        cmdNewRow.Parameters.AddWithValue("timein", formattedTime);
                        cmdNewRow.Parameters.AddWithValue("timeInPic", databaseHelper.bitmapToVarBinary(lastCap));
                        cmdNewRow.ExecuteNonQuery();
                        Config.colorPopupLabel = 1;
                        Task.Run(() =>
                        {
                            emailHelper.sendEmail(id, formattedTime, "TIME IN");
                        });
                    }
                }
            }
        }
    }
}
