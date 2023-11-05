using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using AForge.Video;
using AForge.Video.DirectShow;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Attendance_System.Classes
{
    internal class cameraHelper
    {
        private static FilterInfoCollection videoDevices; // Stores available video devices
        private static VideoCaptureDevice videoSource; // Represents the video capture device
        private static bool capturing = false; // Indicates if we are currently capturing
        private static QRCodeReader barcodeReader;
        private static Bitmap frame;

        public static bool isValid = false;
        public static string fullName, idNum, dateString, timeString;
        public static void closeForm()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        // Changing cam based on index of combobox
        public static void changeCam(int index)
        {
            // Close the form if the camera is running
            if (capturing)
            {
                closeForm();
            }

            videoSource = new VideoCaptureDevice(videoDevices[index].MonikerString);

            // Event handler for new frames
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

            videoSource.Start(); // Start capturing
            capturing = true;
        }

        // Event for the picturebox to run live without dela
        private static void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!capturing) return;

            // Clone the new frame to avoid cross-threading issues
            frame = (Bitmap)eventArgs.Frame.Clone();

            // Continue if the qrcode bool property is true
            if (qrcode)
            {

                barcodeReader = new QRCodeReader();
                // Convert the Bitmap to a byte array
                byte[] byteArray = BitmapToByteArray(frame);

                // Convert the Bitmap to ZXing's RGBLuminanceSource
                RGBLuminanceSource luminanceSource = new RGBLuminanceSource(byteArray, frame.Width, frame.Height);

                // Create a BinaryBitmap from the luminance source
                BinaryBitmap binaryBitmap = new BinaryBitmap(new HybridBinarizer(luminanceSource));


                // Read QR code from the frame
                Result result = barcodeReader.decode(binaryBitmap);
                if (result != null)
                {
                    if (validationHelper.checkFieldNumeric(result.Text))
                    {
                        String qrcodeVal = result.Text;
                        MessageBox.Show(qrcodeVal);
                        // stop the camera if its running
                        if (videoSource != null && videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource.WaitForStop();
                        }
                    }
                }

            }
            frame = CropToSquare(frame);
            selfPic.Image = frame; // Display the frame on the PictureBox
        }


        // Method for starting a form with a cam
        public static void onLoad()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); // Get available video devices

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            foreach (FilterInfo device in videoDevices)
            {
                camListCB.Items.Add(device.Name); // Add the device name to the ComboBox
            }

            camListCB.SelectedIndex = 0; // Select the first device by default
            changeCam(0);
        }

        public static void start(int i)
        {
            videoSource = null;
            changeCam(i);
        }
        public static void captureBtn()
        {
            EnrollmentGlobalVariable.frame = CropToSquare(frame);
        }
        // Converting bitmap into byte array
        private static byte[] BitmapToByteArray(Bitmap bitmap)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                return stream.ToArray();
            }
        }

        // Cropping the picture box into box aspect ratio
        private static Bitmap CropToSquare(Bitmap image)
        {
            int size = Math.Min(image.Width, image.Height);

            int x = (image.Width - size) / 4;
            int y = (image.Height - size) / 4;

            Rectangle cropArea = new Rectangle(x, y, size, size);

            Bitmap squareImage = image.Clone(cropArea, image.PixelFormat);

            return squareImage;
        }

        // method for checking if the name is in database or not

        public static Guna2ComboBox camListCB { get; set; }
        public static Guna2PictureBox selfPic { get; set; }
        public static bool qrcode { get; set; }
        public static string id { get; set; }
    }
}
