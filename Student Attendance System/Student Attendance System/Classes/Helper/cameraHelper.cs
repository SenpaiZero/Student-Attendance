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
using Student_Attendance_System.Classes.Helper;
using System.Diagnostics;
using Student_Attendance_System.Forms;
using Student_Attendance_System.Startup;

namespace Student_Attendance_System.Classes
{
    internal class cameraHelper
    {
        private FilterInfoCollection videoDevices; // Stores available video devices
        private VideoCaptureDevice videoSource; // Represents the video capture device
        private bool capturing = false; // Indicates if we are currently capturing
        private QRCodeReader barcodeReader;
        public Bitmap frame;

        public bool isValid = false;
        public string fullName, idNum, dateString, timeString; 
        private bool isProcessingScan = false;
        private System.Windows.Forms.Timer frameProcessingTimer;
        private Stopwatch stopwatch;

        public cameraHelper()
        {
            stopwatch = new Stopwatch();
            frameProcessingTimer = new System.Windows.Forms.Timer();
            frameProcessingTimer.Interval = 100; // Set the interval to 500 milliseconds
            frameProcessingTimer.Tick += new EventHandler(frameProcessingTimer_Tick);
            frameProcessingTimer.Start(); // Start the timer

        }
        private void frameProcessingTimer_Tick(object sender, EventArgs e)
        {
            if(stopwatch.ElapsedMilliseconds >= 2000)
            {
                isProcessingScan = false;
                stopwatch.Stop();
                stopwatch.Reset();
            }
        }
        public void closeForm()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        // Changing cam based on index of combobox
        public void changeCam(int index)
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
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
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
                        if (isProcessingScan) return;
                        isProcessingScan = true;
                        stopwatch.Start();

                        String qrcodeVal = result.Text;
                        attendanceHelper.attendance(qrcodeVal);
                        MessageBox.Show(qrcodeVal);

                        if (splitPopup.isVisible)
                        {
                            studentForm.split.updateData(qrcodeVal);
                            studentForm.std.getFrame();
                        }
                    }
                }
            }
            
            try
            {
                frame = CropToSquare(frame);
                selfPic.Image = frame; // Display the frame on the PictureBox
            }
            catch(Exception ex)
            {
                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    isYesNo = false,
                    header = "Wooooops!",
                    message = ex.Message
                };
                msg.ShowDialog();
            }
        }
        // Method for starting a form with a cam
        public void onLoad()
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

        public void start(int i)
        {
            videoSource = null;
            changeCam(i);
        }
        public void captureBtn()
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

        public Guna2ComboBox camListCB { get; set; }
        public Guna2PictureBox selfPic { get; set; }
        public bool qrcode { get; set; }
    }
}
