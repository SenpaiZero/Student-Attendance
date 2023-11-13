using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Startup
{
    public partial class recordForm : Form
    {
        public recordForm()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void absentBtn_Click(object sender, EventArgs e)
        {
            if (viewBtn.Text == "PRESENTS")
                viewBtn.Text = "ABSENTS";
            else
                viewBtn.Text = "PRESENTS";

            showData();
            
        }
        void showAbsent()
        {
            int i;
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query = "SELECT d.StudentID, d.Name FROM studentData d " +
                           "WHERE NOT EXISTS (SELECT 1 FROM attendance a " +
                           $"WHERE a.StudentID = d.StudentID AND a.Date = '{datePicker.Value.Date}')";

            if (!string.IsNullOrEmpty(searchTB.Text))
            {
                if (int.TryParse(searchTB.Text, out i))
                    query += $" AND d.StudentID LIKE '%{searchTB.Text}%'";
                else
                    query += $" AND d.Name LIKE '%{searchTB.Text}%'";
            }

            using (db.cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listTable.DataSource = dt;
            }

            // Modify column headers
            listTable.Columns["StudentID"].HeaderText = "STUDENT ID";
            listTable.Columns["Name"].HeaderText = "NAME";

            removeActionBtn();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "presentBtn";
                button.HeaderText = "ACTION";
                button.Text = "PRESENT";
                button.UseColumnTextForButtonValue = true; 
                this.listTable.Columns.Add(button);
            }
            listTable.Columns["presentBtn"].Width = 80;

            // Hook up the event handler for the button click
            //listTable.CellContentClick += new DataGridViewCellEventHandler(listTable_AbsentButtonClick);
        }
        void showPresent()
        {
            int i;
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query = "SELECT a.StudentID, d.Name, a.TimeIn, a.TimeOut FROM attendance a " +
                   "JOIN studentData d ON a.StudentID = d.StudentID";

            if (!string.IsNullOrEmpty(searchTB.Text))
            {
                if (int.TryParse(searchTB.Text, out i))
                    query += $" WHERE d.StudentID LIKE '%{searchTB.Text}%'";
                else
                    query += $" WHERE d.Name LIKE '%{searchTB.Text}%'";

                query += $" AND a.Date = '{datePicker.Value.Date}'";
            }
            else
            {
                query += $" WHERE a.Date = '{datePicker.Value.Date}'";
            }

            removeActionBtn();
            using (db.cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listTable.DataSource = dt;
            }


            // Modify column headers
            listTable.Columns["StudentID"].HeaderText = "STUDENT ID";
            listTable.Columns["Name"].HeaderText = "NAME";
            listTable.Columns["TimeIn"].HeaderText = "TIME IN";
            listTable.Columns["TimeOut"].HeaderText = "TIME OUT";

            if (listTable.Columns.Contains("absentBtn"))
                listTable.Columns.Remove("absentBtn");

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "absentBtn";
                button.HeaderText = "ACTION";
                button.Text = "ABSENT";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.listTable.Columns.Add(button);
            }
            listTable.Columns["absentBtn"].Width = 80;
        }
        void removeActionBtn()
        {
            if (listTable.Columns.Contains("presentBtn"))
                listTable.Columns.Remove("presentBtn");
            if (listTable.Columns.Contains("absentBtn"))
                listTable.Columns.Remove("absentBtn");
        }

        void showData()
        {
            if(viewBtn.Text == "ABSENTS")
            {
                showAbsent();
            }
            else
            {
                showPresent();
            }
        }

        private void recordForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(viewBtn.Text == "ABSENTS")
            {
                if (e.ColumnIndex == listTable.Columns["presentBtn"].Index && e.RowIndex >= 0)
                {
                    MessageBox.Show("Button clicked in row " + e.RowIndex.ToString());
                }
            }
            else
            {
                if (e.ColumnIndex == listTable.Columns["absentBtn"].Index && e.RowIndex >= 0)
                {
                    MessageBox.Show("Button clicked in row " + e.RowIndex.ToString());
                }
            }
            
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            showData();
        }
    }
}
