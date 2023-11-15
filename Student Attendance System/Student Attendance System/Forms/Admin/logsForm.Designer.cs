namespace Student_Attendance_System.Forms.Admin
{
    partial class logsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.listTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.searchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.categoryCB = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // listTable
            // 
            this.listTable.AllowUserToAddRows = false;
            this.listTable.AllowUserToDeleteRows = false;
            this.listTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.listTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listTable.ColumnHeadersHeight = 30;
            this.listTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.listTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.listTable.Location = new System.Drawing.Point(8, 73);
            this.listTable.MultiSelect = false;
            this.listTable.Name = "listTable";
            this.listTable.ReadOnly = true;
            this.listTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listTable.RowHeadersVisible = false;
            this.listTable.RowHeadersWidth = 51;
            this.listTable.RowTemplate.Height = 26;
            this.listTable.Size = new System.Drawing.Size(668, 473);
            this.listTable.TabIndex = 0;
            this.listTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.listTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.listTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listTable.ThemeStyle.HeaderStyle.Height = 30;
            this.listTable.ThemeStyle.ReadOnly = true;
            this.listTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listTable.ThemeStyle.RowsStyle.Height = 26;
            this.listTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.DragForm = false;
            this.guna2BorderlessForm2.HasFormShadow = false;
            this.guna2BorderlessForm2.ResizeForm = false;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.94853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.05147F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 554);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.dateCB, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.datePicker, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchTB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.categoryCB, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 59);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dateCB
            // 
            this.dateCB.BackColor = System.Drawing.Color.Transparent;
            this.dateCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.dateCB.BorderRadius = 5;
            this.dateCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.dateCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.dateCB.ItemHeight = 15;
            this.dateCB.Items.AddRange(new object[] {
            "ALL DATES",
            "YEAR",
            "MONTH",
            "DAY"});
            this.dateCB.Location = new System.Drawing.Point(503, 32);
            this.dateCB.Name = "dateCB";
            this.dateCB.Size = new System.Drawing.Size(162, 21);
            this.dateCB.TabIndex = 43;
            this.dateCB.SelectedIndexChanged += new System.EventHandler(this.dateCB_SelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.Checked = true;
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(503, 3);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(162, 23);
            this.datePicker.TabIndex = 42;
            this.datePicker.Value = new System.DateTime(2023, 11, 13, 2, 11, 34, 331);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            this.datePicker.CloseUp += new System.EventHandler(this.datePicker_CloseUp);
            this.datePicker.Click += new System.EventHandler(this.datePicker_Click);
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.searchTB.BorderRadius = 5;
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.DefaultText = "";
            this.searchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.searchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.IconRightOffset = new System.Drawing.Point(5, 0);
            this.searchTB.IconRightSize = new System.Drawing.Size(25, 25);
            this.searchTB.Location = new System.Drawing.Point(3, 4);
            this.searchTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTB.MaximumSize = new System.Drawing.Size(1000, 45);
            this.searchTB.MinimumSize = new System.Drawing.Size(10, 10);
            this.searchTB.Name = "searchTB";
            this.searchTB.PasswordChar = '\0';
            this.searchTB.PlaceholderText = "Search";
            this.tableLayoutPanel2.SetRowSpan(this.searchTB, 2);
            this.searchTB.SelectedText = "";
            this.searchTB.Size = new System.Drawing.Size(227, 45);
            this.searchTB.TabIndex = 32;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // categoryCB
            // 
            this.categoryCB.BackColor = System.Drawing.Color.Transparent;
            this.categoryCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.categoryCB.BorderRadius = 5;
            this.categoryCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.categoryCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categoryCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(240)))), ((int)(((byte)(211)))));
            this.categoryCB.ItemHeight = 40;
            this.categoryCB.Items.AddRange(new object[] {
            "ALL CATEGORIES",
            "ALL ADMIN",
            "ALL STUDENT",
            "ADD STAFF",
            "DELETE STAFF",
            "UPDATE STAFF",
            "UPDATE ENROLL",
            "NEW ENROLL",
            "UPDATE STUDENT",
            "ATTENDANCE",
            "SETTINGS"});
            this.categoryCB.Location = new System.Drawing.Point(236, 3);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(261, 46);
            this.categoryCB.TabIndex = 33;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // logsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(684, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "logsForm";
            this.Text = "logsForm";
            this.Load += new System.EventHandler(this.logsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView listTable;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2TextBox searchTB;
        private Guna.UI2.WinForms.Guna2ComboBox categoryCB;
        private Guna.UI2.WinForms.Guna2ComboBox dateCB;
    }
}