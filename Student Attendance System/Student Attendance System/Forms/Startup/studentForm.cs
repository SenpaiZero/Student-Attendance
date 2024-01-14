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
using Guna.UI2.WinForms;
using Student_Attendance_System.Forms;
using System.Drawing.Drawing2D;

namespace Student_Attendance_System.Startup
{
    public partial class studentForm : Form
    {
        cameraHelper mainCamera;
        cameraHelper scanningCamera;
        public static splitPopup split;
        public static studentForm std;
        public studentForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
            split = new splitPopup();
            std = this;

            //Picture cam
            mainCamera = new cameraHelper();
            mainCamera.qrcode = false;
            mainCamera.camListCB = camList;
            mainCamera.selfPic = secondPic;
            mainCamera.onLoad();
            mainCamera.changeCam(1);
            
            //Scanner cam
            scanningCamera = new cameraHelper();
            scanningCamera.qrcode = true;
            scanningCamera.camListCB = scannerList;
            scanningCamera.selfPic = qrScanning;
            scanningCamera.onLoad();

            if (mainCamera.camListCB.Items.Count < 1)
            {
                mainCamera = null;
                secondPic.Enabled = false;
            }

        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Display the video frame in the PictureBox.
            secondPic.Image = (System.Drawing.Image)eventArgs.Frame.Clone();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            settingContainer.Visible = !settingContainer.Visible;
        }

        private void studentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            scanningCamera.closeForm();
            mainCamera.closeForm();
            splitPopup.isVisible = false;
            split.Hide();
        }

        private void scannerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            scanningCamera.changeCam(scannerList.SelectedIndex);
        }

        private void camList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainCamera.changeCam(camList.SelectedIndex);
        }

        private void popupCB_CheckedChanged(object sender, EventArgs e)
        {
            if (popupCB.Checked)
            {
                splitPopup.isVisible = true;
                split.Show();
            }
            else
            {
                splitPopup.isVisible = false;
                split.Hide();
            }
        }

        private void secondPic_Click(object sender, EventArgs e)
        {

        }

        public void getFrame()
        {
            splitPopup.lastCapture = mainCamera.frame;
        }

        private void settingContainer_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
