using Guna.UI2.WinForms;
using Student_Attendance_System.Classes;
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

            fatherfnameTB.Text = ErnployeesGlobalVariable.fatherfName;
            fathermnameTB.Text = ErnployeesGlobalVariable.fathermName;
            fatherlnameTB.Text = ErnployeesGlobalVariable.fatherlName;
            fatherEmailTB.Text = ErnployeesGlobalVariable.fatherEmail;
            fatherPhoneNumberTB.Text = ErnployeesGlobalVariable.fatherPhone;
            fatherOccupationTB.Text = ErnployeesGlobalVariable.fatherOccupation;

            motherfnameTB.Text = ErnployeesGlobalVariable.motherfName;
            mothermnameTB.Text = ErnployeesGlobalVariable.mothermName;
            motherlnameTB.Text = ErnployeesGlobalVariable.motherlName;
            motherEmailTB.Text = ErnployeesGlobalVariable.motherEmail;
            motherPhoneTB.Text = ErnployeesGlobalVariable.motherPhone;
            motherOccupationTB.Text = ErnployeesGlobalVariable.motherOccupation;
        }

        private void firstNameTB_SizeChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void guardianDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            ErnployeesGlobalVariable.fatherfName = fatherfnameTB.Text;
            ErnployeesGlobalVariable.fathermName = fathermnameTB.Text;
            ErnployeesGlobalVariable.fatherlName = fatherlnameTB.Text;
            ErnployeesGlobalVariable.fatherEmail = fatherEmailTB.Text;
            ErnployeesGlobalVariable.fatherPhone = fatherPhoneNumberTB.Text;
            ErnployeesGlobalVariable.fatherOccupation = fatherOccupationTB.Text;

            ErnployeesGlobalVariable.motherfName = motherfnameTB.Text;
            ErnployeesGlobalVariable.mothermName = mothermnameTB.Text;
            ErnployeesGlobalVariable.motherlName = motherlnameTB.Text;
            ErnployeesGlobalVariable.motherEmail = motherEmailTB.Text;
            ErnployeesGlobalVariable.motherPhone = motherPhoneTB.Text;
            ErnployeesGlobalVariable.motherOccupation = motherOccupationTB.Text;
        }
    }
}
