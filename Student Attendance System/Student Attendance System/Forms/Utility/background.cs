using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Utility
{
    public partial class background : Form
    {
        public static background bg;
        public background()
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
        public static void openBackground()
        {
            if (bg == null)
                bg = new background();
            bg.Show();
        }

        public static void closeBackgroundForm()
        {
            if(bg != null)
                bg.Close();
        }

        public static void closeBackground()
        {
            if (bg != null)
                bg.Hide();
        }
        private void background_Load(object sender, EventArgs e)
        {
            bg = this;

            startupForm start = new startupForm();
            start.ShowDialog();
        }
    }
}
