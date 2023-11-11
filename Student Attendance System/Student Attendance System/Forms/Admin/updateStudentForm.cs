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

namespace Student_Attendance_System.Forms.Admin
{
    public partial class updateStudentForm : Form
    {
        public String name { get; set; }
        public String studentID { get; set; }
        public String section { get; set; }
        public updateStudentForm()
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
        private void updateStudentForm_Load(object sender, EventArgs e)
        {
            buttonController(personalBtn);
        }

        public void showData(String id)
        {

        }

        void buttonController(Guna2Button btn)
        {
            personalBtn.Enabled = true;
            guardianBtn.Enabled = true;
            moreBtn.Enabled = true;

            btn.Enabled = false;
        }

        private void personalBtn_Click(object sender, EventArgs e)
        {
            buttonController(personalBtn);
            personalContainer.BringToFront();
            guna2Panel1.BringToFront();
        }

        private void guardianBtn_Click(object sender, EventArgs e)
        {
            buttonController(guardianBtn);
            guardianContainer.BringToFront();
            guna2Panel1.BringToFront();
        }

        private void moreBtn_Click(object sender, EventArgs e)
        {
            buttonController(moreBtn);
            moreDetailsContainer.BringToFront();
            guna2Panel1.BringToFront();
        }
    }
}
