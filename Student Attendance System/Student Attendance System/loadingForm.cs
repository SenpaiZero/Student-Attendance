using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public partial class loadingForm : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public loadingForm()
        {
            InitializeComponent();
        }

        private void loadingForm_Load(object sender, EventArgs e)
        {
            titleLbl.Text = title;
            descLbl.Text = description;

            loadTime = 1000;
            loadTimer.Interval = 500;
            loadTimer.Start();
            stopwatch.Start();
        }
        public string title { get; set; }
        public string description { get; set; }
        public int loadTime { get; set; }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedMilliseconds > loadTime)
            {
                loadTimer.Stop();
                stopwatch.Stop();

                this.Close();

            }
        }
    }
}
