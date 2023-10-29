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
        public startupForm()
        {
            InitializeComponent();
        }

        private void startupForm_Load(object sender, EventArgs e)
        {
            menuTransition.Interval = Config.menuTransitionSpeed;

            defaultMenuSize = menuContainer.Size;
            defaultSidePanelBtnLoc = sidepanelBtn.Location;
            defaultLblX = adminLine.Location;
            defaultMainPanelSize = mainPanelContainer.Size;

            setLabels();

            pageHelper.loadForm(new adminForm(), mainPanel);
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

                menuContainer.Width -= 25; 
                sidepanelBtn.Location = new Point(defaultSidePanelBtnLoc.X -= 25, defaultSidePanelBtnLoc.Y);
                mainPanelContainer.Width += 25;

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

                menuContainer.Width += 25;
                mainPanelContainer.Width -= 25;
                sidepanelBtn.Location = new Point(defaultSidePanelBtnLoc.X += 25, defaultSidePanelBtnLoc.Y);

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

        private void mainPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadForm(new studentForm(), mainPanel);
            enebleBtn(attBtn);
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadForm(new adminForm(), mainPanel);
            enebleBtn(adminBtn);
        }

        private void sidepanelBtn_MouseLeave(object sender, EventArgs e)
        {

            sidepanelBtn.ImageSize = new Size(20, 20);
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
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
                    loginBtn.Text = "admin";
                }
            }
            else
            {
                MessageBox.Show("logout?");
            }
            
        }

        private void guna2Shapes5_Click(object sender, EventArgs e)
        {

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
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
