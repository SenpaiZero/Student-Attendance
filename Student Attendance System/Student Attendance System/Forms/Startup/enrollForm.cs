using Student_Attendance_System.Classes;
using Student_Attendance_System.Forms.Enroll;
using Student_Attendance_System.Forms.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace Student_Attendance_System.Startup
{
    public partial class enrollForm : Form
    {
        bool[] filledUp;
        public enrollForm()
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
        private void attendanceForm_Load(object sender, EventArgs e)
        {
            filledUp= new bool[] { false, false, false};
            pageHelper.loadEnrollForm(new personalDetails(), mainPanel);
            bringFront();
            defaultData();
        }
        
        void defaultData()
        {
            //page 1
            EnrollmentGlobalVariable.firstName = "";
            EnrollmentGlobalVariable.middleName = "";
            EnrollmentGlobalVariable.lastName = "";

            EnrollmentGlobalVariable.birthday = "";
            EnrollmentGlobalVariable.age = "";
            EnrollmentGlobalVariable.religion = "";
            EnrollmentGlobalVariable.gender = "";
            EnrollmentGlobalVariable.address = "";
            EnrollmentGlobalVariable.phone = "";
            EnrollmentGlobalVariable.email = "";
            personalDetails.checkAttemp = new bool[] { false, false, false, false, false, false };

            //Page 2
            EnrollmentGlobalVariable.fatherfName = "";
            EnrollmentGlobalVariable.fathermName = "";
            EnrollmentGlobalVariable.fatherlName = "";
            EnrollmentGlobalVariable.fatherEmail = "";
            EnrollmentGlobalVariable.fatherPhone = "";
            EnrollmentGlobalVariable.fatherOccupation = "";


            EnrollmentGlobalVariable.motherfName = "";
            EnrollmentGlobalVariable.mothermName = "";
            EnrollmentGlobalVariable.motherlName = "";
            EnrollmentGlobalVariable.motherEmail = "";
            EnrollmentGlobalVariable.motherPhone = "";
            EnrollmentGlobalVariable.motherOccupation = "";
            guardianDetails.checkAttemp = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };


            //Page 3
            EnrollmentGlobalVariable.section = "";
            EnrollmentGlobalVariable.year = "";
            EnrollmentGlobalVariable.id = "";
            EnrollmentGlobalVariable.moreDetails = "";
            EnrollmentGlobalVariable.frame = null;
            EnrollmentGlobalVariable.QRCode = null;
            moreDetailsForm.checkAttemp = new bool[] { false, false };
        }
        void bringFront()
        {
            nextBtn.BringToFront();
            backBtn.BringToFront();
        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(EnrollmentGlobalVariable.page > 0)
                EnrollmentGlobalVariable.page--;

            if (EnrollmentGlobalVariable.page == 0)
                pageHelper.loadEnrollForm(new personalDetails(), mainPanel);
            else if (EnrollmentGlobalVariable.page == 1)
                pageHelper.loadEnrollForm(new guardianDetails(), mainPanel);
            bringFront();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (EnrollmentGlobalVariable.page == 0)
                personalDetails.done();
            if(EnrollmentGlobalVariable.page == 1)
                guardianDetails.done();
            if (EnrollmentGlobalVariable.page == 2)
                moreDetailsForm.done();
            if (EnrollmentGlobalVariable.isNext == false)
                return;

            if (EnrollmentGlobalVariable.page < 2)
                EnrollmentGlobalVariable.page++;
            else
            {
                previewEnrollmentData prev = new previewEnrollmentData();
                if(prev.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("added");
                    return;
                }
            }
            if (EnrollmentGlobalVariable.page == 1)
                pageHelper.loadEnrollForm(new guardianDetails(), mainPanel);
            else if(EnrollmentGlobalVariable.page == 2)
                pageHelper.loadEnrollForm(new moreDetailsForm(), mainPanel);

            bringFront();
        }

        private void enrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnrollmentGlobalVariable.page = 0;
            defaultData();
        }

    }
}
