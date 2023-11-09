using Guna.UI2.WinForms;
using Student_Attendance_System.Classes;
using Student_Attendance_System.Startup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms
{
    public partial class splitPopup : Form
    {
        cameraHelper mainCam;
        public Guna2ComboBox mainPicCB { get; set; }
        public splitPopup()
        {
            InitializeComponent();
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
        private void splitPopup_Load(object sender, EventArgs e)
        {
            mainCam = new cameraHelper();
            mainCam.qrcode = false;
            mainCam.camListCB = mainPicCB;
            mainCam.selfPic = camera;
            mainCam.onLoad();
        }

        private void splitPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainCam.closeForm();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
        }
    }
}
