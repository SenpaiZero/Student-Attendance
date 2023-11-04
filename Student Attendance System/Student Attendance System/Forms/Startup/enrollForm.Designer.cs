namespace Student_Attendance_System.Startup
{
    partial class enrollForm
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
            this.headerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.backBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel.SuspendLayout();
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
            // headerLbl
            // 
            this.headerLbl.AutoSize = false;
            this.headerLbl.AutoSizeHeightOnly = true;
            this.headerLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.headerLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLbl.Font = new System.Drawing.Font("Segoe UI Variable Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.headerLbl.IsContextMenuEnabled = false;
            this.headerLbl.IsSelectionEnabled = false;
            this.headerLbl.Location = new System.Drawing.Point(0, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(705, 55);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.TabStop = false;
            this.headerLbl.Text = "ENROLL";
            this.headerLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.backBtn);
            this.mainPanel.Controls.Add(this.nextBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 55);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(705, 645);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint_1);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.backBtn.BorderRadius = 5;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(100)))), ((int)(((byte)(15)))));
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::Student_Attendance_System.Properties.Resources.left_arrow;
            this.backBtn.Location = new System.Drawing.Point(600, 591);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(42, 42);
            this.backBtn.TabIndex = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.nextBtn.BorderRadius = 5;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(100)))), ((int)(((byte)(15)))));
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Image = global::Student_Attendance_System.Properties.Resources.right_arrow;
            this.nextBtn.Location = new System.Drawing.Point(648, 591);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(42, 42);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // enrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(705, 700);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "enrollForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "vb ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.enrollForm_FormClosed);
            this.Load += new System.EventHandler(this.attendanceForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerLbl;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Button backBtn;
        private Guna.UI2.WinForms.Guna2Button nextBtn;
    }
}