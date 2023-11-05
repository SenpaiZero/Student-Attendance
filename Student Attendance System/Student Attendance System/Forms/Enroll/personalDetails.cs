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
    }
}
