using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System.Classes.Helper
{
    public class QrCodeHelper
    {
        public Forms.Enroll.moreDetailsForm moreDetailsForm
        {
            get => default;
            set
            {
            }
        }

        // Generating qr code based on qrcode library
        public static Bitmap generateQrCode(string studentID)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData data = generator.CreateQrCode(studentID, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);

            return qrCode.GetGraphic(
                20, // Pixel per module
                Color.Black,
                Color.White,
                new Bitmap(Properties.Resources.logo) //Picutre in the middle
                );
        }

    }
}
