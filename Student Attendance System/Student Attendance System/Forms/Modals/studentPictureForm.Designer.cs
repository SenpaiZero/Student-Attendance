﻿namespace Student_Attendance_System.Forms
{
    partial class studentPictureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.camPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.captureBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.camListCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.camPB)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // camPB
            // 
            this.camPB.BorderRadius = 5;
            this.camPB.ImageRotate = 0F;
            this.camPB.Location = new System.Drawing.Point(34, 25);
            this.camPB.Name = "camPB";
            this.camPB.Size = new System.Drawing.Size(400, 400);
            this.camPB.TabIndex = 0;
            this.camPB.TabStop = false;
            // 
            // captureBtn
            // 
            this.captureBtn.BorderRadius = 5;
            this.captureBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.captureBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.captureBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.captureBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.captureBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.captureBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.captureBtn.ForeColor = System.Drawing.Color.White;
            this.captureBtn.Location = new System.Drawing.Point(239, 473);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(195, 45);
            this.captureBtn.TabIndex = 2;
            this.captureBtn.Text = "CAPTURE";
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(34, 473);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(195, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // camListCB
            // 
            this.camListCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.camListCB.BorderRadius = 5;
            this.camListCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.camListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camListCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.camListCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.camListCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.camListCB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.camListCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.camListCB.ItemHeight = 30;
            this.camListCB.Location = new System.Drawing.Point(34, 431);
            this.camListCB.MaximumSize = new System.Drawing.Size(1000, 0);
            this.camListCB.MinimumSize = new System.Drawing.Size(10, 0);
            this.camListCB.Name = "camListCB";
            this.camListCB.Size = new System.Drawing.Size(400, 36);
            this.camListCB.TabIndex = 29;
            this.camListCB.SelectedIndexChanged += new System.EventHandler(this.camListCB_SelectedIndexChanged);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.guna2GradientPanel1.Controls.Add(this.camPB);
            this.guna2GradientPanel1.Controls.Add(this.camListCB);
            this.guna2GradientPanel1.Controls.Add(this.captureBtn);
            this.guna2GradientPanel1.Controls.Add(this.cancelBtn);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(462, 541);
            this.guna2GradientPanel1.TabIndex = 30;
            // 
            // studentPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(482, 561);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentPictureForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "studentPictureForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentPictureForm_FormClosing);
            this.Load += new System.EventHandler(this.studentPictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camPB)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox camPB;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button captureBtn;
        private Guna.UI2.WinForms.Guna2ComboBox camListCB;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}