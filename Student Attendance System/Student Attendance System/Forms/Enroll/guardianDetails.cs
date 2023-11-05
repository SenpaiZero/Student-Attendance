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
            ErnployeesGlobalVariable.isNext = false;
            fatherfnameTB.Text = ErnployeesGlobalVariable.fatherfName;
            fathermnameTB.Text = ErnployeesGlobalVariable.fathermName;
            fatherlnameTB.Text = ErnployeesGlobalVariable.fatherlName;
            fatherEmailTB.Text = ErnployeesGlobalVariable.fatherEmail;
            fatherPhoneNumberTB.Text = ErnployeesGlobalVariable.fatherPhone;
            fatherOccupationTB.Text = ErnployeesGlobalVariable.fatherOccupation;

            motherfnameTB.Text = ErnployeesGlobalVariable.motherfName;
            mothermnameTB.Text = ErnployeesGlobalVariable.mothermName;
            motherlnameTB.Text = ErnployeesGlobalVariable.motherlName;
            motherEmailTB.Text = ErnployeesGlobalVariable.motherEmail;
            motherPhoneTB.Text = ErnployeesGlobalVariable.motherPhone;
            motherOccupationTB.Text = ErnployeesGlobalVariable.motherOccupation;
        }

        private void firstNameTB_SizeChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void guardianDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            ErnployeesGlobalVariable.fatherfName = fatherfnameTB.Text;
            ErnployeesGlobalVariable.fathermName = fathermnameTB.Text;
            ErnployeesGlobalVariable.fatherlName = fatherlnameTB.Text;
            ErnployeesGlobalVariable.fatherEmail = fatherEmailTB.Text;
            ErnployeesGlobalVariable.fatherPhone = fatherPhoneNumberTB.Text;
            ErnployeesGlobalVariable.fatherOccupation = fatherOccupationTB.Text;

            ErnployeesGlobalVariable.motherfName = motherfnameTB.Text;
            ErnployeesGlobalVariable.mothermName = mothermnameTB.Text;
            ErnployeesGlobalVariable.motherlName = motherlnameTB.Text;
            ErnployeesGlobalVariable.motherEmail = motherEmailTB.Text;
            ErnployeesGlobalVariable.motherPhone = motherPhoneTB.Text;
            ErnployeesGlobalVariable.motherOccupation = motherOccupationTB.Text;
        }

        private void fatherfnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fatherfnameTB, "First Name", errorProvider1))
                return;
            checkAttemp[10] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void fathermnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fathermnameTB, "Middle Name", errorProvider1))
                return;
            checkAttemp[11] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void fatherlnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fatherlnameTB, "Last Name", errorProvider1))
                return;
            checkAttemp[0] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void fatherEmailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Email(fatherEmailTB, "Email", errorProvider1))
                return;
            checkAttemp[1] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void fatherPhoneNumberTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_PhoneNumber(fatherPhoneNumberTB, "Phone Number", errorProvider1))
                return;
            checkAttemp[2] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void fatherOccupationTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(fatherOccupationTB, "Occupation", errorProvider1))
                return;
            checkAttemp[3] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void motherfnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(motherfnameTB, "First Name", errorProvider1))
                return;
            checkAttemp[4] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void motherlnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(motherlnameTB, "Last Name", errorProvider1))
                return;
            checkAttemp[5] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void mothermnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(mothermnameTB, "Middle Name", errorProvider1))
                return;
            checkAttemp[6] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void motherEmailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Email(motherEmailTB, "Email", errorProvider1))
                return;
            checkAttemp[7] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void motherPhoneTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_PhoneNumber(motherPhoneTB, "Phone Number", errorProvider1))
                return;
            checkAttemp[8] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void motherOccupationTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(motherOccupationTB, "Occupation", errorProvider1))
                return;
            checkAttemp[9] = true;
            ErnployeesGlobalVariable.isNext = true;
        }
    
        public static void done()
        {
            for (int i = 0; i < checkAttemp.Length; i++)
            {
                if (checkAttemp[i] == false)
                {
                    ErnployeesGlobalVariable.isNext = false;
                }
            }

            ErnployeesGlobalVariable.isNext = true;
        }
    }
}
