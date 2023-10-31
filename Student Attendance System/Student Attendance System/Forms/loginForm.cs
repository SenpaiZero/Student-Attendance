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

namespace Student_Attendance_System.Startup
{
    public partial class loginForm : Form
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
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loadingForm load = new loadingForm()
            {
                title = "Please Wait",
                description = "Checking Credentials...",
                loadTime = 1500
            };
            load.ShowDialog();

            loginHelper login = new loginHelper()
            {
                Password = passwordTB.Text,
                staffID = staffIdTB.Text,
                stayLogin = stayLoginCB.Checked
            };

            if(login.login())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void passwordTB_IconRightClick(object sender, EventArgs e)
        {
            if(passwordTB.UseSystemPasswordChar)
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
