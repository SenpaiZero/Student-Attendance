﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public partial class MessageForm : Form
    {
        Color greenBtn = Color.FromArgb(107, 142, 35); // Green
        Color redBtn = Color.FromArgb(178, 34, 34); // Red
        Color defaultBtn = Color.FromArgb(201, 97, 128); //Default 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        public MessageForm()
        {
            InitializeComponent();
            maxTime = 3;
        }

        // Suceess, Failed, Information
        public string messageType { get; set; }
        public string header { get; set; }
        public string message { get; set; }
        public bool isYesNo { get; set; }
        public bool isTimer { get; set; }
        public int maxTime { get; set; }

        int timer = 0;
        private void MessageForm_Load(object sender, EventArgs e)
        {
            buttonTimer.Interval = 1000;
            setImage();
            setMessage();

            if (isTimer)
                buttonTimer.Start();

            if (isYesNo)
            {
                if (isTimer)
                {
                    yesBtn.Enabled = false;
                    yesBtn.Text = maxTime.ToString();
                }

                yesBtn.Visible = true;
                yesBtn.FillColor = greenBtn;

                noBtn.Visible = true;
                noBtn.FillColor = redBtn;

                okBtn.Visible = false;

            }
            else
            {
                if (isTimer)
                {
                    okBtn.Enabled = false;
                    okBtn.Text = maxTime.ToString();
                }
                yesBtn.Visible = false;
                noBtn.Visible = false;

                okBtn.Visible = true;

                if (messageType.ToLower() == "success")
                    okBtn.FillColor = greenBtn;
                else if(messageType.ToLower() == "failed")
                    okBtn.FillColor = redBtn;
                else
                    okBtn.FillColor = defaultBtn;

            }


        }

        void setImage()
        {
            // Success
            if (messageType.ToLower() == "success")
            {
                picture.Image = Properties.Resources.smiley;
            }
            // Failed
            else if (messageType.ToLower() == "failed")
            {
                picture.Image = Properties.Resources.sad_face;
            }
            //Information
            else if (messageType.ToLower() == "information")
            {
                picture.Image = Properties.Resources.thinking;
            }
        }

        void setMessage()
        {
            HeaderLbl.Text = header;
            descLbl.Text = message;

            if(descLbl.Text.Length > 20)
            {
                descLbl.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            timer++;

            if (isYesNo)
                yesBtn.Text = Math.Abs(timer - maxTime).ToString();
            else
                okBtn.Text = Math.Abs(timer - maxTime).ToString();

            if (timer >= maxTime)
            {
                if (isYesNo)
                {
                    yesBtn.Enabled = true;
                    yesBtn.Text = "YES";
                }
                else
                {
                    okBtn.Enabled = true;
                    okBtn.Text = "OK";
                }
                buttonTimer.Stop();
            }
        }
    }
}
