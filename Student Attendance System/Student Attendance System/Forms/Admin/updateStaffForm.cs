using Guna.UI2.WinForms;
using Student_Attendance_System.Classes.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Admin
{
    public partial class updateStaffForm : Form
    {
        public string staffId;
        private string name, phone, email, address, age, status, gender, admin;

        private void emailTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Email(emailTB, "EMAIL", errorProvider1);
            checkChange(emailTB, email, emailLbl);
        }

        private void ageTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Numeric(ageTB, "AGE", errorProvider1, 2);
            checkChange(ageTB, age, ageLbl);
        }

        private void phoneTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_PhoneNumber(phoneTB, "PHONE NUMBER", errorProvider1);
            checkChange(phoneTB, phone, phoneLbl);
        }

        private void statusCB_Leave(object sender, EventArgs e)
        {
            checkChange(statusCB, status, statusLbl);
        }

        private void genderCB_Leave(object sender, EventArgs e)
        {
            checkChange(genderCB, gender, genderLbl);
        }

        private void isAdminCB_Click(object sender, EventArgs e)
        {
            String temp;
            if (isAdminCB.Checked == true)
                temp = "ADMIN";
            else
                temp = "REGULAR";

            if(temp != admin)
                adminLbl.ForeColor = Color.Green;
            else
                adminLbl.ForeColor = Color.FromArgb(243, 159, 90);
        }

        private void addressTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Address(addressTB, "ADDRESS", errorProvider1);
            checkChange(addressTB, address, addressLbl);
        }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            validationHelper.textBoxValidation_Alpha_comma(nameTB, "NAME", errorProvider1);
            checkChange(nameTB, name, nameLbl);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!checkValid())
            {
                MessageForm msg = new MessageForm()
                {
                    isYesNo = false,
                    messageType = "Failed",
                    header = "Woooops",
                    message = $"Please check the input fields."
                };
                msg.ShowDialog();
                return;
            }

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
                            updateData(nameTB, "Name", db.cmd);
                            updateData(ageTB, "Age", db.cmd);
                            updateData(emailTB, "Email", db.cmd);
                            updateData(addressTB, "Address", db.cmd);
                            updateData(phoneTB, "Phone", db.cmd);
                            updateData(genderCB, "Gender", db.cmd);
                            updateData(statusCB, "Status", db.cmd);

                            if (isAdminCB.Checked)
                                db.cmd.CommandText = $"UPDATE Accounts SET Admin = 'ADMIN' WHERE  StaffID = '{staffId}'";
                            else
                                db.cmd.CommandText = $"UPDATE Accounts SET Admin = 'REGULAR' WHERE  StaffID = '{staffId}'";
                            db.cmd.ExecuteNonQuery();

                            trans.Commit();
                            logsHelper.insertUpdateStaff($"Updated {name}'s data");
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
                    catch(Exception ex)
                    {
                        trans.Rollback();
                    }
                }
            }
            catch(Exception ee)
            {

            }
        }
        void updateData(Control tb, string column, SqlCommand cmd)
        {
            if (!string.IsNullOrWhiteSpace(tb.Text))
            {
                cmd.CommandText = $"UPDATE Accounts SET {column} = @{column} WHERE StaffID = '{staffId}'";
                cmd.Parameters.AddWithValue("@" + column, tb.Text);

                cmd.ExecuteNonQuery();
            }
        }
        void checkChange(Control tb, String compare, Guna2HtmlLabel label)
        {
            // if it changed
            if (tb.Text != compare)
                label.ForeColor = Color.Green;
            else
                label.ForeColor = Color.FromArgb(243, 159, 90);
        }
        bool checkValid()
        {
            if (validationHelper.textBoxValidation_Alpha_comma(nameTB, "NAME", errorProvider1)
               && validationHelper.textBoxValidation_Email(emailTB, "EMAIL", errorProvider1)
               && validationHelper.textBoxValidation_Address(addressTB, "ADDRESS", errorProvider1)
               && validationHelper.textBoxValidation_PhoneNumber(phoneTB, "PHONE NUMBER", errorProvider1)
               && validationHelper.textBoxValidation_Numeric(ageTB, "AGE", errorProvider1, 2))
            {
                return true;
            }

            return false;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public updateStaffForm()
        {
            InitializeComponent();
        }

        private void updateStaffForm_Load(object sender, EventArgs e)
        {
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query = "SELECT * FROM Accounts WHERE StaffID = '" + staffId + "';";
            using (db.cmd = new SqlCommand(query, databaseHelper.con))
            {
                using (db.dr = db.cmd.ExecuteReader())
                {
                    while(db.dr.Read())
                    {
                        name = db.dr.GetString(1);
                        age = db.dr.GetString(4);
                        email = db.dr.GetString(5);
                        address = db.dr.GetString(6);
                        phone = db.dr.GetString(7);
                        gender = db.dr.GetString(8);
                        status = db.dr.GetString(9);
                        admin = db.dr.GetString(10);
                    }
                }
            }

            nameTB.Text = name;
            ageTB.Text = age;
            emailTB.Text = email;
            addressTB.Text = address;
            phoneTB.Text = phone;
            genderCB.Text = gender;
            statusCB.Text = status;
            if(admin == "ADMIN")
                isAdminCB.Checked = true;
            else
                isAdminCB.Checked = false;
        }
    }
}
