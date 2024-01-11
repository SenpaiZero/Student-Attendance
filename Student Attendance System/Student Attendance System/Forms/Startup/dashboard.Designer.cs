namespace Student_Attendance_System.Forms.Startup
{
    partial class dashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.appNameLbl = new Guna.UI2.WinForms.Guna2Button();
            this.statsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.graphBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.graphBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.statsBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.appNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // appNameLbl
            // 
            this.appNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.appNameLbl, 2);
            this.appNameLbl.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.appNameLbl.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.appNameLbl.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.appNameLbl.DisabledState.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold);
            this.appNameLbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.appNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appNameLbl.Enabled = false;
            this.appNameLbl.FillColor = System.Drawing.Color.Transparent;
            this.appNameLbl.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.appNameLbl.ImageSize = new System.Drawing.Size(40, 40);
            this.appNameLbl.Location = new System.Drawing.Point(3, 3);
            this.appNameLbl.Name = "appNameLbl";
            this.appNameLbl.Size = new System.Drawing.Size(699, 43);
            this.appNameLbl.TabIndex = 14;
            this.appNameLbl.TabStop = false;
            this.appNameLbl.Text = "DASHBOARD";
            this.appNameLbl.UseTransparentBackground = true;
            // 
            // statsBtn
            // 
            this.statsBtn.BorderRadius = 5;
            this.statsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.statsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.statsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.statsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.statsBtn.Location = new System.Drawing.Point(5, 54);
            this.statsBtn.Margin = new System.Windows.Forms.Padding(5, 5, 2, 5);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(345, 39);
            this.statsBtn.TabIndex = 36;
            this.statsBtn.TabStop = false;
            this.statsBtn.Text = "STATISTICS";
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // graphBtn
            // 
            this.graphBtn.BorderRadius = 5;
            this.graphBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.graphBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.graphBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.graphBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.graphBtn.Location = new System.Drawing.Point(354, 54);
            this.graphBtn.Margin = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(346, 39);
            this.graphBtn.TabIndex = 37;
            this.graphBtn.TabStop = false;
            this.graphBtn.Text = "ATTENDANCE GRAPH";
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // mainPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.mainPanel, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 101);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(699, 596);
            this.mainPanel.TabIndex = 38;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(705, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button appNameLbl;
        private Guna.UI2.WinForms.Guna2Button graphBtn;
        private Guna.UI2.WinForms.Guna2Button statsBtn;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
    }
}