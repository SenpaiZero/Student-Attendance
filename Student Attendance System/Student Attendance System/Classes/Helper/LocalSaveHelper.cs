using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System.Classes.Helper
{
    internal class LocalSaveHelper
    {
        public static void saveQRCode(Bitmap image, string studentID)
        {
            if (image != null)
            {
                image.Save($"{Config.qrcodePath}\\{studentID}.png", ImageFormat.Png);
            }
        }

    }
}
