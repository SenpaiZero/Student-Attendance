using Student_Attendance_System.Classes;
using Student_Attendance_System.Classes.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        internal databaseHelper databaseHelper
        {
            get => default;
            set
            {
            }
        }

        internal LocalSaveHelper LocalSaveHelper
        {
            get => default;
            set
            {
            }
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
            studentTypeTB.Text = EnrollmentGlobalVariable.studentType;
            sectionTB.Text = EnrollmentGlobalVariable.section;
            yearTB.Text = EnrollmentGlobalVariable.year;
            moreTB.Text = EnrollmentGlobalVariable.moreDetails;

            selfPic.Image = EnrollmentGlobalVariable.frame;
            qrPic.Image = EnrollmentGlobalVariable.QRCode;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (databaseHelper.con.State != System.Data.ConnectionState.Open)
                    databaseHelper.open();
                databaseHelper db = new databaseHelper();
                String query = "INSERT INTO studentContacts (StudentID, Email, PhoneNumber, Address) VALUES (@studentID, @Email, @PhoneNumber, @Address); " +
               "INSERT INTO studentData (StudentID, Name, Section, Year, StudentType, EnrollDate) VALUES (@StudentID, @Name, @Section, @Year, @StudentType, @EnrollDate); " +
               "INSERT INTO studentFather (StudentID, Name, Email, PhoneNumber, Occupation) VALUES (@StudentID, @fatherName, @fatherEmail, @fatherPhoneNumber, @fatherOccupation); " +
               "INSERT INTO studentMother (StudentID, Name, Email, PhoneNumber, Occupation) VALUES (@StudentID, @motherName, @motherEmail, @motherPhoneNumber, @motherOccupation); " +
               "INSERT INTO studentIdentity (StudentID, QRCode, Picture) VALUES (@StudentID, @qrcode, @picture); " +
               "INSERT INTO studentInformation (StudentID, Age, Religion, Gender, MoreDetails, Birthday) VALUES (@StudentID, @age, @religion, @gender, @moreDetails, @birthday)";

                using (db.cmd = new SqlCommand(query, databaseHelper.con))
                {
                    db.cmd.Parameters.AddWithValue("StudentID", EnrollmentGlobalVariable.id);
                    db.cmd.Parameters.AddWithValue("Email", EnrollmentGlobalVariable.email);
                    db.cmd.Parameters.AddWithValue("PhoneNumber", EnrollmentGlobalVariable.phone);
                    db.cmd.Parameters.AddWithValue("Address", EnrollmentGlobalVariable.address);
                    db.cmd.Parameters.AddWithValue("Name", $"{EnrollmentGlobalVariable.lastName}, " +
                        $"{EnrollmentGlobalVariable.firstName} {EnrollmentGlobalVariable.middleName}");
                    db.cmd.Parameters.AddWithValue("Section", EnrollmentGlobalVariable.section);
                    db.cmd.Parameters.AddWithValue("Year", EnrollmentGlobalVariable.year);
                    db.cmd.Parameters.AddWithValue("StudentType", EnrollmentGlobalVariable.studentType);
                    db.cmd.Parameters.AddWithValue("fatherName", $"{EnrollmentGlobalVariable.fatherlName}, " +
                        $"{EnrollmentGlobalVariable.fatherlName} {EnrollmentGlobalVariable.fathermName}");
                    db.cmd.Parameters.AddWithValue("fatherEmail", EnrollmentGlobalVariable.fatherEmail);
                    db.cmd.Parameters.AddWithValue("fatherPhoneNumber", EnrollmentGlobalVariable.fatherPhone);
                    db.cmd.Parameters.AddWithValue("fatherOccupation", EnrollmentGlobalVariable.fatherOccupation);
                    db.cmd.Parameters.AddWithValue("motherName", $"{EnrollmentGlobalVariable.motherlName}, " +
                        $"{EnrollmentGlobalVariable.motherfName} {EnrollmentGlobalVariable.mothermName}");
                    db.cmd.Parameters.AddWithValue("motherEmail", EnrollmentGlobalVariable.motherEmail);
                    db.cmd.Parameters.AddWithValue("motherPhoneNumber", EnrollmentGlobalVariable.motherPhone);
                    db.cmd.Parameters.AddWithValue("motherOccupation", EnrollmentGlobalVariable.motherOccupation);
                    db.cmd.Parameters.AddWithValue("qrcode", databaseHelper.bitmapToVarBinary(EnrollmentGlobalVariable.QRCode));
                    db.cmd.Parameters.AddWithValue("picture", databaseHelper.bitmapToVarBinary(EnrollmentGlobalVariable.frame));
                    db.cmd.Parameters.AddWithValue("age", EnrollmentGlobalVariable.age);
                    db.cmd.Parameters.AddWithValue("religion", EnrollmentGlobalVariable.religion);
                    db.cmd.Parameters.AddWithValue("gender", EnrollmentGlobalVariable.gender);
                    db.cmd.Parameters.AddWithValue("moreDetails", EnrollmentGlobalVariable.moreDetails);
                    db.cmd.Parameters.AddWithValue("EnrollDate", DateTime.Now.Date);
                    db.cmd.Parameters.AddWithValue("birthday", SqlDbType.Date).Value = EnrollmentGlobalVariable.birthday;
                    db.cmd.ExecuteNonQuery();
                    logsHelper.insertNewEnroll($"Has enrolled a student: {EnrollmentGlobalVariable.lastName.ToUpper()}, " +
                        $"{EnrollmentGlobalVariable.firstName.ToUpper()} {EnrollmentGlobalVariable.middleName.ToUpper()}");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LocalSaveHelper.saveQRCode(EnrollmentGlobalVariable.QRCode, EnrollmentGlobalVariable.id);
            LocalSaveHelper.savePicture(EnrollmentGlobalVariable.frame, EnrollmentGlobalVariable.id);
            this.DialogResult = DialogResult.OK;

            EnrollmentGlobalVariable.defaultData();
            this.Close();
        }
    }
}
