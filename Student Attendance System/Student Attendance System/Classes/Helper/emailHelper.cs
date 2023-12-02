using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using System.Data.SqlClient;
using System.Windows.Interop;

namespace Student_Attendance_System.Classes.Helper
{
    internal class emailHelper
    {
        public static void sendEmail(String studentID, String recordTime, String info)
        {

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("attendtrack.automated@gmail.com", "fves awcb rrnf xaec");
            smtp.EnableSsl = true;

            //  Emails
            smtp.Send(sendEmail(studentID, recordTime, info, 0));
            smtp.Send(sendEmail(studentID, recordTime, info, 1));
            smtp.Dispose();
        }

        static MailMessage sendEmail(String studentID, String recordTime, String info, int index)
        {
            string[] parentEmails = getParents(studentID);
            string name = getName(studentID);
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("attendtrack.automated@gmail.com");
            msg.To.Add(parentEmails[index]);
            msg.Subject = $"{name} {info}: {DateTime.Now.Date.ToShortDateString()}";

            // Create the HTML view
            msg.Body = $@"  STUDENT: {name}
                            STUDENT ID: {studentID}
                            DATE: {DateTime.Now.Date.ToShortDateString()}
                            TIME: {DateTime.Now.ToShortTimeString()}
                            {info}";
            
            return msg;
        }
        static String[] getParents(String studentID) 
        {
            if(databaseHelper.con.State != System.Data.ConnectionState.Open) databaseHelper.open();
            String[] emails = new string[3];

            string query = $@"SELECT m.Email, f.Email FROM studentFather f INNER JOIN 
                            studentMother m ON m.StudentID = f.StudentID 
                            WHERE m.StudentID = {studentID}";
            using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    emails[0] = dr.GetString(0);
                    emails[1] = dr.GetString(1);
                    dr.Close();
                }
                return emails;
            }
        }

        static String getName(string studentID)
        {
            if (databaseHelper.con.State != System.Data.ConnectionState.Open) databaseHelper.open();
            String name = "";

            string query = $@"SELECT Name FROM studentData 
                            WHERE StudentID = {studentID}";
            using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    name = dr.GetString(0);
                    dr.Close();
                }
                return name;
            }
        }
    }
}
