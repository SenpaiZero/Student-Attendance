namespace Student_Attendance_System
{
    partial class loadingForm
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
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.titleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loadTimer = new System.Windows.Forms.Timer(this.components);
            this.descLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(120, 75);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(111, 106);
            this.guna2WinProgressIndicator1.TabIndex = 1;
            this.guna2WinProgressIndicator1.UseTransparentBackground = true;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = false;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Variable Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.titleLbl.Location = new System.Drawing.Point(12, 212);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(328, 45);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "LOADING";
            this.titleLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadTimer
            // 
            this.loadTimer.Tick += new System.EventHandler(this.loadTimer_Tick);
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = false;
            this.descLbl.BackColor = System.Drawing.Color.Transparent;
            this.descLbl.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.descLbl.Location = new System.Drawing.Point(12, 263);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(328, 175);
            this.descLbl.TabIndex = 3;
            this.descLbl.Text = "TESTING TESTING TESTING TESTING TESTING TESTING TESTING TESTING TESTING TESTING T" +
    "ESTING TESTING TESTING TESTING TESTING TESTING TESTING ";
            this.descLbl.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.ControlBox = false;
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.guna2WinProgressIndicator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadingForm";
            this.Load += new System.EventHandler(this.loadingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLbl;
        private System.Windows.Forms.Timer loadTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel descLbl;
    }
}