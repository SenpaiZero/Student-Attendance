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

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void presentBtn_Click(object sender, EventArgs e)
        {

        }

        private void absentBtn_Click(object sender, EventArgs e)
        {

        }

        void showPresent(bool isSearch)
        {
            int i;
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query = "SELECT a.StudentID, d.Name, a.Date, a.TimeIn, a.TimeOut FROM attendance a " +
                   "JOIN studentData d ON a.StudentID = d.StudentID";

            if (isSearch)
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
            listTable.Columns["Date"].HeaderText = "DATE";
            listTable.Columns["TimeIn"].HeaderText = "TIME IN";
            listTable.Columns["TimeOut"].HeaderText = "TIME OUT";

            if (listTable.Columns.Contains("absentBtn"))
            {
                listTable.Columns.Remove("absentBtn");
            }
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "absentBtn";
                button.HeaderText = "ACTION";
                button.Text = "ABSENT";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.listTable.Columns.Add(button);
            }
        }

        private void recordForm_Load(object sender, EventArgs e)
        {
            showPresent(false);
        }

        private void listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == listTable.Columns["absentBtn"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("Button clicked in row " + e.RowIndex.ToString());
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            showPresent(false);
        }
    }
}
