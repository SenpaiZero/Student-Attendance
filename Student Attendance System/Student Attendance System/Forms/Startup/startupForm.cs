using Guna.UI2.WinForms;
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
        int speed = 100; //above 100 is instant
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
            menuTransition.Interval = Config.menuTransitionSpeed;

            defaultMenuSize = menuContainer.Size;
            defaultSidePanelBtnLoc = sidepanelBtn.Location;
            defaultLblX = adminLine.Location;
            defaultMainPanelSize = mainPanelContainer.Size;

            setLabels();
            startupRunClass.runStartup();

            if(startupRunClass.persistentLogin())
                loginBtn.Text = loginHelper.Name;
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                adminLine.Visible = false;
                studentLine.Visible = false;
                miscLine.Visible = false;

                setTitlePos(adminLbl);
                setTitlePos(studentLbl);
                setTitlePos(miscLbl);

                appNameLbl.Text = "";
                appNameLbl.Image = Properties.Resources.dummy_logo;
                appNameLbl.ImageAlign = HorizontalAlignment.Left;
                setTitlePos(appNameLbl);

                dayLbl.Text = "";
                dateLbl.Text = "";
                adminBtn.Text = "";
                attBtn.Text = "";
                settingBtn.Text = "";
                versionLbl.Text = "";

                menuContainer.Width -= speed; 
                sidepanelBtn.Location = new Point(defaultSidePanelBtnLoc.X -= speed, defaultSidePanelBtnLoc.Y);
                mainPanelContainer.Width += speed;

                if (menuContainer.Width <= 85)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                    sidepanelBtn.Image = Properties.Resources.right_arrow;
                }
            }
            else
            {
                adminLine.Visible = true;
                studentLine.Visible = true;
                miscLine.Visible = true;

                setTitlePosBack(studentLbl);
                setTitlePosBack(adminLbl);
                setTitlePosBack(miscLbl);

                appNameLbl.Text = "APP NAME";
                appNameLbl.Image = null;
                setTitlePosBack(appNameLbl);

                menuContainer.Width += speed;
                mainPanelContainer.Width -= speed;
                sidepanelBtn.Location = new Point(defaultSidePanelBtnLoc.X += speed, defaultSidePanelBtnLoc.Y);

                if (menuContainer.Width >= defaultMenuSize.Width)
                {
                    menuExpand = true;
                    menuTransition.Stop();
                    sidepanelBtn.Image = Properties.Resources.left_arrow;
                    menuContainer.Size = defaultMenuSize;
                    mainPanelContainer.Size = defaultMainPanelSize;

                    setLabels();
                }
            }
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

            dayLbl.Text = DateTime.Now.DayOfWeek.ToString();
            dateLbl.Text = DateTime.Now.ToShortDateString();
            versionLbl.Text = Config.appVersion;
        }
        private void sidepanelBtn_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
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
            if(!loginHelper.isLogin)
            {
                MessageForm msg = new MessageForm()
                {
                    header = "Oooops!!",
                    message = "Please login first.",
                    messageType = "Failed",
                    isYesNo = false,

                };
                msg.ShowDialog();
                return;
            }

            pageHelper.loadForm(new adminForm(), mainPanel);
            enebleBtn(adminBtn);
        }

        private void sidepanelBtn_MouseLeave(object sender, EventArgs e)
        {

            sidepanelBtn.ImageSize = new Size(20, 20);
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            if(!loginHelper.isLogin)
            {
                MessageForm msg = new MessageForm()
                {
                    header = "Oooops!!",
                    message = "Please login first.",
                    messageType = "Failed",
                    isYesNo = false,

                };
                msg.ShowDialog();
                return;
            }
            pageHelper.loadForm(new enrollForm(), mainPanel);
            enebleBtn(enrollBtn);
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(loginBtn.Text == "LOGIN")
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

            loginBtn.Text = loginHelper.Name;
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

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if(!loginHelper.isLogin)
            {
                MessageForm msg = new MessageForm()
                {
                    header = "Oooops!!",
                    message = "Please login first.",
                    messageType = "Failed",
                    isYesNo = false,

                };
                msg.ShowDialog();
                return;
            }
            pageHelper.loadForm(new settingForm(), mainPanel);
            enebleBtn(settingBtn);
        }

        void enebleBtn(Guna2Button disabledBtn)
        {
            enrollBtn.Enabled = true;
            adminBtn.Enabled = true;
            attBtn.Enabled = true;
            settingBtn.Enabled = true;

            disabledBtn.Enabled = false;
        }

    }
}
