using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Startup
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
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
        private void Dashboard_Form_Load(object sender, EventArgs e)
        {

        }

        void loadData()
        {

        }

        void loadYearlyAtt()
        {
            String query = "";
        }
        void loadMonthlyAtt()
        {

        }

        private void attContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
