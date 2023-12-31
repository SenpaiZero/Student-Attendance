using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int pageSize = 15;
        int pageNumber = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                month.SelectedValue = DateTime.Now.Month.ToString();
                year.SelectedValue = DateTime.Now.Year.ToString();
                BindAttendanceData(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text, pageNumber, pageSize);
            }
        }


        private void BindAttendanceData(int month, int year, string name, int pageNumber, int pageSize)
        {
            List<AttendanceData> attendanceList = GetAttendanceData(month, year, name, pageNumber, pageSize);

            // Bind data to the repeater controls
            attendanceRepeater.DataSource = attendanceList;
            attendanceRepeater.DataBind();
        }

        public string getPageNum()
        {
            return pageNumber.ToString();
        }
        private List<AttendanceData> GetAttendanceData(int month, int year, string name, int pageNumber, int pageSize)
        {
            List<AttendanceData> attendanceList = new List<AttendanceData>();

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=tcp:student-attendance.database.windows.net,1433;Initial Catalog=student-attendance;Persist Security Info=False;User ID=student_attendance;Password=BSIT123sti;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conn.Open();

                    int offset = Math.Max((pageNumber - 1), 0) * pageSize; // Calculate the offset

                    string query = $@"SELECT a.StudentID, a.Date, a.TimeIn, a.TimeOut, s.Name
                              FROM attendance a
                              JOIN studentData s ON a.StudentID = s.StudentID
                              WHERE s.Name LIKE '%{name}%' 
                              AND YEAR(a.Date) = {year} 
                              AND MONTH(a.Date) = {month}
                              ORDER BY a.Date DESC
                              OFFSET {offset} ROWS
                              FETCH NEXT {pageSize} ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            AttendanceData attendance = new AttendanceData
                            {
                                StudentID = dr["StudentID"].ToString(),
                                Date = Convert.ToDateTime(dr["Date"]),
                                TimeIn = dr["TimeIn"].ToString(),
                                TimeOut = dr["TimeOut"].ToString(),
                                Name = dr["Name"].ToString()
                            };

                            attendanceList.Add(attendance);
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Response.Write("Error: " + ex.Message);
            }

            return attendanceList;
        }

        protected string GetFormattedTime(object time)
        {
            if (time != null && time != DBNull.Value)
            {
                DateTime parsedTime;
                if (DateTime.TryParse(time.ToString(), out parsedTime))
                {
                    return parsedTime.ToString("HH:mm"); // Adjust the format as needed
                }
            }

            return string.Empty; // Or any default value you prefer
        }
        protected string GetFormattedTime_query(object time)
        {
            if (time != null && time != DBNull.Value)
            {
                DateTime parsedTime;
                if (DateTime.TryParse(time.ToString(), out parsedTime))
                {
                    return parsedTime.ToString("HH:mm:ss"); // Adjust the format as needed
                }
            }

            return string.Empty; // Or any default value you prefer
        }
        protected string GetFormattedDate(object date)
        {
            if (date != null && date != DBNull.Value)
            {
                DateTime parsedDate;
                if (DateTime.TryParse(date.ToString(), out parsedDate))
                {
                    return parsedDate.ToString("yyyy-MM-dd"); // Adjust the format as needed
                }
            }

            return string.Empty; // Or any default value you prefer
        }
        protected void name_TextChanged(object sender, EventArgs e)
        {

            BindAttendanceData(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text, pageNumber, pageSize);
        }

        protected void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindAttendanceData(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text, pageNumber, pageSize);
        }

        protected void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindAttendanceData(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text, pageNumber, pageSize);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindAttendanceData(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text, pageNumber, pageSize);
        }

        // Define the server-side method to handle the row click
        [WebMethod]
        public static string HandleRowClick(string Name, string Date, string TimeIn, string TimeOut)
        {
            Console.WriteLine("asd");
            Console.WriteLine("asd");
            Console.WriteLine("asd");
            Console.WriteLine("asd");
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=tcp:student-attendance.database.windows.net,1433;Initial Catalog=student-attendance;Persist Security Info=False;User ID=student_attendance;Password=BSIT123sti;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conn.Open();

                    string query = $@"SELECT a.StudentID, a.Date, a.TimeIn, a.TimeOut, s.Name, a.TimeInPic, a.TimeOutPic
                             FROM attendance a
                             JOIN studentData s ON a.StudentID = s.StudentID
                             WHERE s.name = '{Name}' AND
                                   a.Date = '{Date}' AND
                                   a.TimeIn = '{TimeIn}' AND
                                   a.TimeOut = '{TimeOut}'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if (dr.IsDBNull(5))
                            {
                                return "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png~" +
                                       "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png";
                            }
                            else if (dr.IsDBNull(6))
                            {
                                return "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png~" +
                                       "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png";
                            }
                            else
                            {
                                byte[] timeInPicData = (byte[])dr["TimeInPic"];
                                byte[] timeOutPicData = (byte[])dr["TimeOutPic"];

                                string timeInBase64 = "data:image/png;base64," + Convert.ToBase64String(timeInPicData);
                                string timeOutBase64 = "data:image/png;base64," + Convert.ToBase64String(timeOutPicData);
                                // Log byte array lengths for debugging
                                Console.WriteLine($"TimeInPic byte length: {timeInPicData.Length}");
                                Console.WriteLine($"TimeOutPic byte length: {timeOutPicData.Length}");

                               // Bitmap timeInBit = ConvertToImage(timeInPicData);
                               // Bitmap timeOutBit = ConvertToImage(timeOutPicData);

                               // string timeInBase64 = ConvertBitmapToBase64(timeInBit);
                                //string timeOutBase64 = ConvertBitmapToBase64(timeOutBit);
                                
                                //web.timein = timeInBase64;
                                //web.timeout = timeOutBase64;
                                //web.updateImg();
                                return timeInBase64 + "~" + timeOutBase64;
                            }
                        }
                        else
                        {
                            return "NoDataFound";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        String timein { get; set; }
        String timeout { get; set; }
        public void updateImg()
        {
            timeinImg.ImageUrl = timein;
            timeoutImg.ImageUrl = timeout;
        }
        
        public void updateCount()
        {
            int page = 1;
            if (pageNumber == 0) page = 1;
            else page = pageNumber;
            pageTotal.Text = "Page " + page;
        }
        private int GetTotalRecordCount(int month, int year, string name)
        {
            int totalCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=tcp:student-attendance.database.windows.net,1433;Initial Catalog=student-attendance;Persist Security Info=False;User ID=student_attendance;Password=BSIT123sti;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conn.Open();

                    string query = $@"SELECT COUNT(a.Date) FROM attendance a JOIN studentData s 
                                    ON a.StudentID = s.StudentID 
                                    WHERE s.Name LIKE '%{name}%' 
                                    AND YEAR(a.Date) = {year} 
                                    AND MONTH(a.Date) = {month}";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        totalCount = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            return (int)Math.Ceiling((double)totalCount / pageSize);
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
                pageNumber--;
            else
                pageNumber = 1; // Set it to the minimum value
            
            updateCount();
            BindAttendanceData(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text, pageNumber, pageSize);
            
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = GetTotalRecordCount(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text);

            if (pageNumber < totalPages)
            {
                pageNumber++; 
                updateCount();
                BindAttendanceData(Convert.ToInt32(month.Text), Convert.ToInt32(year.Text), name.Text, pageNumber, pageSize);
            }
        }
    }
}

