using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class databaseHelper
    {
        public static SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;

        public static void open()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();

            if (con != null)
                con.Open();
        }

        public static byte[] bitmapToVarBinary(Bitmap image)
        {
            byte[] imageBytes;

            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = stream.ToArray();
            }

            return imageBytes;
        }
    }
}
