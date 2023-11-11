namespace Student_Attendance_System.Forms.Admin
{
    partial class updateStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateStaffForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.isAdminCB = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.adminLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.statusCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addressTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.addressLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ageTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ageLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phoneTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.genderCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.statusLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.genderLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // updateBtn
            // 
            this.updateBtn.BorderRadius = 5;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.updateBtn.Location = new System.Drawing.Point(405, 432);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(20);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(113, 58);
            this.updateBtn.TabIndex = 43;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.nameTB.BorderRadius = 5;
            this.nameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.DefaultText = "";
            this.nameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.nameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.nameTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.nameTB.Location = new System.Drawing.Point(20, 58);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTB.MaximumSize = new System.Drawing.Size(1000, 60);
            this.nameTB.MaxLength = 49;
            this.nameTB.MinimumSize = new System.Drawing.Size(10, 10);
            this.nameTB.Name = "nameTB";
            this.nameTB.PasswordChar = '\0';
            this.nameTB.PlaceholderText = "";
            this.nameTB.SelectedText = "";
            this.nameTB.Size = new System.Drawing.Size(498, 49);
            this.nameTB.TabIndex = 41;
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.nameLbl.IsContextMenuEnabled = false;
            this.nameLbl.IsSelectionEnabled = false;
            this.nameLbl.Location = new System.Drawing.Point(20, 16);
            this.nameLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(250, 29);
            this.nameLbl.TabIndex = 40;
            this.nameLbl.TabStop = false;
            this.nameLbl.Text = "FULL NAME";
            this.nameLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isAdminCB
            // 
            this.isAdminCB.BackColor = System.Drawing.Color.Transparent;
            this.isAdminCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.isAdminCB.CheckedState.BorderRadius = 2;
            this.isAdminCB.CheckedState.BorderThickness = 0;
            this.isAdminCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.isAdminCB.Location = new System.Drawing.Point(406, 369);
            this.isAdminCB.Margin = new System.Windows.Forms.Padding(10);
            this.isAdminCB.Name = "isAdminCB";
            this.isAdminCB.Size = new System.Drawing.Size(38, 49);
            this.isAdminCB.TabIndex = 44;
            this.isAdminCB.Text = "guna2CustomCheckBox1";
            this.isAdminCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.isAdminCB.UncheckedState.BorderRadius = 2;
            this.isAdminCB.UncheckedState.BorderThickness = 0;
            this.isAdminCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.isAdminCB.UseTransparentBackground = true;
            this.isAdminCB.Click += new System.EventHandler(this.isAdminCB_Click);
            // 
            // adminLbl
            // 
            this.adminLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.adminLbl.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.adminLbl.IsContextMenuEnabled = false;
            this.adminLbl.IsSelectionEnabled = false;
            this.adminLbl.Location = new System.Drawing.Point(445, 375);
            this.adminLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.adminLbl.Name = "adminLbl";
            this.adminLbl.Size = new System.Drawing.Size(250, 24);
            this.adminLbl.TabIndex = 45;
            this.adminLbl.TabStop = false;
            this.adminLbl.Text = "ADMIN";
            this.adminLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusCB
            // 
            this.statusCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.statusCB.BorderRadius = 5;
            this.statusCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.statusCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusCB.ItemHeight = 30;
            this.statusCB.Items.AddRange(new object[] {
            "SINGLE",
            "MARRIED",
            "ENGAGED",
            "WIDOWED"});
            this.statusCB.Location = new System.Drawing.Point(20, 473);
            this.statusCB.MaximumSize = new System.Drawing.Size(1000, 0);
            this.statusCB.MinimumSize = new System.Drawing.Size(10, 0);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(166, 36);
            this.statusCB.TabIndex = 42;
            this.statusCB.Leave += new System.EventHandler(this.statusCB_Leave);
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.addressTB.BorderRadius = 5;
            this.addressTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addressTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTB.DefaultText = "";
            this.addressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.addressTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.addressTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.addressTB.Location = new System.Drawing.Point(20, 159);
            this.addressTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTB.MaximumSize = new System.Drawing.Size(1000, 60);
            this.addressTB.MaxLength = 100;
            this.addressTB.MinimumSize = new System.Drawing.Size(10, 10);
            this.addressTB.Name = "addressTB";
            this.addressTB.PasswordChar = '\0';
            this.addressTB.PlaceholderText = "";
            this.addressTB.SelectedText = "";
            this.addressTB.Size = new System.Drawing.Size(498, 49);
            this.addressTB.TabIndex = 47;
            this.addressTB.Leave += new System.EventHandler(this.addressTB_Leave);
            // 
            // addressLbl
            // 
            this.addressLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.addressLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.addressLbl.IsContextMenuEnabled = false;
            this.addressLbl.IsSelectionEnabled = false;
            this.addressLbl.Location = new System.Drawing.Point(20, 117);
            this.addressLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(250, 29);
            this.addressLbl.TabIndex = 46;
            this.addressLbl.TabStop = false;
            this.addressLbl.Text = "ADDRESS";
            this.addressLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ageTB
            // 
            this.ageTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ageTB.BorderRadius = 5;
            this.ageTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ageTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTB.DefaultText = "";
            this.ageTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ageTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ageTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.ageTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ageTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.ageTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.ageTB.Location = new System.Drawing.Point(406, 269);
            this.ageTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ageTB.MaximumSize = new System.Drawing.Size(1000, 60);
            this.ageTB.MaxLength = 2;
            this.ageTB.MinimumSize = new System.Drawing.Size(10, 10);
            this.ageTB.Name = "ageTB";
            this.ageTB.PasswordChar = '\0';
            this.ageTB.PlaceholderText = "";
            this.ageTB.SelectedText = "";
            this.ageTB.Size = new System.Drawing.Size(112, 49);
            this.ageTB.TabIndex = 49;
            this.ageTB.Leave += new System.EventHandler(this.ageTB_Leave);
            // 
            // ageLbl
            // 
            this.ageLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ageLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.ageLbl.IsContextMenuEnabled = false;
            this.ageLbl.IsSelectionEnabled = false;
            this.ageLbl.Location = new System.Drawing.Point(406, 227);
            this.ageLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(250, 29);
            this.ageLbl.TabIndex = 48;
            this.ageLbl.TabStop = false;
            this.ageLbl.Text = "AGE";
            this.ageLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.emailTB.BorderRadius = 5;
            this.emailTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTB.DefaultText = "";
            this.emailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.emailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.emailTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.emailTB.Location = new System.Drawing.Point(20, 269);
            this.emailTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTB.MaximumSize = new System.Drawing.Size(1000, 60);
            this.emailTB.MaxLength = 49;
            this.emailTB.MinimumSize = new System.Drawing.Size(10, 10);
            this.emailTB.Name = "emailTB";
            this.emailTB.PasswordChar = '\0';
            this.emailTB.PlaceholderText = "";
            this.emailTB.SelectedText = "";
            this.emailTB.Size = new System.Drawing.Size(380, 49);
            this.emailTB.TabIndex = 51;
            this.emailTB.Leave += new System.EventHandler(this.emailTB_Leave);
            // 
            // emailLbl
            // 
            this.emailLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.emailLbl.IsContextMenuEnabled = false;
            this.emailLbl.IsSelectionEnabled = false;
            this.emailLbl.Location = new System.Drawing.Point(20, 227);
            this.emailLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(250, 29);
            this.emailLbl.TabIndex = 50;
            this.emailLbl.TabStop = false;
            this.emailLbl.Text = "EMAIL ADDRESS";
            this.emailLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.phoneTB.BorderRadius = 5;
            this.phoneTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.phoneTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTB.DefaultText = "";
            this.phoneTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.phoneTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.phoneTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.phoneTB.Location = new System.Drawing.Point(20, 369);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTB.MaximumSize = new System.Drawing.Size(1000, 60);
            this.phoneTB.MaxLength = 11;
            this.phoneTB.MinimumSize = new System.Drawing.Size(10, 10);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.PasswordChar = '\0';
            this.phoneTB.PlaceholderText = "";
            this.phoneTB.SelectedText = "";
            this.phoneTB.Size = new System.Drawing.Size(380, 49);
            this.phoneTB.TabIndex = 53;
            this.phoneTB.Leave += new System.EventHandler(this.phoneTB_Leave);
            // 
            // phoneLbl
            // 
            this.phoneLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.phoneLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.phoneLbl.IsContextMenuEnabled = false;
            this.phoneLbl.IsSelectionEnabled = false;
            this.phoneLbl.Location = new System.Drawing.Point(20, 327);
            this.phoneLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(250, 29);
            this.phoneLbl.TabIndex = 52;
            this.phoneLbl.TabStop = false;
            this.phoneLbl.Text = "PHONE NUMBER";
            this.phoneLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genderCB
            // 
            this.genderCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.genderCB.BorderRadius = 5;
            this.genderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.genderCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.genderCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderCB.ItemHeight = 30;
            this.genderCB.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.genderCB.Location = new System.Drawing.Point(202, 473);
            this.genderCB.MaximumSize = new System.Drawing.Size(1000, 0);
            this.genderCB.MinimumSize = new System.Drawing.Size(10, 0);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(166, 36);
            this.genderCB.TabIndex = 54;
            this.genderCB.Leave += new System.EventHandler(this.genderCB_Leave);
            // 
            // statusLbl
            // 
            this.statusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.statusLbl.IsContextMenuEnabled = false;
            this.statusLbl.IsSelectionEnabled = false;
            this.statusLbl.Location = new System.Drawing.Point(20, 432);
            this.statusLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(250, 29);
            this.statusLbl.TabIndex = 55;
            this.statusLbl.TabStop = false;
            this.statusLbl.Text = "STATUS";
            this.statusLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genderLbl
            // 
            this.genderLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.genderLbl.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(159)))), ((int)(((byte)(90)))));
            this.genderLbl.IsContextMenuEnabled = false;
            this.genderLbl.IsSelectionEnabled = false;
            this.genderLbl.Location = new System.Drawing.Point(202, 432);
            this.genderLbl.MinimumSize = new System.Drawing.Size(250, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(250, 29);
            this.genderLbl.TabIndex = 56;
            this.genderLbl.TabStop = false;
            this.genderLbl.Text = "GENDER";
            this.genderLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.cancelBtn.Location = new System.Drawing.Point(418, 495);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(88, 28);
            this.cancelBtn.TabIndex = 57;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.guna2Panel1.Controls.Add(this.nameLbl);
            this.guna2Panel1.Controls.Add(this.adminLbl);
            this.guna2Panel1.Controls.Add(this.phoneLbl);
            this.guna2Panel1.Controls.Add(this.addressLbl);
            this.guna2Panel1.Controls.Add(this.emailLbl);
            this.guna2Panel1.Controls.Add(this.ageLbl);
            this.guna2Panel1.Controls.Add(this.cancelBtn);
            this.guna2Panel1.Controls.Add(this.statusCB);
            this.guna2Panel1.Controls.Add(this.isAdminCB);
            this.guna2Panel1.Controls.Add(this.genderCB);
            this.guna2Panel1.Controls.Add(this.nameTB);
            this.guna2Panel1.Controls.Add(this.phoneTB);
            this.guna2Panel1.Controls.Add(this.updateBtn);
            this.guna2Panel1.Controls.Add(this.emailTB);
            this.guna2Panel1.Controls.Add(this.addressTB);
            this.guna2Panel1.Controls.Add(this.ageTB);
            this.guna2Panel1.Controls.Add(this.genderLbl);
            this.guna2Panel1.Controls.Add(this.statusLbl);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(534, 539);
            this.guna2Panel1.TabIndex = 58;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            this.errorProvider1.RightToLeft = true;
            // 
            // updateStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(574, 579);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateStaffForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "updateStaffForm";
            this.Load += new System.EventHandler(this.updateStaffForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameLbl;
        private Guna.UI2.WinForms.Guna2CustomCheckBox isAdminCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel adminLbl;
        private Guna.UI2.WinForms.Guna2ComboBox statusCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel genderLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel statusLbl;
        private Guna.UI2.WinForms.Guna2ComboBox genderCB;
        private Guna.UI2.WinForms.Guna2TextBox phoneTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel phoneLbl;
        private Guna.UI2.WinForms.Guna2TextBox emailTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel emailLbl;
        private Guna.UI2.WinForms.Guna2TextBox ageTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel ageLbl;
        private Guna.UI2.WinForms.Guna2TextBox addressTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel addressLbl;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}