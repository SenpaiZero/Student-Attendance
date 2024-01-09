using QRCoder;
using Student_Attendance_System.Classes;
using Student_Attendance_System.Classes.Helper;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Enroll
{
    public partial class moreDetailsForm : Form
    {
        public static bool[] checkAttemp = new bool[] { false, false };
        public moreDetailsForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            studentPictureForm std = new studentPictureForm();
            if (std.ShowDialog() == DialogResult.OK)
                pic.Image = EnrollmentGlobalVariable.frame;
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

        private void moreDetailsForm_Load(object sender, EventArgs e)
        {
            EnrollmentGlobalVariable.isNext = false;
            yearCB.Text = EnrollmentGlobalVariable.year;
            sectionTB.Text = EnrollmentGlobalVariable.section;
            idTB.Text = EnrollmentGlobalVariable.id;
            moreDetailTB.Text = EnrollmentGlobalVariable.moreDetails;

            if (EnrollmentGlobalVariable.frame != null)
                pic.Image = EnrollmentGlobalVariable.frame;
            if (EnrollmentGlobalVariable.QRCode != null)
                qrCodePic.Image = EnrollmentGlobalVariable.QRCode;
            if (String.IsNullOrEmpty(EnrollmentGlobalVariable.year))
                yearCB.SelectedIndex = 0;
            if(String.IsNullOrEmpty(EnrollmentGlobalVariable.studentType))
                studentTypeCB.SelectedIndex = 0;

            cbUpdate();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomDigits = random.Next(100000, 999999); // Generates a 6-digit random number
            String randomizedId = "100" + randomDigits.ToString();

            idTB.Text = randomizedId;
            EnrollmentGlobalVariable.QRCode = QrCodeHelper.generateQrCode(randomizedId);
            qrCodePic.Image = EnrollmentGlobalVariable.QRCode;
            EnrollmentGlobalVariable.id = idTB.Text;
        }

        private void moreDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void sectionTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(sectionTB, "Section", errorProvider1))
            {
                checkAttemp[0] = false;
                return;
            }
            EnrollmentGlobalVariable.section = sectionTB.Text;
            checkAttemp[0] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void moreDetailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(moreDetailTB, "Data", errorProvider1))
            {
                checkAttemp[1] = false;
                return;
            }
            EnrollmentGlobalVariable.moreDetails = moreDetailTB.Text;
            checkAttemp[1] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        public static void done()
        {
            EnrollmentGlobalVariable.isNext = false;
            MessageForm msg = new MessageForm()
            {
                messageType = "Failed",
                header = "Ooooops.",
                isYesNo = false
            };
            if(EnrollmentGlobalVariable.frame == null)
            {
                msg.message = "Please add student's picture.";
                msg.ShowDialog();
                return;
            }
            if(EnrollmentGlobalVariable.QRCode == null)
            {
                msg.message = "Please generate student ID and QRCode";
                msg.ShowDialog();
                return;
            }

            for (int i = 0; i < checkAttemp.Length; i++)
            {
                if (checkAttemp[i] == false)
                {
                    EnrollmentGlobalVariable.isNext = false;

                    MessageForm msg4 = new MessageForm()
                    {
                        header = "Ooooops!",
                        message = "Please check all input fields.",
                        messageType = "Failed",
                        isYesNo = false
                    };
                    msg4.ShowDialog();
                    return;
                }
            }
            EnrollmentGlobalVariable.isNext = true;
        }

        private void moreDetailsForm_Deactivate(object sender, EventArgs e)
        {
        }
        void cbUpdate()
        {
            EnrollmentGlobalVariable.year = yearCB.Text;
            EnrollmentGlobalVariable.studentType = studentTypeCB.Text;
        }
        private void yearCB_Leave(object sender, EventArgs e)
        {
            EnrollmentGlobalVariable.year = yearCB.Text;
        }

        private void studentTypeCB_DragLeave(object sender, EventArgs e)
        {
        }

        private void studentTypeCB_Leave(object sender, EventArgs e)
        {
            EnrollmentGlobalVariable.studentType = studentTypeCB.Text;
        }
    }
}
