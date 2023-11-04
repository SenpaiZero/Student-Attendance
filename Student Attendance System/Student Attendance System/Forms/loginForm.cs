using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Student_Attendance_System.Startup
{
    public partial class loginForm : Form
    {
        bool isResize = false;
        Stopwatch stopwatch = new Stopwatch();
        Stopwatch countdown = new Stopwatch();
        int countdownInt = 5;
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
            loginLbl.Visible = false;
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
                staffID = staffIdTB.Text,
                stayLogin = stayLoginCB.Checked
            };
            loginHelper.Password = passwordTB.Text;

            if (login.login())
            {
                checkLogin($"LOGIN SUCCESSFUL\nWINDOW WILL CLOSE IN {countdownInt}", true);
                timer1.Start();
                stopwatch.Start();
                countdown.Start();
            }
            else
            {
                checkLogin("You entered incorrect information", false);
            }
        }

        void checkLogin(String message, bool success)
        {
            if (success)
                loginLbl.ForeColor = Color.Green;
            else
                loginLbl.ForeColor = Color.Red;

            loginLbl.Text = message;
            loginLbl.TextAlignment = ContentAlignment.MiddleCenter;
            loginLbl.Size = new Size(passwordTB.Width, loginLbl.Height);
            loginLbl.Visible = true;
            if (isResize)
                return;

            isResize = true;
            this.Size = new Size(this.Width, this.Height + loginLbl.Height);
            mainPanel.Size = new Size(mainPanel.Width, mainPanel.Height + loginLbl.Height);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(countdown.ElapsedMilliseconds >= 1000)
            {
                countdownInt--;
                countdown.Restart();
                loginLbl.Text = $"LOGIN SUCCESSFUL\nWINDOW WILL CLOSE IN {countdownInt}";
            }
            if(stopwatch.ElapsedMilliseconds >= 5000) //milisecond to close
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
