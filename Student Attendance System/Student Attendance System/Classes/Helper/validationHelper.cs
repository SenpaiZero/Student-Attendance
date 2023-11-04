using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    internal class validationHelper
    {
        public static bool internetAvailability()
        {
            try
            {
                Ping ping = new Ping();
                String host = "portal.azure.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOption = new PingOptions();
                PingReply reply = ping.Send(host, timeout, buffer, pingOption);
                return (reply.Status == IPStatus.Success);
            } catch(Exception)
            {
                return false;
            }
        }

        // Checks guna2textbox for text,
        public static bool textBoxValidation_Alpha(Guna2TextBox tb, String name, ErrorProvider errorProvider)
        {
            String nullField = "is required. Please complete this field to continue";
            String symNumNotAllowed = "is invalid (Symbols and numbers are not allowed)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;

            //Checks if its empty
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {nullField}");
                return false;
            }
            // Checks if its alpha only
            else if (!validationHelper.checkFieldAlpha(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(217, 221, 226);
            errorProvider.SetError(tb, null);
            return true;
        }

        public static bool textBoxValidation_Alpha_optional(Guna2TextBox tb, String name, ErrorProvider errorProvider)
        {
            String symNumNotAllowed = "is invalid (Symbols and numbers are not allowed)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                // Clears the error
                tb.BorderThickness = 1;
                tb.BorderColor = Color.FromArgb(217, 221, 226);
                errorProvider.SetError(tb, null);
                return true;
            }
            if (!validationHelper.checkFieldAlpha(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(217, 221, 226);
            errorProvider.SetError(tb, null);
            return true;
        }

        // Checks guna2combobox if it user changed the value
        public static bool comboBoxValidation(Guna2ComboBox cb, String validation, ErrorProvider ep)
        {
            if (validationHelper.comboBoxCheck(validation, cb) == false)
            {
                validation = validation.First() + validation.Substring(1, validation.Length - 1);
                ep.SetError(cb, $"{validation} is invalid. Please choose a correct option");
                if (!comboBoxFirstLoad)
                {
                    cb.BorderColor = Color.IndianRed;
                }
                return false;
            }

            cb.BorderColor = Color.FromArgb(217, 221, 226);
            ep.SetError(cb, null);
            return true;
        }

        public static bool comboBoxFirstLoad { get; set; }
        public static bool textBoxValidation_Numeric(Guna2TextBox tb, String name, ErrorProvider errorProvider, int min)
        {
            String nullField = "is required. Please complete this field to continue";
            String symLetter = "is invalid (Only numbers are allowed)";
            tb.BorderColor = Color.IndianRed;
            //Checks if its empty
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {nullField}");
                return false;
            }
            // Checks if its numeric only
            else if (!validationHelper.checkFieldNumeric(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {symLetter}");
                return false;
            }
            else if (tb.Text.Length < min)
            {
                errorProvider.SetError(tb, $"There should be more than {min} characters");
                return false;
            }
            // Clears the error
            tb.BorderColor = Color.FromArgb(217, 221, 226);
            errorProvider.SetError(tb, null);
            return true;
        }
        public static bool textBoxValidation_Numeric_optional(Guna2TextBox tb, String name, ErrorProvider errorProvider, int min)
        {
            String symLetter = "is invalid (Only numbers are allowed)";
            tb.BorderColor = Color.IndianRed;
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                // Clears the error
                tb.BorderThickness = 1;
                tb.BorderColor = Color.FromArgb(213, 218, 223);
                errorProvider.SetError(tb, null);
                return true;
            }
            if (!validationHelper.checkFieldNumeric(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {symLetter}");
                return false;
            }

            if (tb.Text.Length < min)
            {
                errorProvider.SetError(tb, $"There should be more than {min} characters");
                return false;
            }
            // Clears the error
            tb.BorderColor = Color.FromArgb(213, 218, 223);
            errorProvider.SetError(tb, null);
            return true;
        }

        //Checks if user changed combobox value
        public static bool comboBoxCheck(String value, Guna2ComboBox cb)
        {
            if (value.ToLower() == cb.Text.ToLower())
                return false;
            else
                return true;
        }



        // Checking if user entered a value in required field
        public static bool checkFieldBlank(String tb)
        {
            if (string.IsNullOrEmpty(tb) || string.IsNullOrWhiteSpace(tb))
                return true;
            return false;
        }

        // Check if user entered alphabets only
        public static bool checkFieldAlpha(String tb)
        {
            if (Regex.IsMatch(tb, "^[a-zA-Z]+(\\s[a-zA-Z]+)*$") && !tb.Contains("  "))
                return true;
            return false;
        }

        // Checks if user entered correct address
        public static bool IsValidAddress(string address)
        {
            string pattern = @"^(?!.*[,.-]{2})(?!.*\s{2})[a-zA-Z0-9,. -]+$";
            if (Regex.IsMatch(address, pattern))
                return true;
            return false;
        }
        public static bool textBoxValidation_Address(Guna2TextBox tb, String name, ErrorProvider errorProvider)
        {
            String nullField = "is required. Please complete this field to continue";
            String symNumNotAllowed = "is invalid (Please enter a valid address)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;

            //Checks if its empty
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {nullField}");
                return false;
            }
            else if (!validationHelper.IsValidAddress(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(213, 218, 223);
            errorProvider.SetError(tb, null);
            return true;
        }
        public static bool textBoxValidation_Address_optional(Guna2TextBox tb, String name, ErrorProvider errorProvider)
        {
            String nullField = "is required. Please complete this field to continue";
            String symNumNotAllowed = "is invalid (Please enter a valid address)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;

            //Checks if its empty
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                // Clears the error
                tb.BorderThickness = 1;
                tb.BorderColor = Color.FromArgb(213, 218, 223);
                errorProvider.SetError(tb, null);
                return true;
            }
            else if (!validationHelper.IsValidAddress(tb.Text))
            {

                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(213, 218, 223);
            errorProvider.SetError(tb, null);
            return true;
        }
        // Checks if user entered correct email
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (Regex.IsMatch(email, pattern))
                return true;
            return false;
        }

        public static bool textBoxValidation_PhoneNumber(Guna2TextBox tb, string name, ErrorProvider errorProvider)
        {
            String nullField = "is required. Please complete this field to continue";
            String symNumNotAllowed = "is invalid (Symbols and numbers are not allowed)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;

            //Checks if its empty
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {nullField}");
                return false;
            }
            // Checks if its alpha only
            else if (!Regex.IsMatch(tb.Text, @"^09\d{9}$"))
            {
                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(217, 221, 226);
            errorProvider.SetError(tb, null);
            return true;
        }

        public static bool textBoxValidation_PhoneNumber_optional(Guna2TextBox tb, string name, ErrorProvider errorProvider)
        {
            String symNumNotAllowed = "is invalid (Symbols and numbers are not allowed)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;

            if (validationHelper.checkFieldBlank(tb.Text))
            {
                // Clears the error
                tb.BorderThickness = 1;
                tb.BorderColor = Color.FromArgb(217, 221, 226);
                errorProvider.SetError(tb, null);
                return true;
            }

            if (!Regex.IsMatch(tb.Text, @"^09\d{9}$"))
            {
                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(217, 221, 226);
            errorProvider.SetError(tb, null);
            return true;
        }
        public static bool textBoxValidation_Email(Guna2TextBox tb, String name, ErrorProvider errorProvider)
        {
            String nullField = "is required. Please complete this field to continue";
            String symNumNotAllowed = "is invalid (Symbols and numbers are not allowed)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;

            //Checks if its empty
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {nullField}");
                return false;
            }
            // Checks if its alpha only
            else if (!validationHelper.IsValidEmail(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(217, 221, 226);
            errorProvider.SetError(tb, null);
            return true;
        }
        public static bool textBoxValidation_Email_option(Guna2TextBox tb, String name, ErrorProvider errorProvider)
        {
            String symNumNotAllowed = "is invalid (Symbols and numbers are not allowed)";
            tb.BorderColor = Color.IndianRed;
            tb.BorderThickness = 2;

            //Checks if its empty
            if (validationHelper.checkFieldBlank(tb.Text))
            {
                tb.BorderThickness = 1;
                tb.BorderColor = Color.FromArgb(217, 221, 226);
                errorProvider.SetError(tb, null);
                return true;
            }
            // Checks if its alpha only
            else if (!validationHelper.IsValidEmail(tb.Text))
            {
                errorProvider.SetError(tb, $"{name} {symNumNotAllowed}");
                return false;
            }
            // Clears the error
            tb.BorderThickness = 1;
            tb.BorderColor = Color.FromArgb(217, 221, 226);
            errorProvider.SetError(tb, null);
            return true;
        }
        // Checks if user entered alphabets and numbers only
        public static bool checkFieldAlphaNumeric(String tb)
        {
            if (Regex.IsMatch(tb, "^[a-zA-Z0-9\\s]+$"))
                return true;
            return false;
        }

        // Check if user entered numbers only
        public static bool checkFieldNumeric(String tb)
        {
            if (Regex.IsMatch(tb, "^[0-9]+$"))
                return true;
            return false;
        }

        // Converting Bitmap to byte
        public static byte[] convertBitmapToByte(Bitmap bm)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bm.Save(ms, ImageFormat.Jpeg); // Assuming you want to save it as JPEG format
                return ms.ToArray();
            }
        }
    }
}
