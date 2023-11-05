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
                pic.Image = ErnployeesGlobalVariable.frame;
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
            ErnployeesGlobalVariable.isNext = false;
            yearCB.Text = ErnployeesGlobalVariable.year;
            sectionTB.Text = ErnployeesGlobalVariable.section;
            idTB.Text = ErnployeesGlobalVariable.id;
            moreDetailTB.Text = ErnployeesGlobalVariable.moreDetails;

            if (ErnployeesGlobalVariable.frame != null)
                pic.Image = ErnployeesGlobalVariable.frame;
            if (ErnployeesGlobalVariable.QRCode != null)
                qrCodePic.Image = ErnployeesGlobalVariable.QRCode;
            if (String.IsNullOrEmpty(ErnployeesGlobalVariable.year))
                yearCB.SelectedIndex = 0;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomDigits = random.Next(100000, 999999); // Generates a 6-digit random number
            String randomizedId = "100" + randomDigits.ToString();

            idTB.Text = randomizedId;
            ErnployeesGlobalVariable.QRCode = QrCodeHelper.generateQrCode(randomizedId);
            qrCodePic.Image = ErnployeesGlobalVariable.QRCode;
        }

        private void moreDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ErnployeesGlobalVariable.section = sectionTB.Text;
            ErnployeesGlobalVariable.year = yearCB.Text;
            ErnployeesGlobalVariable.id = idTB.Text;
            ErnployeesGlobalVariable.moreDetails = moreDetailTB.Text;

            //wala pa student type
        }

        private void sectionTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(sectionTB, "Section", errorProvider1))
                return;

            checkAttemp[0] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void moreDetailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(moreDetailTB, "Data", errorProvider1))
                return;

            checkAttemp[1] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        public static void done()
        {
            ErnployeesGlobalVariable.isNext = false;
            MessageForm msg = new MessageForm()
            {
                messageType = "Failed",
                header = "Ooooops.",
                isYesNo = false
            };
            if(ErnployeesGlobalVariable.frame == null)
            {
                msg.message = "Please add student's picture.";
                msg.ShowDialog();
                return;
            }
            if(ErnployeesGlobalVariable.QRCode == null)
            {
                msg.message = "Please generate student ID and QRCode";
                msg.ShowDialog();
                return;
            }

            for (int i = 0; i < checkAttemp.Length; i++)
            {
                if (checkAttemp[i] == false)
                {
                    ErnployeesGlobalVariable.isNext = false;
                    return;
                }
            }

            ErnployeesGlobalVariable.isNext = true;
        }
    }
}
