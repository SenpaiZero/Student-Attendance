using Guna.UI2.WinForms;
using Student_Attendance_System.Forms;
using Student_Attendance_System.Forms.Startup;
using Student_Attendance_System.Startup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public partial class startupForm : Form
    {
        bool menuExpand = true;
        Size defaultMenuSize, defaultMainPanelSize;
        Point defaultSidePanelBtnLoc, defaultLblX;
        protected override CreateParams CreateParams
        {
            get
            {  
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        public startupForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void startupForm_Load(object sender, EventArgs e)
        {
            defaultMenuSize = menuContainer.Size;
            defaultSidePanelBtnLoc = sidepanelBtn.Location;
            defaultLblX = adminLine.Location;
            defaultMainPanelSize = mainPanelContainer.Size;

            setLabels();
            startupRunClass.runStartup();

            timer1.Start();

            if(startupRunClass.persistentLogin())
                loginBtn.Text = loginHelper.Name;
        }

        void setTitlePos(Control ctrl)
        {
            ctrl.Location = new Point(12, ctrl.Location.Y);
        }
        void setTitlePosBack(Control ctrl)
        {
            ctrl.Location = new Point(defaultLblX.X, ctrl.Location.Y);
        }
        void setLabels()
        {
            adminBtn.Text = "ADMIN";
            attBtn.Text = "ATTENDANCE";
            settingBtn.Text = "SETTING";
            dashboardBtn.Text = "DASHBOARD";
            recordBtn.Text = "RECORDS";
            enrollBtn.Text = "ENROLL";

            dayLbl.Text = DateTime.Now.DayOfWeek.ToString() + " ";
            dateLbl.Text = DateTime.Now.ToShortDateString();
            versionLbl.Text = Config.appVersion;
        }
        private void sidepanelBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.SuspendLayout();
            }

            if (menuExpand)
            {
                adminLine.Visible = false;
                studentLine.Visible = false;
                miscLine.Visible = false;

                setTitlePos(adminLbl);
                setTitlePos(studentLbl);
                setTitlePos(miscLbl);

                appNameLbl.Text = "";
                appNameLbl.Image = Properties.Resources.logo;
                appNameLbl.ImageAlign = HorizontalAlignment.Left;
                setTitlePos(appNameLbl);

                dayLbl.Text = "";
                dateLbl.Text = "";
                adminBtn.Text = "";
                attBtn.Text = "";
                settingBtn.Text = "";
                recordBtn.Text = "";
                dashboardBtn.Text = "";
                versionLbl.Text = "";
                enrollBtn.Text = "";
                dayLbl.Visible = false;

                menuExpand = false;
                sidepanelBtn.Image = Properties.Resources.right_arrow;
                menuContainer.Size = new Size(86, menuContainer.Size.Height);
            }
            else
            {
                adminLine.Visible = true;
                studentLine.Visible = true;
                miscLine.Visible = true;

                setTitlePosBack(studentLbl);
                setTitlePosBack(adminLbl);
                setTitlePosBack(miscLbl);

                appNameLbl.Text = "AttendTrackPro";
                appNameLbl.Image = null;
                setTitlePosBack(appNameLbl);

                menuExpand = true;
                sidepanelBtn.Image = Properties.Resources.left_arrow;
                menuContainer.Size = defaultMenuSize;

                dayLbl.Visible = true;
                setLabels();
            }
            foreach (Form form in Application.OpenForms)
            {
                form.ResumeLayout();
            }
        }

        private void sidepanelBtn_MouseHover(object sender, EventArgs e)
        {
            sidepanelBtn.ImageSize = new Size(23, 23);
        }

        private void attBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadForm(new studentForm(), mainPanel);
            enebleBtn(attBtn);
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {

            if (!checkAdmin()) return;

            pageHelper.loadForm(new adminForm(), mainPanel);
            enebleBtn(adminBtn);
        }

        private void sidepanelBtn_MouseLeave(object sender, EventArgs e)
        {

            sidepanelBtn.ImageSize = new Size(20, 20);
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {

            if (!checkAdmin()) return;

            pageHelper.loadForm(new enrollForm(), mainPanel);
            enebleBtn(enrollBtn);
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!validationHelper.internetAvailability())
                return;
            if (loginBtn.Text == "LOGIN")
            {
                loginForm login = new loginForm();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    loginBtn.Text = loginHelper.Name;
                }
            }
            else
            {
                Point ptLowerLeft = new Point(0,loginBtn.Height);
                ptLowerLeft = loginBtn.PointToScreen(ptLowerLeft);

                accountMenuStrip.Show(ptLowerLeft);
            }
            
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginHelper login = new loginHelper();
            login.logout();

            if(loginHelper.Name == "LOGIN")
            {
                loginBtn.Text = "LOGIN";
                pageHelper.loadForm(new blank(), mainPanel);
                enebleBtn(null);
            }
        }

        private void startupForm_Shown(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                startupRunClass.checkInternet(this);
            });
        }

        private void startupForm_Activated(object sender, EventArgs e)
        {
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePasswordForm changePass = new changePasswordForm();
            changePass.ShowDialog();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            if (!checkAdmin()) return;

            pageHelper.loadForm(new recordForm(), mainPanel);
            enebleBtn(recordBtn);
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadForm(new settingForm(), mainPanel);
            enebleBtn(settingBtn);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (!checkAdmin()) return;

            pageHelper.loadForm(new Dashboard_Form(), mainPanel);
            enebleBtn(dashboardBtn);
        }

        private void versionLbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dayLbl.Text = $"{DateTime.Now.DayOfWeek} {DateTime.Now.ToString(" hh:mm tt")}";
        }

        bool checkAdmin()
        {
            if (!loginHelper.isLogin)
            {
                MessageForm msg = new MessageForm()
                {
                    header = "Oooops!!",
                    message = "Please login first.",
                    messageType = "Failed",
                    isYesNo = false,

                };
                msg.ShowDialog();
                return false;
            }
            return true;
        }
        void enebleBtn(Guna2Button disabledBtn)
        {
            enrollBtn.Enabled = true;
            adminBtn.Enabled = true;
            attBtn.Enabled = true;
            settingBtn.Enabled = true;
            recordBtn.Enabled = true;
            dashboardBtn.Enabled = true;

            if(disabledBtn != null)
                disabledBtn.Enabled = false;
        }

    }
}
