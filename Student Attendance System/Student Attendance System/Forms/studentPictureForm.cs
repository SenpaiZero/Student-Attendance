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
using System.Windows.Media.Media3D;

namespace Student_Attendance_System.Forms
{
    public partial class studentPictureForm : Form
    {
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
            Task.Run(() =>
            {
                cameraHelper.qrcode = true;
                cameraHelper.camListCB = camListCB;
                cameraHelper.selfPic = camPB;
                cameraHelper.onLoad();
            });
        }

        private void studentPictureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraHelper.closeForm();
        }

        private void camListCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraHelper.changeCam(camListCB.SelectedIndex);
        }

        private void captureBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            cameraHelper.captureBtn();
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
            cameraHelper.start(camListCB.SelectedIndex);
        }
    }
}
