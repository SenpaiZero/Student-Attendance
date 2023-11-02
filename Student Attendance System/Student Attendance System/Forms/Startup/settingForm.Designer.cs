namespace Student_Attendance_System.Startup
{
    partial class settingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.outputContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.picLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.qrLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.headeLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dbConStringTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.dbStrinlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.advanceContainer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.applyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.resetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.themeCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.themeLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.displayContainer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.picOutputTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.qrOutputTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.outputContainer.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            // outputContainer
            // 
            this.outputContainer.Controls.Add(this.picOutputTB);
            this.outputContainer.Controls.Add(this.picLbl);
            this.outputContainer.Controls.Add(this.qrOutputTB);
            this.outputContainer.Controls.Add(this.qrLbl);
            this.outputContainer.Controls.Add(this.guna2HtmlLabel1);
            this.outputContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputContainer.Location = new System.Drawing.Point(10, 54);
            this.outputContainer.Name = "outputContainer";
            this.outputContainer.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.outputContainer.Size = new System.Drawing.Size(527, 184);
            this.outputContainer.TabIndex = 5;
            // 
            // picLbl
            // 
            this.picLbl.AutoSize = false;
            this.picLbl.BackColor = System.Drawing.Color.Transparent;
            this.picLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.picLbl.Location = new System.Drawing.Point(12, 106);
            this.picLbl.Name = "picLbl";
            this.picLbl.Size = new System.Drawing.Size(503, 35);
            this.picLbl.TabIndex = 7;
            this.picLbl.Text = "Picutre Output";
            // 
            // qrLbl
            // 
            this.qrLbl.AutoSize = false;
            this.qrLbl.BackColor = System.Drawing.Color.Transparent;
            this.qrLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.qrLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.qrLbl.Location = new System.Drawing.Point(12, 38);
            this.qrLbl.Name = "qrLbl";
            this.qrLbl.Size = new System.Drawing.Size(503, 33);
            this.qrLbl.TabIndex = 8;
            this.qrLbl.Text = "QR Code Output";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(133)))), ((int)(((byte)(46)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(503, 28);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "OUTPUT";
            // 
            // headeLbl
            // 
            this.headeLbl.AutoSize = false;
            this.headeLbl.AutoSizeHeightOnly = true;
            this.headeLbl.BackColor = System.Drawing.Color.Transparent;
            this.headeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headeLbl.Font = new System.Drawing.Font("Segoe UI Variable Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(133)))), ((int)(((byte)(46)))));
            this.headeLbl.Location = new System.Drawing.Point(10, 0);
            this.headeLbl.Name = "headeLbl";
            this.headeLbl.Size = new System.Drawing.Size(527, 54);
            this.headeLbl.TabIndex = 0;
            this.headeLbl.Text = "SETTING";
            this.headeLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.headeLbl.Click += new System.EventHandler(this.headeLbl_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dbConStringTB);
            this.guna2Panel2.Controls.Add(this.dbStrinlbl);
            this.guna2Panel2.Controls.Add(this.advanceContainer);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(10, 238);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.guna2Panel2.Size = new System.Drawing.Size(527, 121);
            this.guna2Panel2.TabIndex = 6;
            // 
            // dbConStringTB
            // 
            this.dbConStringTB.BorderRadius = 5;
            this.dbConStringTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dbConStringTB.DefaultText = "";
            this.dbConStringTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dbConStringTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dbConStringTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dbConStringTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dbConStringTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbConStringTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.dbConStringTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dbConStringTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dbConStringTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dbConStringTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.dbConStringTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.dbConStringTB.Location = new System.Drawing.Point(12, 74);
            this.dbConStringTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dbConStringTB.Name = "dbConStringTB";
            this.dbConStringTB.PasswordChar = '\0';
            this.dbConStringTB.PlaceholderText = "";
            this.dbConStringTB.SelectedText = "";
            this.dbConStringTB.Size = new System.Drawing.Size(503, 35);
            this.dbConStringTB.TabIndex = 10;
            // 
            // dbStrinlbl
            // 
            this.dbStrinlbl.AutoSize = false;
            this.dbStrinlbl.BackColor = System.Drawing.Color.Transparent;
            this.dbStrinlbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbStrinlbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbStrinlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.dbStrinlbl.Location = new System.Drawing.Point(12, 38);
            this.dbStrinlbl.Name = "dbStrinlbl";
            this.dbStrinlbl.Size = new System.Drawing.Size(503, 36);
            this.dbStrinlbl.TabIndex = 8;
            this.dbStrinlbl.Text = "DB Connection String";
            // 
            // advanceContainer
            // 
            this.advanceContainer.AutoSize = false;
            this.advanceContainer.BackColor = System.Drawing.Color.Transparent;
            this.advanceContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.advanceContainer.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advanceContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(133)))), ((int)(((byte)(46)))));
            this.advanceContainer.Location = new System.Drawing.Point(12, 10);
            this.advanceContainer.Name = "advanceContainer";
            this.advanceContainer.Size = new System.Drawing.Size(503, 28);
            this.advanceContainer.TabIndex = 6;
            this.advanceContainer.Text = "ADVANCE";
            // 
            // buttonContainer
            // 
            this.buttonContainer.Controls.Add(this.guna2Separator1);
            this.buttonContainer.Controls.Add(this.applyBtn);
            this.buttonContainer.Controls.Add(this.resetBtn);
            this.buttonContainer.Controls.Add(this.cancelBtn);
            this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonContainer.Location = new System.Drawing.Point(380, 10);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(135, 138);
            this.buttonContainer.TabIndex = 7;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.guna2Separator1.Location = new System.Drawing.Point(40, 44);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(70, 10);
            this.guna2Separator1.TabIndex = 7;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.BorderRadius = 10;
            this.applyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.applyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.applyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.applyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.applyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.applyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.applyBtn.Location = new System.Drawing.Point(30, 60);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(94, 34);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "APPLY";
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.BorderRadius = 10;
            this.resetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.resetBtn.Location = new System.Drawing.Point(30, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(94, 34);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "RESET";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BorderRadius = 10;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.cancelBtn.Location = new System.Drawing.Point(30, 100);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 34);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "CANCEL";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ComboBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.themeCB);
            this.guna2Panel1.Controls.Add(this.themeLbl);
            this.guna2Panel1.Controls.Add(this.displayContainer);
            this.guna2Panel1.Controls.Add(this.buttonContainer);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 359);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(527, 158);
            this.guna2Panel1.TabIndex = 5;
            // 
            // themeCB
            // 
            this.themeCB.BackColor = System.Drawing.Color.Transparent;
            this.themeCB.BorderRadius = 5;
            this.themeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.themeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.themeCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.themeCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.themeCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.themeCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.themeCB.ItemHeight = 30;
            this.themeCB.Location = new System.Drawing.Point(132, 50);
            this.themeCB.Name = "themeCB";
            this.themeCB.Size = new System.Drawing.Size(218, 36);
            this.themeCB.TabIndex = 9;
            // 
            // themeLbl
            // 
            this.themeLbl.AutoSize = false;
            this.themeLbl.BackColor = System.Drawing.Color.Transparent;
            this.themeLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.themeLbl.Location = new System.Drawing.Point(12, 50);
            this.themeLbl.Name = "themeLbl";
            this.themeLbl.Size = new System.Drawing.Size(89, 37);
            this.themeLbl.TabIndex = 8;
            this.themeLbl.Text = "Theme";
            // 
            // displayContainer
            // 
            this.displayContainer.AutoSize = false;
            this.displayContainer.BackColor = System.Drawing.Color.Transparent;
            this.displayContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayContainer.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(133)))), ((int)(((byte)(46)))));
            this.displayContainer.Location = new System.Drawing.Point(12, 10);
            this.displayContainer.Name = "displayContainer";
            this.displayContainer.Size = new System.Drawing.Size(368, 34);
            this.displayContainer.TabIndex = 6;
            this.displayContainer.Text = "DISPLAY";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 95);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(89, 37);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Language";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(132, 96);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(218, 36);
            this.guna2ComboBox1.TabIndex = 11;
            // 
            // picOutputTB
            // 
            this.picOutputTB.BorderRadius = 5;
            this.picOutputTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picOutputTB.DefaultText = "";
            this.picOutputTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.picOutputTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.picOutputTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.picOutputTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.picOutputTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.picOutputTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.picOutputTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.picOutputTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.picOutputTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.picOutputTB.IconRight = ((System.Drawing.Image)(resources.GetObject("picOutputTB.IconRight")));
            this.picOutputTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.picOutputTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.picOutputTB.Location = new System.Drawing.Point(12, 141);
            this.picOutputTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picOutputTB.Name = "picOutputTB";
            this.picOutputTB.PasswordChar = '\0';
            this.picOutputTB.PlaceholderText = "";
            this.picOutputTB.SelectedText = "";
            this.picOutputTB.Size = new System.Drawing.Size(503, 35);
            this.picOutputTB.TabIndex = 9;
            // 
            // qrOutputTB
            // 
            this.qrOutputTB.BorderRadius = 5;
            this.qrOutputTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qrOutputTB.DefaultText = "";
            this.qrOutputTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.qrOutputTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.qrOutputTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qrOutputTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qrOutputTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.qrOutputTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.qrOutputTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qrOutputTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.qrOutputTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qrOutputTB.IconRight = ((System.Drawing.Image)(resources.GetObject("qrOutputTB.IconRight")));
            this.qrOutputTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.qrOutputTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.qrOutputTB.Location = new System.Drawing.Point(12, 71);
            this.qrOutputTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qrOutputTB.Name = "qrOutputTB";
            this.qrOutputTB.PasswordChar = '\0';
            this.qrOutputTB.PlaceholderText = "";
            this.qrOutputTB.SelectedText = "";
            this.qrOutputTB.Size = new System.Drawing.Size(503, 35);
            this.qrOutputTB.TabIndex = 10;
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(547, 525);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.outputContainer);
            this.Controls.Add(this.headeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 40);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.settingForm_Load);
            this.outputContainer.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.buttonContainer.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox themeCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel themeLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel displayContainer;
        private Guna.UI2.WinForms.Guna2Panel buttonContainer;
        private Guna.UI2.WinForms.Guna2Button applyBtn;
        private Guna.UI2.WinForms.Guna2Button resetBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Panel outputContainer;
        private Guna.UI2.WinForms.Guna2TextBox picOutputTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel picLbl;
        private Guna.UI2.WinForms.Guna2TextBox qrOutputTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel qrLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox dbConStringTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel dbStrinlbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel advanceContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel headeLbl;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}