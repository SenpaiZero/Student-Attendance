using Student_Attendance_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Reflection;

namespace Student_Attendance_System.Startup
{
    public partial class studentForm : Form
    {
        private FilterInfoCollection videoDevicesMain;
        private VideoCaptureDevice videoSourceMain;
        public studentForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        private void studentForm_Load(object sender, EventArgs e)
        {
            cameraHelper.qrcode = true;
            cameraHelper.camListCB = scannerList;
            cameraHelper.selfPic = qrScanning;
            cameraHelper.onLoad();

            //main cam
            videoDevicesMain = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevicesMain)
            {
                camList.Items.Add(device.Name); // Add the device name to the ComboBox
            }
            camList.SelectedIndex = 1;
            if (videoDevicesMain.Count > 0)
            {
                // Initialize the videoSource with the first available camera.
                videoSourceMain = new VideoCaptureDevice(videoDevicesMain[camList.SelectedIndex].MonikerString);
                videoSourceMain.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

                // Start capturing from the camera.
                videoSourceMain.Start();
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Display the video frame in the PictureBox.
            secondPic.Image = (System.Drawing.Image)eventArgs.Frame.Clone();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(settingContainer.Visible == false)
                settingContainer.Visible = true;
            else
                settingContainer.Visible = false;
        }

        private void studentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop capturing and release resources when the form is closing.
            cameraHelper.closeForm();
            if (videoSourceMain != null && videoSourceMain.IsRunning)
            {
                videoSourceMain.SignalToStop();
                videoSourceMain.WaitForStop();
                videoSourceMain = null;
            }
        }

        private void scannerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraHelper.changeCam(scannerList.SelectedIndex);
        }

        private void camList_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCam();
        }

        void changeCam()
        {
            videoSourceMain = new VideoCaptureDevice(videoDevicesMain[camList.SelectedIndex].MonikerString);

            // Event handler for new frames
            videoSourceMain.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

            videoSourceMain.Start(); // Start capturing
        }
    }
}
