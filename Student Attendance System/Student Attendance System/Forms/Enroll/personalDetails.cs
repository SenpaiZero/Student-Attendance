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
        public static bool[] checkAttemp = new bool[] { false, false, false, false, false, false, false};
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
            EnrollmentGlobalVariable.isNext = false;

            firstNameTB.Text = EnrollmentGlobalVariable.firstName;
            middleNameTB.Text = EnrollmentGlobalVariable.middleName;
            surnameTB.Text = EnrollmentGlobalVariable.lastName;
            emailTB.Text = EnrollmentGlobalVariable.email;

            if(!String.IsNullOrEmpty(EnrollmentGlobalVariable.birthday))
                birthdayDP.Value = DateTime.Parse(EnrollmentGlobalVariable.birthday);
            ageTB.Text = EnrollmentGlobalVariable.age;
            religionCB.Text = EnrollmentGlobalVariable.religion;
            genderCB.Text = EnrollmentGlobalVariable.gender;
            addressTB.Text = EnrollmentGlobalVariable.address;
            phoneNumberTB.Text = EnrollmentGlobalVariable.phone;

            if (String.IsNullOrEmpty(EnrollmentGlobalVariable.religion))
                religionCB.SelectedIndex = 0;
            if(String.IsNullOrEmpty(EnrollmentGlobalVariable.gender))
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
            EnrollmentGlobalVariable.firstName = firstNameTB.Text;
            EnrollmentGlobalVariable.middleName = middleNameTB.Text;
            EnrollmentGlobalVariable.lastName = surnameTB.Text;

            EnrollmentGlobalVariable.birthday = birthdayDP.Value.ToString();
            EnrollmentGlobalVariable.age = ageTB.Text;
            EnrollmentGlobalVariable.religion = religionCB.Text;
            EnrollmentGlobalVariable.gender = genderCB.Text;
            EnrollmentGlobalVariable.email = emailTB.Text;
            EnrollmentGlobalVariable.address = addressTB.Text;
            EnrollmentGlobalVariable.phone = phoneNumberTB.Text;
        }

        private void firstNameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(firstNameTB, "First Name", errorProvider1))
            {
                checkAttemp[0] = false;
                return;
            }
            checkAttemp[0] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void surnameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(surnameTB, "Last Name", errorProvider1))
                return;
            checkAttemp[1] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void middleNameTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Alpha(middleNameTB, "Middle Name", errorProvider1))
            {
                checkAttemp[2] = false;
                return;
            }
            checkAttemp[2] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Email(emailTB, "Email", errorProvider1))
            {
                checkAttemp[3] = false;
                return;
            }
            checkAttemp[3] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void addressTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_Address(addressTB, "Address", errorProvider1))
            {
                checkAttemp[4] = false;
                return;
            }
            checkAttemp[4] = true;
            EnrollmentGlobalVariable.isNext = true;
        }

        private void phoneNumberTB_Leave(object sender, EventArgs e)
        {
            if (!validationHelper.textBoxValidation_PhoneNumber(phoneNumberTB, "Phone Number", errorProvider1))
            {
                checkAttemp[5] = false;
                return;
            }
            checkAttemp[5] = true;
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
                EnrollmentGlobalVariable.isNext = true;
            }
        }

        private void birthdayDP_ValueChanged(object sender, EventArgs e)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - birthdayDP.Value.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (birthdayDP.Value.Date > today.AddYears(-age)) age--;
            if (age < 0)
                age = 0;

            ageTB.Text = age.ToString();
            checkAttemp[6] = true;
        }
    }
}
