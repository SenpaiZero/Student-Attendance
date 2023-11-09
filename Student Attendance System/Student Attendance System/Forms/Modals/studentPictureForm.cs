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

namespace Student_Attendance_System.Forms
{
    public partial class studentPictureForm : Form
    {
        cameraHelper capture;
        public studentPictureForm()
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
        private void studentPictureForm_Load(object sender, EventArgs e)
        {
            capture = new cameraHelper();
            capture.qrcode = false;
            capture.camListCB = camListCB;
            capture.selfPic = camPB;
            capture.onLoad();
        }

        private void studentPictureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            capture.closeForm();
        }

        private void camListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            capture.changeCam(camListCB.SelectedIndex);
        }

        private void captureBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            capture.captureBtn();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            capture.start(camListCB.SelectedIndex);
        }
    }
}
