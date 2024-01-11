﻿  using Guna.UI2.WinForms;
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
        // 0 - main   1 - admin   2 - enroll 3 - dashboard
        public static Form[] f = new Form[4];

        public Forms.Startup.dashboard dashboard
        {
            get => default;
            set
            {
            }
        }

        public Startup.enrollForm enrollForm
        {
            get => default;
            set
            {
            }
        }

        public startupForm startupForm
        {
            get => default;
            set
            {
            }
        }

        // load the form into panel
        public static void loadForm(object Form, Guna2Panel mainPanel)
        {
            if (f[0] != null)
                f[0].Close();
            f[0] = Form as Form;
            f[0].SuspendLayout();
            f[0].TopLevel = false;
            mainPanel.Controls.Add(f[0]);
            mainPanel.Tag = f[0];
            f[0].Show();
            f[0].BringToFront();
            f[0].Dock = DockStyle.Fill;
            f[0].ResumeLayout();
        }

        public static void loadAdminForm(object Form, Guna2Panel mainPanel)
        {
            if (f[1] != null)
                f[1].Close();
            f[1] = Form as Form;
            f[1].SuspendLayout();
            f[1].TopLevel = false;
            mainPanel.Controls.Add(f[1]);
            mainPanel.Tag = f[1];
            f[1].Show();
            f[1].BringToFront();
            f[1].Dock = DockStyle.Fill;
            f[1].ResumeLayout();
        }
        public static void loadEnrollForm(object Form, Guna2Panel mainPanel)
        {
            if (f[2] != null)
                f[2].Close();
            f[2] = Form as Form;
            f[2].SuspendLayout();
            f[2].TopLevel = false;
            mainPanel.Controls.Add(f[2]);
            mainPanel.Tag = f[2];
            f[2].Show();
            f[2].BringToFront();
            f[2].Dock = DockStyle.Fill;
            f[2].ResumeLayout();
        }

        public static void loadDashboardForm(object Form, Guna2Panel mainPanel)
        {
            if (f[3] != null)
                f[3].Close();
            f[3] = Form as Form;
            f[3].SuspendLayout();
            f[3].TopLevel = false;
            mainPanel.Controls.Add(f[3]);
            mainPanel.Tag = f[3];
            f[3].Show();
            f[3].BringToFront();
            f[3].Dock = DockStyle.Fill;
            f[3].ResumeLayout();
        }
    }
}
