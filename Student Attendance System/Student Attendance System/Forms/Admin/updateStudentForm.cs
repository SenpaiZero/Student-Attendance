using Guna.UI2.WinForms;
using Student_Attendance_System.Classes.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Attendance_System.Forms.Admin
{
    public partial class updateStudentForm : Form
    {
        public updateStudentForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
        private void updateStudentForm_Load(object sender, EventArgs e)
        {
            buttonController(personalBtn);
            showData();
        }

        public void showData()
        {
            String query = "SELECT c.StudentID, c.Email, c.PhoneNumber, c.Address, " +
                "d.Name, d.Section, d.Year, d.StudentType, " +
                "f.Name, f.Email, f.PhoneNumber, f.Occupation," +
                "m.Name, m.Email, m.PhoneNumber, m.Occupation, " +
                "i.QRCode, i.Picture, " +
                "inf.Age, inf.Religion, inf.Gender, inf.MoreDetails, inf.Birthday " +
                "FROM studentContacts c " +
                "JOIN studentData d ON c.StudentID = d.StudentID " +
                "JOIN studentFather f ON c.StudentID = f.StudentID " +
                "JOIN studentMother m ON c.StudentID = m.StudentID " +
                "JOIN studentIdentity i ON c.StudentID = i.StudentID " +
                "JOIN studentInformation inf ON c.StudentID = inf.StudentID " +
                "WHERE c.StudentID = @id";

            if (databaseHelper.con.State != ConnectionState.Open)
                databaseHelper.open();
            databaseHelper db = new databaseHelper();

            using (db.cmd = new System.Data.SqlClient.SqlCommand(query, databaseHelper.con))
            {
                db.cmd.Parameters.AddWithValue("id", studentID);
                db.dr = db.cmd.ExecuteReader();
                if(db.dr.Read())
                {
                    studentID = db.dr.GetString(0);
                    email = db.dr.GetString(1);
                    phone = db.dr.GetString(2);
                    address= db.dr.GetString(3);
                    name= db.dr.GetString(4);
                    section = db.dr.GetString(5);
                    year = db.dr.GetString(6);
                    studentType= db.dr.GetString(7);
                    fatherName = db.dr.GetString(8);
                    fatherEmail= db.dr.GetString(9);
                    fatherPhone= db.dr.GetString(10);
                    fatherOccupation= db.dr.GetString(11);
                    motherName= db.dr.GetString(12);
                    motherEmail= db.dr.GetString(13);
                    motherPhone= db.dr.GetString(14);
                    motherOccupation= db.dr.GetString(15);
                    qrCode = ConvertToImage((byte[])db.dr.GetValue(16));
                    studentPicture = ConvertToImage((byte[])db.dr.GetValue(17));
                    age = db.dr.GetString(18);
                    religion = db.dr.GetString(19);
                    gender= db.dr.GetString(20);
                    moreDetails= db.dr.GetString(21);
                    birthday = db.dr.GetDateTime(22);
                    
                    db.dr.Close();
                }
            }

            idTB.Text = studentID;
            emailTB.Text = email;
            phoneNumberTB.Text = phone;
            addressTB.Text = address;
            nameTB.Text = name;
            sectionTB.Text = section;
            yearCB.Text = year;
            studentTypeCB.Text = studentType;
            fathernameTB.Text = fatherName;
            fatherEmailTB.Text = fatherEmail;
            fatherPhoneNumberTB.Text = fatherPhone;
            fatherOccupationTB.Text = fatherOccupation;
            mothernameTB.Text = motherName;
            motherEmailTB.Text = motherEmail;
            motherPhoneTB.Text = motherPhone;
            motherOccupationTB.Text = motherOccupation;
            qrCodePic.Image = qrCode;
            pic.Image = studentPicture;
            ageTB.Text = age;
            religionCB.Text = religion;
            genderCB.Text = gender;
            moreDetailTB.Text = moreDetails;
            birthdayDP.Value = birthday.Date;

        }

        void buttonController(Guna2Button btn)
        {
            personalBtn.Enabled = true;
            guardianBtn.Enabled = true;
            moreBtn.Enabled = true;

            btn.Enabled = false;
        }

        private void personalBtn_Click(object sender, EventArgs e)
        {
            buttonController(personalBtn);
            personalContainer.BringToFront();
            guna2Panel1.BringToFront();
        }

        private void guardianBtn_Click(object sender, EventArgs e)
        {
            buttonController(guardianBtn);
            guardianContainer.BringToFront();
            guna2Panel1.BringToFront();
        }

        private void moreBtn_Click(object sender, EventArgs e)
        {
            buttonController(moreBtn);
            moreDetailsContainer.BringToFront();
            guna2Panel1.BringToFront();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Bitmap ConvertToImage(byte[] binary)
        {
            if (binary == null || binary.Length == 0)
            {
                // Return a default image or handle the null case as needed
                return new Bitmap(1, 1);
            }

            using (MemoryStream stream = new MemoryStream(binary))
            {
                Bitmap image = new Bitmap(stream);
                return image;
            }
        }

        // Personal Details
        String name { get; set; }
        DateTime birthday { get; set; }
        String age { get; set; }
        String religion { get; set; }
        String gender { get; set; }
        String email { get; set; }
        String phone { get; set; }
        String address { get; set; }

        // More Details
        public String studentID { get; set; }
        String section { get; set; }
        String year { get; set; }
        String studentType { get; set; }
        Bitmap studentPicture { get; set; }
        Bitmap qrCode { get; set; }
        String moreDetails { get; set; }

        // Guardian Details

        String fatherName { get; set; }
        String fatherEmail { get; set; }
        String fatherPhone { get; set; }
        String fatherOccupation { get; set; }
        String motherName { get; set; }
        String motherEmail { get; set; }
        String motherPhone { get; set; }
        String motherOccupation { get; set; }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            checkChange(nameTB, name, nameLbl);
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            checkChange(emailTB, email, emailLbl);
        }

        private void birthdayDP_Leave(object sender, EventArgs e)
        {
            checkChange(birthdayDP, birthday.ToString(), birthdayLbl);
            checkChange(ageTB, age, ageLbl);
        }

        private void religionCB_Leave(object sender, EventArgs e)
        {
            checkChange(religionCB, religion, religionLbl);
        }

        private void genderCB_Leave(object sender, EventArgs e)
        {
            checkChange(genderCB, gender, genderLbl);
        }

        private void addressTB_Leave(object sender, EventArgs e)
        {
            checkChange(addressTB, address, addressLbl);
        }

        private void phoneNumberTB_Leave(object sender, EventArgs e)
        {
            checkChange(phoneNumberTB, phone, phoneNumberLbl);
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void sectionTB_Leave(object sender, EventArgs e)
        {
            checkChange(sectionTB, section, sectionlbl);
        }

        private void yearCB_Leave(object sender, EventArgs e)
        {
            checkChange(yearCB, year, yearLbl);
        }

        private void studentTypeCB_Leave(object sender, EventArgs e)
        {
            checkChange(studentTypeCB, studentType, studentTypeLbl);
        }

        private void moreDetailTB_Leave(object sender, EventArgs e)
        {
            checkChange(moreDetailTB, moreDetails, moreDetailsLbl);
        }

        private void fathernameTB_Leave(object sender, EventArgs e)
        {
            checkChange(fathernameTB, fatherName, fatherNameLbl);
        }

        private void fatherEmailTB_Leave(object sender, EventArgs e)
        {
            checkChange(fatherEmailTB, fatherEmail, fatherEmailLbl);
        }

        private void fatherPhoneNumberTB_Leave(object sender, EventArgs e)
        {
            checkChange(fatherPhoneNumberTB, fatherPhone, fatherPhoneLbl);
        }

        private void fatherOccupationTB_Leave(object sender, EventArgs e)
        {
            checkChange(fatherOccupationTB, fatherOccupation, fatherOccupationLbl);
        }

        private void mothernameTB_Leave(object sender, EventArgs e)
        {
            checkChange(mothernameTB, motherName, motherNameLbl);
        }

        private void motherEmailTB_Leave(object sender, EventArgs e)
        {
            checkChange(motherEmailTB, motherEmail, motherEmailLbl);
        }

        private void motherPhoneTB_Leave(object sender, EventArgs e)
        {
            checkChange(motherPhoneTB, motherPhone, motherPhoneLbl);
        }

        private void motherOccupationTB_Leave(object sender, EventArgs e)
        {
            checkChange(motherOccupationTB, motherOccupation, motherOccupationLbl);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!checkValid()) return;

            try
            {
                databaseHelper.open();
                databaseHelper db = new databaseHelper();
                String query = "";

                using (SqlTransaction trans = databaseHelper.con.BeginTransaction())
                {
                    try
                    {
                        using (db.cmd = databaseHelper.con.CreateCommand())
                        {
                            db.cmd.Transaction = trans;
                            //studentContacts
                            updateData(emailTB, "Email", "studentContacts", db.cmd);
                            updateData(phoneNumberTB, "PhoneNumber", "studentContacts", db.cmd);
                            updateData(addressTB, "Address", "studentContacts", db.cmd);

                            //studentData
                            updateData(nameTB, "Name", "studentData", db.cmd);
                            updateData(sectionTB, "Section", "studentData", db.cmd);
                            updateData(yearCB, "Year", "studentData", db.cmd);
                            updateData(studentTypeCB, "StudentType", "studentData", db.cmd);

                            //studentFather
                            updateData(fathernameTB, "Name", "studentFather", db.cmd);
                            updateData(fatherEmailTB, "Email", "studentFather", db.cmd);
                            updateData(fatherPhoneNumberTB, "PhoneNumber", "studentFather", db.cmd);
                            updateData(fatherOccupationTB, "Occupation", "studentFather", db.cmd);

                            //studentMother
                            updateData(mothernameTB, "Name", "studentMother", db.cmd);
                            updateData(motherEmailTB, "Email", "studentMother", db.cmd);
                            updateData(motherPhoneTB, "PhoneNumber", "studentMother", db.cmd);
                            updateData(motherOccupationTB, "Occupation", "studentMother", db.cmd);

                            //identity
                            //soon ewna pa kung changeable
                            //studentInformation
                            updateData(ageTB, "Age", "studentInformation", db.cmd);
                            updateData(religionCB, "Religion", "studentInformation", db.cmd);
                            updateData(genderCB, "Gender", "studentInformation", db.cmd);
                            updateData(moreDetailTB, "MoreDetails", "studentInformation", db.cmd);

                            db.cmd.CommandText = $"UPDATE studentInformation SET Birthday = @bday WHERE StudentID = '{studentID}'";
                            db.cmd.Parameters.AddWithValue("bday", SqlDbType.Date).Value = birthdayDP.Value.Date;
                            db.cmd.ExecuteNonQuery();

                            trans.Commit();

                            logsHelper.insertUpdateStudent($"Has updated {nameTB.Text.ToUpper()}'s data");
                            MessageForm msg = new MessageForm()
                            {
                                messageType = "Success",
                                header = "Woo hoo!!",
                                message = "You've successfully udpated data",
                                isYesNo = false
                            };
                            msg.ShowDialog();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ee)
            {
                throw;
            }

        }
        void checkChange(Control tb, String compare, Guna2HtmlLabel label)
        {
            // if it changed
            if (tb.Text != compare)
                label.ForeColor = Color.Green;
            else
                label.ForeColor = Color.FromArgb(243, 159, 90);

            if(tb is Guna2DateTimePicker)
            {
                DateTime bdayCompare = Convert.ToDateTime(compare);
                Guna2DateTimePicker bday = (Guna2DateTimePicker)tb;
                if (bday.Value.Date != bdayCompare.Date)
                    label.ForeColor = Color.Green;
                else
                    label.ForeColor = Color.FromArgb(243, 159, 90);
            }
        }
        bool checkValid()
        {
            if (validationHelper.textBoxValidation_Alpha_comma(nameTB, "NAME", errorProvider1)
               && validationHelper.textBoxValidation_Address(addressTB, "ADDRESS", errorProvider1)
               && validationHelper.textBoxValidation_Email(emailTB, "EMAIL", errorProvider1)
               && validationHelper.textBoxValidation_PhoneNumber(phoneNumberTB, "PHONE NUMBER", errorProvider1)
               && validationHelper.textBoxValidation_Alpha(sectionTB, "SECTION", errorProvider1)
               && validationHelper.textBoxValidation_Alpha(moreDetailTB, "MORE DETAILS", errorProvider1)
               && validationHelper.textBoxValidation_Alpha_comma(fathernameTB, "NAME", errorProvider1)
               && validationHelper.textBoxValidation_PhoneNumber(fatherPhoneNumberTB, "PHONE NUMBER", errorProvider1)
               && validationHelper.textBoxValidation_Email(fatherEmailTB, "EMAIL", errorProvider1)
               && validationHelper.textBoxValidation_Alpha(fatherOccupationTB, "OCCUPATION", errorProvider1)
               && validationHelper.textBoxValidation_Alpha_comma(mothernameTB, "NAME", errorProvider1)
               && validationHelper.textBoxValidation_PhoneNumber(motherPhoneTB, "PHONE NUMBER", errorProvider1)
               && validationHelper.textBoxValidation_Email(motherEmailTB, "EMAIL", errorProvider1)
               && validationHelper.textBoxValidation_Alpha(motherOccupationTB, "OCCUPATION", errorProvider1))
            {
                return true;
            }

            return false;
        }
        void updateData(Control tb, string column, string table, SqlCommand cmd)
        {
            if (!string.IsNullOrWhiteSpace(tb.Text))
            {
                cmd.CommandText = $"UPDATE {table} SET {column} = @{table}_{column} WHERE StudentID = '{studentID}'";
                cmd.Parameters.AddWithValue("@" + table+ "_" + column, tb.Text);

                cmd.ExecuteNonQuery();
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
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
