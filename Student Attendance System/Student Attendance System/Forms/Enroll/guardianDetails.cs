using Guna.UI2.WinForms;
using Student_Attendance_System.Classes;
using Student_Attendance_System.Classes.Helper;
using System;
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
    public partial class guardianDetails : Form
    {
        public static bool[] checkAttemp = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };
        public guardianDetails()
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
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guardianDetails_Load(object sender, EventArgs e)
        {
            EnrollmentGlobalVariable.isNext = false;
            fatherfnameTB.Text = EnrollmentGlobalVariable.fatherfName;
            fathermnameTB.Text = EnrollmentGlobalVariable.fathermName;
            fatherlnameTB.Text = EnrollmentGlobalVariable.fatherlName;
            fatherEmailTB.Text = EnrollmentGlobalVariable.fatherEmail;
            fatherPhoneNumberTB.Text = EnrollmentGlobalVariable.fatherPhone;
            fatherOccupationTB.Text = EnrollmentGlobalVariable.fatherOccupation;

            motherfnameTB.Text = EnrollmentGlobalVariable.motherfName;
            mothermnameTB.Text = EnrollmentGlobalVariable.mothermName;
            motherlnameTB.Text = EnrollmentGlobalVariable.motherlName;
            motherEmailTB.Text = EnrollmentGlobalVariable.motherEmail;
            motherPhoneTB.Text = EnrollmentGlobalVariable.motherPhone;
            motherOccupationTB.Text = EnrollmentGlobalVariable.motherOccupation;
        }

        private void firstNameTB_SizeChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void guardianDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnrollmentGlobalVariable.fatherfName = fatherfnameTB.Text;
            EnrollmentGlobalVariable.fathermName = fathermnameTB.Text;
            EnrollmentGlobalVariable.fatherlName = fatherlnameTB.Text;
            EnrollmentGlobalVariable.fatherEmail = fatherEmailTB.Text;
            EnrollmentGlobalVariable.fatherPhone = fatherPhoneNumberTB.Text;
            EnrollmentGlobalVariable.fatherOccupation = fatherOccupationTB.Text;

            EnrollmentGlobalVariable.motherfName = motherfnameTB.Text;
            EnrollmentGlobalVariable.mothermName = mothermnameTB.Text;
            EnrollmentGlobalVariable.motherlName = motherlnameTB.Text;
            EnrollmentGlobalVariable.motherEmail = motherEmailTB.Text;
            EnrollmentGlobalVariable.motherPhone = motherPhoneTB.Text;
            EnrollmentGlobalVariable.motherOccupation = motherOccupationTB.Text;
        }

        private void fatherfnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fatherfnameTB, "First Name", errorProvider1))
            {
                checkAttemp[10] = false;
                return;
            }
            checkAttemp[10] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void fathermnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fathermnameTB, "Middle Name", errorProvider1))
            {
                checkAttemp[11] = false;
                return;
            }
            checkAttemp[11] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void fatherlnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fatherlnameTB, "Last Name", errorProvider1))
            {
                checkAttemp[0] = false;
                return;
            }
            checkAttemp[0] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void fatherEmailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Email(fatherEmailTB, "Email", errorProvider1))
            {
                checkAttemp[1] = false;
                return;
            }
            checkAttemp[1] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void fatherPhoneNumberTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_PhoneNumber(fatherPhoneNumberTB, "Phone Number", errorProvider1))
            {
                checkAttemp[2] = false;
                return;
            }
            checkAttemp[2] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void fatherOccupationTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fatherOccupationTB, "Occupation", errorProvider1))
            {
                checkAttemp[3] = false;
                return;
            }
            checkAttemp[3] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void motherfnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(motherfnameTB, "First Name", errorProvider1))
            {
                checkAttemp[4] = false;
                return;
            }
            checkAttemp[4] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void motherlnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(motherlnameTB, "Last Name", errorProvider1))
            {
                checkAttemp[5] = false;
                return;
            }
            checkAttemp[5] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void mothermnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(mothermnameTB, "Middle Name", errorProvider1))
            {
                checkAttemp[6] = false;
                return;
            }
            checkAttemp[6] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void motherEmailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Email(motherEmailTB, "Email", errorProvider1))
            {
                checkAttemp[7] = false;
                return;
            }
            checkAttemp[7] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void motherPhoneTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_PhoneNumber(motherPhoneTB, "Phone Number", errorProvider1))
            {
                checkAttemp[8] = false;
                return;
            }
            checkAttemp[8] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void motherOccupationTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(motherOccupationTB, "Occupation", errorProvider1))
            {
                checkAttemp[9] = false;
                return;
            }
            checkAttemp[9] = true;
            EnrollmentGlobalVariable.isNext = true;
        }
    
        public static void done()
        {
            for (int i = 0; i < checkAttemp.Length; i++)
            {
                if (checkAttemp[i] == false)
                {
                    EnrollmentGlobalVariable.isNext = false;

                    MessageForm msg = new MessageForm()
                    {
                        header = "Ooooops!",
                        message = "Please check all input fields.",
                        messageType = "Failed",
                        isYesNo = false
                    };
                    msg.ShowDialog();
                    return;
                }
            }

            EnrollmentGlobalVariable.isNext = true;
        }
    }
}
