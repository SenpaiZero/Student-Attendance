using Guna.UI2.WinForms;
using Student_Attendance_System.Classes.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Enroll
{
    public partial class guardianDetails : Form
    {
        public guardianDetails()
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
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guardianDetails_Load(object sender, EventArgs e)
        {
        }

        private void firstNameTB_SizeChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
