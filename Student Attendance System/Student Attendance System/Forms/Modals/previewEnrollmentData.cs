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

namespace Student_Attendance_System.Forms.Modals
{
    public partial class previewEnrollmentData : Form
    {
        public previewEnrollmentData()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void previewEnrollmentData_Load(object sender, EventArgs e)
        {
            studentNameTB.Text = $"{EnrollmentGlobalVariable.lastName}, " +
                $"{EnrollmentGlobalVariable.firstName} " +
                $"{EnrollmentGlobalVariable.middleName}";

            addressTB.Text = EnrollmentGlobalVariable.address;
            studentEmailTB.Text = EnrollmentGlobalVariable.email;
            studentPhoneTB.Text = EnrollmentGlobalVariable.phone;
            bdayTB.Text = EnrollmentGlobalVariable.birthday;
            ageTB.Text = EnrollmentGlobalVariable.age;
            religionTB.Text = EnrollmentGlobalVariable.religion;
            genderTB.Text = EnrollmentGlobalVariable.gender;

            fatherNameTB.Text = $"{EnrollmentGlobalVariable.fatherlName}, " +
                $"{EnrollmentGlobalVariable.fatherfName} " +
                $"{EnrollmentGlobalVariable.fathermName}";

            motherNameTB.Text = $"{EnrollmentGlobalVariable.motherlName}, " +
                $"{EnrollmentGlobalVariable.motherfName} " +
                $"{EnrollmentGlobalVariable.mothermName}";

            fatherEmailTB.Text = EnrollmentGlobalVariable.fatherEmail;
            motherEmailTB.Text = EnrollmentGlobalVariable.motherEmail;

            fatherOccupationTB.Text = EnrollmentGlobalVariable.fatherOccupation;
            motherOcupationTB.Text = EnrollmentGlobalVariable.motherOccupation;

            fatherPhoneNumberTB.Text = EnrollmentGlobalVariable.fatherPhone;
            motherPhoneTB.Text = EnrollmentGlobalVariable.motherPhone;

            studentIDTB.Text = EnrollmentGlobalVariable.id;
            studentTypeTB.Text = "wala pa";
            sectionTB.Text = EnrollmentGlobalVariable.section;
            yearTB.Text = EnrollmentGlobalVariable.year;
            moreTB.Text = EnrollmentGlobalVariable.moreDetails;

            selfPic.Image = EnrollmentGlobalVariable.frame;
            qrPic.Image = EnrollmentGlobalVariable.QRCode;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
