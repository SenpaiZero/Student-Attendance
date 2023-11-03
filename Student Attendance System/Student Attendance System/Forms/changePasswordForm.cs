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
    }
}
