namespace Student_Attendance_System.Startup
{
    partial class studentForm
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
            this.qrScanning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.secondPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.settingContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.popupCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.camList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.scannerList = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrScanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic)).BeginInit();
            this.settingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // qrScanning
            // 
            this.qrScanning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.qrScanning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrScanning.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.qrScanning.ImageRotate = 0F;
            this.qrScanning.Location = new System.Drawing.Point(0, 0);
            this.qrScanning.Name = "qrScanning";
            this.qrScanning.Size = new System.Drawing.Size(705, 700);
            this.qrScanning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrScanning.TabIndex = 1;
            this.qrScanning.TabStop = false;
            // 
            // secondPic
            // 
            this.secondPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.secondPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.secondPic.BorderRadius = 5;
            this.secondPic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.secondPic.ImageRotate = 0F;
            this.secondPic.Location = new System.Drawing.Point(381, 377);
            this.secondPic.Name = "secondPic";
            this.secondPic.Size = new System.Drawing.Size(300, 300);
            this.secondPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondPic.TabIndex = 2;
            this.secondPic.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton1.Image = global::Student_Attendance_System.Properties.Resources.setting;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 646);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // settingContainer
            // 
            this.settingContainer.BorderRadius = 5;
            this.settingContainer.Controls.Add(this.guna2HtmlLabel2);
            this.settingContainer.Controls.Add(this.guna2HtmlLabel1);
            this.settingContainer.Controls.Add(this.popupCB);
            this.settingContainer.Controls.Add(this.camList);
            this.settingContainer.Controls.Add(this.scannerList);
            this.settingContainer.Location = new System.Drawing.Point(70, 477);
            this.settingContainer.Name = "settingContainer";
            this.settingContainer.Size = new System.Drawing.Size(250, 219);
            this.settingContainer.TabIndex = 4;
            this.settingContainer.Visible = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 16);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(151, 27);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "SCANNER CAM";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 95);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(127, 27);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "PIC CAMERA";
            // 
            // popupCB
            // 
            this.popupCB.AutoSize = true;
            this.popupCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.popupCB.CheckedState.BorderRadius = 0;
            this.popupCB.CheckedState.BorderThickness = 0;
            this.popupCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.popupCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.popupCB.Location = new System.Drawing.Point(21, 180);
            this.popupCB.Name = "popupCB";
            this.popupCB.Size = new System.Drawing.Size(111, 20);
            this.popupCB.TabIndex = 2;
            this.popupCB.Text = "SHOW DATA";
            this.popupCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.popupCB.UncheckedState.BorderRadius = 0;
            this.popupCB.UncheckedState.BorderThickness = 0;
            this.popupCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.popupCB.CheckedChanged += new System.EventHandler(this.popupCB_CheckedChanged);
            // 
            // camList
            // 
            this.camList.BackColor = System.Drawing.Color.Transparent;
            this.camList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.camList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.camList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.camList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.camList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.camList.ItemHeight = 30;
            this.camList.Location = new System.Drawing.Point(21, 128);
            this.camList.Name = "camList";
            this.camList.Size = new System.Drawing.Size(207, 36);
            this.camList.TabIndex = 1;
            this.camList.SelectedIndexChanged += new System.EventHandler(this.camList_SelectedIndexChanged);
            // 
            // scannerList
            // 
            this.scannerList.BackColor = System.Drawing.Color.Transparent;
            this.scannerList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scannerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scannerList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scannerList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scannerList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scannerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.scannerList.ItemHeight = 30;
            this.scannerList.Location = new System.Drawing.Point(21, 49);
            this.scannerList.Name = "scannerList";
            this.scannerList.Size = new System.Drawing.Size(207, 36);
            this.scannerList.TabIndex = 0;
            this.scannerList.SelectedIndexChanged += new System.EventHandler(this.scannerList_SelectedIndexChanged);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(705, 700);
            this.ControlBox = false;
            this.Controls.Add(this.settingContainer);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.secondPic);
            this.Controls.Add(this.qrScanning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "studentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "studentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentForm_FormClosing);
            this.Load += new System.EventHandler(this.studentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrScanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPic)).EndInit();
            this.settingContainer.ResumeLayout(false);
            this.settingContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox secondPic;
        private Guna.UI2.WinForms.Guna2PictureBox qrScanning;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Panel settingContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox popupCB;
        private Guna.UI2.WinForms.Guna2ComboBox camList;
        private Guna.UI2.WinForms.Guna2ComboBox scannerList;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}