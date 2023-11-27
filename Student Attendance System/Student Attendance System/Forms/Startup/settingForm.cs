using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Startup
{
    public partial class settingForm : Form
    {
        string newQrPath;
        string newPicturePath;
        public settingForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void settingForm_Load(object sender, EventArgs e)
        {
            dbConStringTB.UseSystemPasswordChar= true;
            if (Properties.Settings.Default.loginAdmin != "ADMIN")
                dbConStringTB.ReadOnly = true;

            dbConStringTB.Text = "this is a test only";

            qrOutputTB.Text = Config.qrcodePath;
            picOutputTB.Text = Config.picturePath;
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

        private void applyBtn_Click(object sender, EventArgs e)
        {

        }

        private void headeLbl_Click(object sender, EventArgs e)
        {

        }

        private void applyBtn_Click_1(object sender, EventArgs e)
        {
            MessageForm msg = new MessageForm()
            {
                isYesNo = true,
                messageType = "Information",
                header = "Are you sure?",
                message = "You can't undo what you are about to do"
            };

            if(msg.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(newPicturePath) && !Directory.Exists(newPicturePath))
                {
                    Directory.CreateDirectory(folderBrowserDialog.SelectedPath + @"\pictures");
                    Directory.CreateDirectory(folderBrowserDialog.SelectedPath + @"\pictures\unenroll");

                    Properties.Settings.Default.picPath = folderBrowserDialog.SelectedPath + @"\pictures";

                    Config.picturePath = folderBrowserDialog.SelectedPath + @"\picture";
                    Config.picturePath_unenroll = folderBrowserDialog.SelectedPath + @"\picture\unenroll";
                    picOutputTB.Text = folderBrowserDialog.SelectedPath + @"\pictures";
                }

                if (!string.IsNullOrEmpty(newQrPath) && !Directory.Exists(folderBrowserDialog.SelectedPath + @"\qrcode"))
                {
                    Directory.CreateDirectory(folderBrowserDialog.SelectedPath + @"\qrcode");
                    Directory.CreateDirectory(folderBrowserDialog.SelectedPath + @"\qrcode\unenroll");

                    Properties.Settings.Default.picPath = folderBrowserDialog.SelectedPath + @"\qrcode";

                    Config.qrcodePath = folderBrowserDialog.SelectedPath + @"\qrcode";
                    Config.qrcodePath_unenroll = folderBrowserDialog.SelectedPath + @"\qrcode\unenroll";
                    qrOutputTB.Text = folderBrowserDialog.SelectedPath + @"\qrcode";
                }

                Properties.Settings.Default.Save();
            }
        }

        private void dbConStringTB_IconRightClick(object sender, EventArgs e)
        {
            if(dbConStringTB.ReadOnly)
            {
                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    header = "Ooooops!",
                    message = "You do not have permission to access and modify database connection",
                    isYesNo = false
                };
                msg.ShowDialog();
                return;
            }

            if (dbConStringTB.UseSystemPasswordChar)
            {
                dbConStringTB.IconRight = Properties.Resources.visible;
                dbConStringTB.PasswordChar = '\0';
                dbConStringTB.UseSystemPasswordChar = false;
            }
            else
            {
                dbConStringTB.IconRight = Properties.Resources.hidden;
                dbConStringTB.PasswordChar = '●';
                dbConStringTB.UseSystemPasswordChar = true;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void picOutputTB_IconRightClick(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Choose a folder for picture";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                newPicturePath = folderBrowserDialog.SelectedPath + @"\pictures";

                if (!Directory.Exists(folderBrowserDialog.SelectedPath + @"\pictures"))
                {
                    picOutputTB.Text = folderBrowserDialog.SelectedPath + @"\pictures";
                }
                else
                {
                    MessageForm msg = new MessageForm()
                    {
                        isYesNo = false,
                        messageType = "Failed",
                        header = "Folder Creation Failed",
                        message = "Folden named pictures already exist"
                    };
                    msg.ShowDialog();
                }
            }
        }

        private void qrOutputTB_IconRightClick(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Choose a folder for qr codes";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                if (!Directory.Exists(folderBrowserDialog.SelectedPath + @"\qrcode"))
                {
                    newQrPath = folderBrowserDialog.SelectedPath + @"\qrcode";
                }
                else
                {
                    MessageForm msg = new MessageForm()
                    {
                        isYesNo = false,
                        messageType = "Failed",
                        header = "Folder Creation Failed",
                        message = "Folden named qrcode already exist"
                    };
                    msg.ShowDialog();
                }
            }
        }
    }
}
