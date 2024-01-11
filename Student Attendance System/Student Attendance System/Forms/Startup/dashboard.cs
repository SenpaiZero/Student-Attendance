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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadDashboardForm(new dashboardStats(), mainPanel);
            statsBtn.Enabled = false;
            graphBtn.Enabled = true;
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            pageHelper.loadDashboardForm(new Dashboard_Form(), mainPanel);
            statsBtn.Enabled = true;
            graphBtn.Enabled = false;
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            statsBtn.PerformClick();
        }
    }
}
