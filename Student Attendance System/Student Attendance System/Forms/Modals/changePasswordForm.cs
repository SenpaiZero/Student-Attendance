using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Student_Attendance_System.Classes.Helper;

namespace Student_Attendance_System.Forms
{
    public partial class changePasswordForm : Form
    {
        public changePasswordForm()
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
        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!validationHelper.internetAvailability())
                return;

            MessageForm msg = new MessageForm()
            {
                messageType = "Failed",
                header = "Ooooops.",
                isYesNo = false
            };
            if (securityHelper.HashPassword(currentPassTB.Text) != securityHelper.HashPassword(loginHelper.Password))
            {
                msg.message = "Current password is incorrect.";
                msg.ShowDialog();
                return;
            }
            if(newPassTB.Text != reEnterPassTB.Text)
            {
                msg.message = "New password are not the same.";
                msg.ShowDialog();
                return;
            }

            try
            {
                databaseHelper.open();
                databaseHelper db = new databaseHelper();
                String query = "UPDATE Accounts SET Password = @password WHERE Name = @name";
                using (db.cmd = new SqlCommand(query, databaseHelper.con))
                {
                    db.cmd.Parameters.AddWithValue("@password", securityHelper.HashPassword(newPassTB.Text));
                    db.cmd.Parameters.AddWithValue("@name", loginHelper.Name);

                    db.cmd.ExecuteNonQuery();
                    if (Properties.Settings.Default.stayLogin)
                        Properties.Settings.Default.loginPassword = securityHelper.HashPassword(newPassTB.Text);
                    MessageForm msgf = new MessageForm()
                    {
                        messageType = "Success",
                        header = "Woo hoo!",
                        message = "You've successfully updated password",
                        isYesNo = false
                    };
                    msgf.ShowDialog();
                    this.Close();
                }
            } catch(Exception ex)
            {

            }
        }

        private void changePasswordForm_Load(object sender, EventArgs e)
        {
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void currentPassTB_IconRightClick(object sender, EventArgs e)
        {
            hidePassword(currentPassTB);
        }

        private void newPassTB_IconRightClick(object sender, EventArgs e)
        {
            hidePassword(newPassTB);
        }

        private void reEnterPassTB_IconRightClick(object sender, EventArgs e)
        {
            hidePassword(reEnterPassTB);
        }

        void hidePassword(Guna2TextBox passwordTB)
        {
            if (passwordTB.UseSystemPasswordChar)
            {
                passwordTB.IconRight = Properties.Resources.visible;
                passwordTB.PasswordChar = '\0';
                passwordTB.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTB.IconRight = Properties.Resources.hidden;
                passwordTB.PasswordChar = '●';
                passwordTB.UseSystemPasswordChar = true;
            }
        }

        private void reEnterPassTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                updateBtn.PerformClick();
            }
        }
    }
}
