namespace Student_Attendance_System.Forms
{
    partial class changePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePasswordForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.newPassTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.currentLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.newpassLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.reEnterPassTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.currentPassTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.reenterPassLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // newPassTB
            // 
            this.newPassTB.BorderRadius = 5;
            this.newPassTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassTB.DefaultText = "";
            this.newPassTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPassTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPassTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.newPassTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPassTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPassTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPassTB.IconRight = ((System.Drawing.Image)(resources.GetObject("newPassTB.IconRight")));
            this.newPassTB.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.newPassTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.newPassTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.newPassTB.Location = new System.Drawing.Point(30, 124);
            this.newPassTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPassTB.Name = "newPassTB";
            this.newPassTB.PasswordChar = '●';
            this.newPassTB.PlaceholderText = "";
            this.newPassTB.SelectedText = "";
            this.newPassTB.Size = new System.Drawing.Size(423, 35);
            this.newPassTB.TabIndex = 12;
            this.newPassTB.UseSystemPasswordChar = true;
            this.newPassTB.IconRightClick += new System.EventHandler(this.newPassTB_IconRightClick);
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = false;
            this.currentLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.currentLbl.IsContextMenuEnabled = false;
            this.currentLbl.IsSelectionEnabled = false;
            this.currentLbl.Location = new System.Drawing.Point(30, 20);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(443, 36);
            this.currentLbl.TabIndex = 11;
            this.currentLbl.TabStop = false;
            this.currentLbl.Text = "CURRENT PASSWORD";
            // 
            // newpassLbl
            // 
            this.newpassLbl.AutoSize = false;
            this.newpassLbl.BackColor = System.Drawing.Color.Transparent;
            this.newpassLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.newpassLbl.IsContextMenuEnabled = false;
            this.newpassLbl.IsSelectionEnabled = false;
            this.newpassLbl.Location = new System.Drawing.Point(30, 91);
            this.newpassLbl.Name = "newpassLbl";
            this.newpassLbl.Size = new System.Drawing.Size(423, 33);
            this.newpassLbl.TabIndex = 13;
            this.newpassLbl.TabStop = false;
            this.newpassLbl.Text = "NEW PASSWORD";
            // 
            // reEnterPassTB
            // 
            this.reEnterPassTB.BorderRadius = 5;
            this.reEnterPassTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reEnterPassTB.DefaultText = "";
            this.reEnterPassTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reEnterPassTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reEnterPassTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reEnterPassTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reEnterPassTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.reEnterPassTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reEnterPassTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reEnterPassTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reEnterPassTB.IconRight = ((System.Drawing.Image)(resources.GetObject("reEnterPassTB.IconRight")));
            this.reEnterPassTB.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.reEnterPassTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.reEnterPassTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.reEnterPassTB.Location = new System.Drawing.Point(30, 195);
            this.reEnterPassTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reEnterPassTB.Name = "reEnterPassTB";
            this.reEnterPassTB.PasswordChar = '●';
            this.reEnterPassTB.PlaceholderText = "";
            this.reEnterPassTB.SelectedText = "";
            this.reEnterPassTB.Size = new System.Drawing.Size(423, 35);
            this.reEnterPassTB.TabIndex = 14;
            this.reEnterPassTB.UseSystemPasswordChar = true;
            this.reEnterPassTB.IconRightClick += new System.EventHandler(this.reEnterPassTB_IconRightClick);
            // 
            // currentPassTB
            // 
            this.currentPassTB.BorderRadius = 5;
            this.currentPassTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentPassTB.DefaultText = "";
            this.currentPassTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentPassTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentPassTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPassTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentPassTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.currentPassTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPassTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.currentPassTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.currentPassTB.IconRight = ((System.Drawing.Image)(resources.GetObject("currentPassTB.IconRight")));
            this.currentPassTB.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.currentPassTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.currentPassTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.currentPassTB.Location = new System.Drawing.Point(30, 49);
            this.currentPassTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentPassTB.Name = "currentPassTB";
            this.currentPassTB.PasswordChar = '●';
            this.currentPassTB.PlaceholderText = "";
            this.currentPassTB.SelectedText = "";
            this.currentPassTB.Size = new System.Drawing.Size(423, 35);
            this.currentPassTB.TabIndex = 16;
            this.currentPassTB.UseSystemPasswordChar = true;
            this.currentPassTB.IconRightClick += new System.EventHandler(this.currentPassTB_IconRightClick);
            // 
            // reenterPassLbl
            // 
            this.reenterPassLbl.AutoSize = false;
            this.reenterPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.reenterPassLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenterPassLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.reenterPassLbl.IsContextMenuEnabled = false;
            this.reenterPassLbl.IsSelectionEnabled = false;
            this.reenterPassLbl.Location = new System.Drawing.Point(30, 159);
            this.reenterPassLbl.Name = "reenterPassLbl";
            this.reenterPassLbl.Size = new System.Drawing.Size(423, 36);
            this.reenterPassLbl.TabIndex = 15;
            this.reenterPassLbl.TabStop = false;
            this.reenterPassLbl.Text = "RE-ENTER PASSWORD";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Variable Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.guna2HtmlLabel3.IsContextMenuEnabled = false;
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(20, 15);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(479, 83);
            this.guna2HtmlLabel3.TabIndex = 17;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "CHANGE PASSWORD";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.guna2Panel1.Controls.Add(this.cancelBtn);
            this.guna2Panel1.Controls.Add(this.updateBtn);
            this.guna2Panel1.Controls.Add(this.reEnterPassTB);
            this.guna2Panel1.Controls.Add(this.reenterPassLbl);
            this.guna2Panel1.Controls.Add(this.newPassTB);
            this.guna2Panel1.Controls.Add(this.newpassLbl);
            this.guna2Panel1.Controls.Add(this.currentPassTB);
            this.guna2Panel1.Controls.Add(this.currentLbl);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 99);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(479, 335);
            this.guna2Panel1.TabIndex = 18;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.Tomato;
            this.cancelBtn.Location = new System.Drawing.Point(192, 288);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 26);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateBtn.BorderRadius = 5;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.updateBtn.Location = new System.Drawing.Point(152, 237);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(180, 45);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.guna2Panel2.Size = new System.Drawing.Size(519, 454);
            this.guna2Panel2.TabIndex = 19;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel2;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(529, 464);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changePasswordForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "changePasswordForm";
            this.Load += new System.EventHandler(this.changePasswordForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox newPassTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel currentLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox currentPassTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel reenterPassLbl;
        private Guna.UI2.WinForms.Guna2TextBox reEnterPassTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel newpassLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}