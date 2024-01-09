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

namespace Student_Attendance_System.Forms.Admin
{
    public partial class addStaff : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        public addStaff()
        {
            InitializeComponent();
        }

        private void addStaff_Load(object sender, EventArgs e)
        {
            statusCB.SelectedIndex = 0;
            genderCB.SelectedIndex= 0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool checkValid()
        {
            if (validationHelper.textBoxValidation_Alpha(firstNameTB, "FIRST NAME", errorProvider1)
               && validationHelper.textBoxValidation_Alpha(surnameTB, "LAST NAME", errorProvider1)
               && validationHelper.textBoxValidation_Alpha(middleNameTB, "MIDDLE NAME", errorProvider1)
               && validationHelper.textBoxValidation_Email(emailTB, "EMAIL", errorProvider1)
               && validationHelper.textBoxValidation_Address(addressTB, "ADDRESS", errorProvider1)
               && validationHelper.textBoxValidation_PhoneNumber(phoneTB, "PHONE NUMBER", errorProvider1)
               && validationHelper.textBoxValidation_Numeric(ageTB, "AGE", errorProvider1, 2)
               && !String.IsNullOrEmpty(idNumTB.Text))
                   return true;
            return false;
        }

        public String name(){return $"{surnameTB.Text}, {firstNameTB.Text} {middleNameTB.Text}";}
        public String idNum() { return idNumTB.Text; }
        public String age() { return ageTB.Text; }
        public String email() { return emailTB.Text; }
        public String address() { return addressTB.Text; }
        public String phoneNum() { return phoneTB.Text; }
        public String status() { return statusCB.Text; }
        public String gender() { return genderCB.Text; }
        public String admin() 
        {
            if (isAdminCB.Checked)
                return "ADMIN";
            return "REGULAR";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!checkValid())
            {

                MessageForm msg = new MessageForm()
                {
                    header = "Wooops",
                    message = "Double check the input fields",
                    isYesNo = false,
                    messageType = "failed"
                };
                msg.ShowDialog();
                return;
            }

            try
            {
                if (databaseHelper.con.State != System.Data.ConnectionState.Open)
                    databaseHelper.open();
                string query = "INSERT INTO Accounts (Name, StaffID, Password, Age, Email, Address, Phone, Gender, Status, Admin) " +
                   "VALUES (@Name, @StaffID, @Password, @Age, @Email, @Address, @Phone, @Gender, @Status, @Admin)";

                databaseHelper db = new databaseHelper();
                using (db.cmd = new SqlCommand(query, databaseHelper.con))
                {
                    db.cmd.Parameters.AddWithValue("@Name", name());
                    db.cmd.Parameters.AddWithValue("@StaffID", idNum());
                    db.cmd.Parameters.AddWithValue("@Password", idNum());
                    db.cmd.Parameters.AddWithValue("@Age", age());
                    db.cmd.Parameters.AddWithValue("@Email", email());
                    db.cmd.Parameters.AddWithValue("@Address", address());
                    db.cmd.Parameters.AddWithValue("@Phone", phoneNum());
                    db.cmd.Parameters.AddWithValue("@Gender", gender());
                    db.cmd.Parameters.AddWithValue("@Status", status());
                    db.cmd.Parameters.AddWithValue("@Admin", admin());

                    db.cmd.ExecuteNonQuery();
                }
                successAdd();
                databaseHelper.con.Close();
            }
            catch (Exception ex)
            {
            }
        }

        void successAdd()
        {
            logsHelper.insertAddStaff($"Added a new staff: {surnameTB.Text.ToUpper()}, {firstNameTB.Text.ToUpper()} {middleNameTB.Text.ToUpper()}");
            firstNameTB.Text = "";
            middleNameTB.Text = "";
            surnameTB.Text = "";
            idNumTB.Text = "";
            ageTB.Text = "";
            emailTB.Text = "";
            addressTB.Text = "";
            phoneTB.Text = "";
            statusCB.SelectedIndex = 0;
            genderCB.SelectedIndex = 0;
            isAdminCB.Checked = false;

            MessageForm msg = new MessageForm()
            {
                header = "Woo hoo!!",
                message = "You've successfully added a staff.",
                isYesNo = false,
                messageType = "Success"
            };
            msg.ShowDialog();
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomDigits = random.Next(100000, 999999); // Generates a 6-digit random number
            String randomizedId = randomDigits.ToString();

            string query = $"SELECT Id FROM Accounts WHERE StaffID = {randomizedId}";

            if (databaseHelper.con.State != System.Data.ConnectionState.Open)
                databaseHelper.con.Open();

            databaseHelper db = new databaseHelper();

            using (db.cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataReader dr = db.cmd.ExecuteReader();
                if (dr.Read())
                {
                    randomizeBtn.PerformClick();
                    return;
                }
                dr.Close();
            }

            idNumTB.Text = randomizedId;
        }

        private void isAdminCB_Click(object sender, EventArgs e)
        {
        }

        private void firstNameTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Alpha(firstNameTB, "FIRST NAME", errorProvider1);
        }

        private void surnameTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Alpha(surnameTB, "LAST NAME", errorProvider1);
        }

        private void middleNameTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Alpha(middleNameTB, "MIDDLE NAME", errorProvider1);
        }

        private void ageTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Numeric(ageTB, "AGE", errorProvider1, 2);
        }

        private void emailTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Email(emailTB, "EMAIL", errorProvider1);
        }

        private void addressTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Address(addressTB, "ADDRESS", errorProvider1);
        }

        private void phoneTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_PhoneNumber(phoneTB, "PHONE NUMBER", errorProvider1);
        }
    }
}
