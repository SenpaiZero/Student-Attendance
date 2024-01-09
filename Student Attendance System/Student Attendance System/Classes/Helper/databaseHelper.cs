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
            if(!validationHelper.internetAvailability())
            {
                MessageForm msg = new MessageForm()
                {
                    header = "Ooooops!",
                    message = "Please check your internet connection",
                    messageType = "Failed",
                    isYesNo = false
                };
                msg.ShowDialog();
                return;
            }
            if (con.State != ConnectionState.Closed)
                con.Close();

            if (con != null)
                con.Open();
        }

        public static byte[] bitmapToVarBinary(Bitmap image)
        {
            byte[] imageBytes;

            if (image == null)
            {
                Bitmap bitmap2 = Properties.Resources.No_Image_Placeholder_svg;

                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap2.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = stream.ToArray();
                }

                return imageBytes;
            }

            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = stream.ToArray();
            }

            return imageBytes;
        }
    }
}
