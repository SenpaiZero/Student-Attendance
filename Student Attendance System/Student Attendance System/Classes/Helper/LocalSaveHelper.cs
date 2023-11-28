using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Classes.Helper
{
    internal class LocalSaveHelper
    {
        public static void saveQRCode(Bitmap image, string studentID)
        {
            if (!Config.saveLocal) // Stop the method if the save local is disabled
                return;

            checkFolderExist(Config.qrcodePath);
            if (image != null)
            {
                image.Save($"{Config.qrcodePath}\\{studentID}.png", ImageFormat.Png);
            }
        }
        public static void saveQRCode_unenroll(Bitmap image, string studentID)
        {
            if (!Config.saveLocal) // Stop the method if the save local is disabled
                return;
            checkFolderExist(Config.qrcodePath_unenroll);
            if (image != null)
            {
                image.Save($"{Config.qrcodePath}\\{studentID}.png", ImageFormat.Png);
            }
        }
        public static void savePicture(Bitmap image, string studentID)
        {
            if (!Config.saveLocal) // Stop the method if the save local is disabled
                return;
            checkFolderExist(Config.picturePath);
            if (image != null)
            {
                image.Save($"{Config.picturePath_unenroll}\\{studentID}.png", ImageFormat.Png);
            }
        }
        public static void savePicture_unenroll(Bitmap image, string studentID)
        {
            if (!Config.saveLocal) // Stop the method if the save local is disabled
                return;
            checkFolderExist(Config.picturePath_unenroll);
            if (image != null)
            {
                image.Save($"{Config.picturePath_unenroll}\\{studentID}.png", ImageFormat.Png);
            }
        }

        public static bool moveImage(bool moveToUnenroll, String pngName)
        {
            if (!Config.saveLocal) // Stop the method if the save local is disabled
                return true;

            String enrollPathQR = Config.qrcodePath + $@"\{pngName}.png";
            String enrollPathPic = Config.picturePath + $@"\{pngName}.png";
            String unenrollPathQR = Config.qrcodePath_unenroll + $@"\{pngName}.png";
            String unenrollPathPic = Config.picturePath_unenroll + $@"\{pngName}.png";
            try
            {
                if (moveToUnenroll)
                {
                    File.Move(enrollPathQR, unenrollPathQR);
                    File.Move(enrollPathPic, unenrollPathPic);
                }
                else
                {
                    File.Move(unenrollPathQR, enrollPathQR);
                    File.Move(unenrollPathPic, enrollPathPic);
                }

                return true;
            } catch (Exception ex)
            {
                MessageForm msg = new MessageForm()
                {
                    isYesNo = false,
                    messageType = "Failed",
                    header = "Woooops",
                    message = $"{ex.Message}"
                };
                msg.ShowDialog();
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        static void checkFolderExist(string path)
        {
            if (!Config.saveLocal) // Stop the method if the save local is disabled
                return;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

    }
}
