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
        }
        public static void loading(Control parentControl)
        {
            /*loadingForm load = new loadingForm();
            load.loadingTime = 500;
            load.StartPosition = FormStartPosition.Manual;

            Point listTableLocationOnForm = parentControl.Parent.PointToScreen(parentControl.Location);
            int loadingFormX = listTableLocationOnForm.X + (parentControl.Width - load.Width) / 2;
            int loadingFormY = listTableLocationOnForm.Y + (parentControl.Height - load.Height) / 2;
            load.Location = new Point(loadingFormX, loadingFormY);
            load.ShowDialog();*/
        }
    }
}
