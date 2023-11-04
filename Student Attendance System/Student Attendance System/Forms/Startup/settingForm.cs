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
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void settingForm_Load(object sender, EventArgs e)
        {
            dbConStringTB.UseSystemPasswordChar= true;
            if (Properties.Settings.Default.loginAdmin != "ADMIN")
                dbConStringTB.ReadOnly = true;

            dbConStringTB.Text = "this is a test only";
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

        private void applyBtn_Click(object sender, EventArgs e)
        {

        }

        private void headeLbl_Click(object sender, EventArgs e)
        {

        }

        private void applyBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void dbConStringTB_IconRightClick(object sender, EventArgs e)
        {
            if(dbConStringTB.ReadOnly)
            {
                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    header = "Ooooops!",
                    message = "You do not have permission to access and modify database connection",
                    isYesNo = false
                };
                msg.ShowDialog();
                return;
            }

            if (dbConStringTB.UseSystemPasswordChar)
            {
                dbConStringTB.IconRight = Properties.Resources.visible;
                dbConStringTB.PasswordChar = '\0';
                dbConStringTB.UseSystemPasswordChar = false;
            }
            else
            {
                dbConStringTB.IconRight = Properties.Resources.hidden;
                dbConStringTB.PasswordChar = '●';
                dbConStringTB.UseSystemPasswordChar = true;
            }
        }
    }
}
