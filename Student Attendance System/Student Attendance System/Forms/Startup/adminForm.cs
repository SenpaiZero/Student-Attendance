using Student_Attendance_System.Forms.Admin;
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
    public partial class adminForm : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;
        public adminForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
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
        private void adminForm_Load(object sender, EventArgs e)
        {
        }


        private void adminForm_Resize(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadAdminForm(new logsForm(), mainPanel);
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadAdminForm(new studentListForm(), mainPanel);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            if (loginHelper.Name.ToUpper() != "ADMIN")
            {
                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    header = "Ooooops!",
                    message = "You do not have permission to access and use this page",
                    isYesNo = false
                };
                msg.ShowDialog();
                return;
            }

            // show 
        }
    }
}
