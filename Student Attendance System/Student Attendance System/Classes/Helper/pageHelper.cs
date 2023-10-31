  using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    internal class pageHelper
    {
        public static Form f;
        public static Form f2;

        // load the form into panel
        public static void loadForm(object Form, Guna2Panel mainPanel)
        {
            if (f != null)
                f.Close();
            f = Form as Form;
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
            f.BringToFront();
            f.Dock = DockStyle.Fill;
        }

        public static void loadAdminForm(object Form, Guna2Panel mainPanel)
        {
            if (f2 != null)
                f2.Close();
            f2 = Form as Form;
            f2.TopLevel = false;
            mainPanel.Controls.Add(f2);
            mainPanel.Tag = f2;
            f2.Show();
            f2.BringToFront();
            f2.Dock = DockStyle.Fill;
        }
    }
}
