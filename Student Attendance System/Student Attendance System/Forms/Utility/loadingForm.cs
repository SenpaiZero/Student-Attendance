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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        public loadingForm()
        {
            InitializeComponent();
            loadTime = 1000;
            isTask = false;
        }

        private void loadingForm_Load(object sender, EventArgs e)
        {
            titleLbl.Text = title;
            descLbl.Text = description;

            if (isTask) return;

            loadTimer.Interval = 500;
            loadTimer.Start();
            stopwatch.Start();
        }
        public string title { get; set; }
        public string description { get; set; }
        public int loadTime { get; set; }
        public bool isTask { get; set; }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedMilliseconds > loadTime)
            {
                loadTimer.Stop();
                stopwatch.Stop();

                this.Close();

            }
        }

        public void closeForm()
        {
            this.Close();
        }
    }
}
