using Guna.UI2.WinForms;
using Student_Attendance_System.Classes.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        Size panelSz;
        Size formSz;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        internal loginHelper loginHelper
        {
            get => default;
            set
            {
            }
        }

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginLbl.Visible = false; 
            panelSz = mainPanel.Size;
            formSz = this.Size;
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
                loginBtn.Visible = false;
                cancelBtn.Visible = false;
                stayLoginCB.Visible = false;
            }
            else
            {
                checkLogin("You entered incorrect information", false);
            }
        }

        void checkLogin(String message, bool success)
        {
            isResize = true;
            if (success)
            {
                loginLbl.ForeColor = Color.Green;
                this.Size = new Size(formSz.Width, formSz.Height - loginLbl.Height);
                mainPanel.Size = new Size(panelSz.Width, panelSz.Height - loginLbl.Height);
                
            }
            else
            {
                loginLbl.ForeColor = Color.Red;
                if(!loginLbl.Visible)
                {
                    this.Size = new Size(formSz.Width, formSz.Height + (loginLbl.Height * 2));
                    mainPanel.Size = new Size(panelSz.Width, panelSz.Height + (loginLbl.Height * 2));
                }
                
            }

            loginLbl.Text = message;
            loginLbl.TextAlignment = ContentAlignment.MiddleCenter;
            loginLbl.Size = new Size(passwordTB.Width, loginLbl.Height);
            loginLbl.Visible = true;
            if (isResize)
                return;

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

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }
    }
}
