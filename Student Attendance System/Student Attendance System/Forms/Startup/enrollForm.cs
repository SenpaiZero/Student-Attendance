using Student_Attendance_System.Classes;
using Student_Attendance_System.Forms.Enroll;
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
            ErnployeesGlobalVariable.firstName = "";
            ErnployeesGlobalVariable.middleName = "";
            ErnployeesGlobalVariable.lastName = "";

            ErnployeesGlobalVariable.birthday = "";
            ErnployeesGlobalVariable.age = "";
            ErnployeesGlobalVariable.religion = "";
            ErnployeesGlobalVariable.gender = "";
            ErnployeesGlobalVariable.address = "";
            ErnployeesGlobalVariable.phone = "";
            ErnployeesGlobalVariable.email = "";
            personalDetails.checkAttemp = new bool[] { false, false, false, false, false, false };

            //Page 2
            ErnployeesGlobalVariable.fatherfName = "";
            ErnployeesGlobalVariable.fathermName = "";
            ErnployeesGlobalVariable.fatherlName = "";
            ErnployeesGlobalVariable.fatherEmail = "";
            ErnployeesGlobalVariable.fatherPhone = "";
            ErnployeesGlobalVariable.fatherOccupation = "";


            ErnployeesGlobalVariable.motherfName = "";
            ErnployeesGlobalVariable.mothermName = "";
            ErnployeesGlobalVariable.motherlName = "";
            ErnployeesGlobalVariable.motherEmail = "";
            ErnployeesGlobalVariable.motherPhone = "";
            ErnployeesGlobalVariable.motherOccupation = "";
            guardianDetails.checkAttemp = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };


            //Page 3
            ErnployeesGlobalVariable.section = "";
            ErnployeesGlobalVariable.year = "";
            ErnployeesGlobalVariable.id = "";
            ErnployeesGlobalVariable.moreDetails = "";
            ErnployeesGlobalVariable.frame = null;
            ErnployeesGlobalVariable.QRCode = null;
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
            if(ErnployeesGlobalVariable.page > 0)
                ErnployeesGlobalVariable.page--;

            if (ErnployeesGlobalVariable.page == 0)
                pageHelper.loadEnrollForm(new personalDetails(), mainPanel);
            else if (ErnployeesGlobalVariable.page == 1)
                pageHelper.loadEnrollForm(new guardianDetails(), mainPanel);
            bringFront();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (ErnployeesGlobalVariable.page == 0)
                personalDetails.done();
            if(ErnployeesGlobalVariable.page == 1)
                guardianDetails.done();
            if (ErnployeesGlobalVariable.page == 2)
                moreDetailsForm.done();
            if (ErnployeesGlobalVariable.isNext == false)
                return;

            if (ErnployeesGlobalVariable.page < 2)
                ErnployeesGlobalVariable.page++;

            if (ErnployeesGlobalVariable.page == 1)
                pageHelper.loadEnrollForm(new guardianDetails(), mainPanel);
            else if(ErnployeesGlobalVariable.page == 2)
                pageHelper.loadEnrollForm(new moreDetailsForm(), mainPanel);

            bringFront();
        }

        private void enrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ErnployeesGlobalVariable.page = 0;
            defaultData();
        }

    }
}
