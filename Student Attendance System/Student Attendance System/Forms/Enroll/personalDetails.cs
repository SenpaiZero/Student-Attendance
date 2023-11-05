using Student_Attendance_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Enroll
{
    public partial class personalDetails : Form
    {
        public static bool[] checkAttemp = new bool[] { false, false, false, false, false, false};
    public personalDetails()
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

        private void personalDetails_Load(object sender, EventArgs e)
        {
            ErnployeesGlobalVariable.isNext = false;

            firstNameTB.Text = ErnployeesGlobalVariable.firstName;
            middleNameTB.Text = ErnployeesGlobalVariable.middleName;
            surnameTB.Text = ErnployeesGlobalVariable.lastName;
            emailTB.Text = ErnployeesGlobalVariable.email;

            if(!String.IsNullOrEmpty(ErnployeesGlobalVariable.birthday))
                birthdayDP.Value = DateTime.Parse(ErnployeesGlobalVariable.birthday);
            ageTB.Text = ErnployeesGlobalVariable.age;
            religionCB.Text = ErnployeesGlobalVariable.religion;
            genderCB.Text = ErnployeesGlobalVariable.gender;
            addressTB.Text = ErnployeesGlobalVariable.address;
            phoneNumberTB.Text = ErnployeesGlobalVariable.phone;

            if (String.IsNullOrEmpty(ErnployeesGlobalVariable.religion))
                religionCB.SelectedIndex = 0;
            if(String.IsNullOrEmpty(ErnployeesGlobalVariable.gender))
                genderCB.SelectedIndex = 0;
        }

        private void personalDetails_Resize(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
        }

        private void personalDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            ErnployeesGlobalVariable.firstName = firstNameTB.Text;
            ErnployeesGlobalVariable.middleName = middleNameTB.Text;
            ErnployeesGlobalVariable.lastName = surnameTB.Text;

            ErnployeesGlobalVariable.birthday = birthdayDP.Value.ToString();
            ErnployeesGlobalVariable.age = ageTB.Text;
            ErnployeesGlobalVariable.religion = religionCB.Text;
            ErnployeesGlobalVariable.gender = genderCB.Text;
            ErnployeesGlobalVariable.email = emailTB.Text;
            ErnployeesGlobalVariable.address = addressTB.Text;
            ErnployeesGlobalVariable.phone = phoneNumberTB.Text;
        }

        private void firstNameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(firstNameTB, "First Name", errorProvider1))
                return;
            checkAttemp[0] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void surnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(surnameTB, "Last Name", errorProvider1))
                return;
            checkAttemp[1] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void middleNameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(middleNameTB, "Middle Name", errorProvider1))
                return;
            checkAttemp[2] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Email(emailTB, "Email", errorProvider1))
                return;
            
            checkAttemp[3] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void addressTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Address(addressTB, "Address", errorProvider1))
                return;
            checkAttemp[4] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        private void phoneNumberTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_PhoneNumber(phoneNumberTB, "Phone Number", errorProvider1))
                return;

            checkAttemp[5] = true;
            ErnployeesGlobalVariable.isNext = true;
        }

        public static void done()
        {
            for (int i = 0; i < checkAttemp.Length; i++)
            {
                if (checkAttemp[i] == false)
                {
                    ErnployeesGlobalVariable.isNext = false;
                    return;
                }
                ErnployeesGlobalVariable.isNext = true;
            }
        }
    }
}
