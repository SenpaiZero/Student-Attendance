using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Classes.Helper
{
    internal class UIHelper
    {
        public startupForm startupForm
        {
            get => default;
            set
            {
            }
        }

        public static float CalculateFontSize(string text, Font originalFont, SizeF availableSize)
        {
            // Calculate the scaling factor for both width and height
            float widthScale = availableSize.Width / TextRenderer.MeasureText(text, originalFont).Width;
            float heightScale = availableSize.Height / TextRenderer.MeasureText(text, originalFont).Height;

            // Use the smaller scaling factor to ensure the text fits within the available size
            float scale = Math.Min(widthScale, heightScale);

            // Calculate and return the new font size
            float newSize = originalFont.Size * scale;
            return newSize;
        }
    }
}
