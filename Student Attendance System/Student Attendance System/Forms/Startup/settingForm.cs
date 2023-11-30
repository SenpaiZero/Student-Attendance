using Student_Attendance_System.Classes.Helper;
using Student_Attendance_System.Forms.Utility;
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
        bool startupChange = false;
        bool saveLocalChange = false;
        bool fillBackground = false;
        public settingForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void settingForm_Load(object sender, EventArgs e)
        {
            qrOutputTB.Text = Config.qrcodePath;
            picOutputTB.Text = Config.picturePath;

            startupCB.Text = Properties.Settings.Default.startup ? "YES" : "NO";
            saveLocalCB.Text = Properties.Settings.Default.saveLocal ? "YES" : "NO";
            fullScreenCB.Text = Properties.Settings.Default.fullscreen ? "YES" : "NO";
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
                message = "You can't undo what you are about to do",
                isTimer = true,
                maxTime = 5
            };

            if(msg.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(newPicturePath) && !Directory.Exists(newPicturePath))
                {
                    Directory.CreateDirectory(newPicturePath);
                    Directory.CreateDirectory(newPicturePath + @"\unenroll");

                    Properties.Settings.Default.picPath = newPicturePath;

                    Config.picturePath = newPicturePath;
                    Config.picturePath_unenroll = newPicturePath + @"\unenroll";
                    picOutputTB.Text = newPicturePath;
                }

                if (!string.IsNullOrEmpty(newQrPath) && !Directory.Exists(folderBrowserDialog.SelectedPath + @"\qrcode"))
                {
                    Directory.CreateDirectory(newQrPath);
                    Directory.CreateDirectory(newQrPath + @"\unenroll");

                    Properties.Settings.Default.qrcodePath = newQrPath;

                    Config.qrcodePath = newQrPath;
                    Config.qrcodePath_unenroll = newQrPath + @"\unenroll";
                    qrOutputTB.Text = newQrPath;
                }

                if(startupChange)
                {
                    if (startupCB.Text == "NO")
                    {
                        startupHelper.RemoveStartup();
                        Properties.Settings.Default.startup = false;
                    }
                    else
                    {
                        startupHelper.SetStartup();
                        Properties.Settings.Default.startup = true;
                    }
                }
                if(saveLocalChange)
                {
                    if(saveLocalCB.Text == "NO")
                    {
                        Properties.Settings.Default.saveLocal = false;
                        Config.saveLocal = false;
                    }
                    else
                    {
                        Properties.Settings.Default.saveLocal = true;
                        Config.saveLocal = true;
                    }
                }

                if(fillBackground)
                {
                    if(fullScreenCB.Text == "NO")
                    {
                        Properties.Settings.Default.fullscreen = false;
                        Config.fullScreen = false;
                        background.closeBackground();
                    }
                    else
                    {
                        Properties.Settings.Default.fullscreen = true;
                        Config.fullScreen = true;
                        background.openBackground();
                    }
                }
                Properties.Settings.Default.Save();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            MessageForm msg = new MessageForm()
            {
                isYesNo = true,
                messageType = "Information",
                header = "Are you sure?",
                message = "You cannot undo what you are about to do"
            };
            if(msg.ShowDialog() == DialogResult.OK)
            {
                MessageForm msg2 = new MessageForm()
                {
                    isYesNo = true,
                    messageType = "Information",
                    header = "Last warning!",
                    message = "Are you really sure you want to reset setting?",
                    isTimer = true,
                    maxTime = 5
                };
                if(msg2.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.Reset();
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        private void picOutputTB_IconRightClick(object sender, EventArgs e)
        {
            // Disable textbox/filepath if save image locally is disabled
            if (!Config.saveLocal)
            {
                MessageForm msgSave = new MessageForm()
                {
                    isYesNo = false,
                    messageType = "Information",
                    header = "Woooops",
                    message = "Save image locally is disabled"
                };
                msgSave.ShowDialog();
                return;
            }
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
            // Disable textbox/filepath if save image locally is disabled
            if(!Config.saveLocal)
            {
                MessageForm msgSave = new MessageForm()
                {
                    isYesNo = false,
                    messageType = "Information",
                    header = "Woooops",
                    message = "Save image locally is disabled"
                };
               msgSave.ShowDialog();
               return;
            }

            folderBrowserDialog.Description = "Choose a folder for qr codes";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                newQrPath = folderBrowserDialog.SelectedPath + @"\qrcode";
                if (!Directory.Exists(folderBrowserDialog.SelectedPath + @"\qrcode"))
                {
                    qrOutputTB.Text = newQrPath;
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

        private void startupCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            startupChange = true;
        }

        private void saveLocalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveLocalChange = true;
        }

        private void fullScreenCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillBackground = true;
        }
    }
}
