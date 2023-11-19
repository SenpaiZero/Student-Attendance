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

namespace Student_Attendance_System.Forms.Admin
{
    public partial class logsForm : Form
    {
        String query = "";
        String categoryQuery = "";
        String dateQuery = "";
        DateTime date;
        DateTime currentValue;
        public logsForm()
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
        private void logsForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now.Date;
            date = datePicker.Value.Date;
            categoryCB.SelectedIndex = 0;
            dateCB.SelectedIndex = 0;

            loadData();
        }

        void loadData()
        {
            int i;
            if(databaseHelper.con.State != ConnectionState.Open)
                databaseHelper.open();

            databaseHelper db = new databaseHelper();
            query = "SELECT StaffID, Name, Details, Category, Date FROM Logs";
            if (!string.IsNullOrEmpty(searchTB.Text))
            {
                if (int.TryParse(searchTB.Text, out i))
                    query += $" WHERE StaffID LIKE '%{searchTB.Text}%'";
                else
                    query += $" WHERE Name LIKE '%{searchTB.Text}%'";
            }
            else
            {
                if(!query.Contains("WHERE") && (!string.IsNullOrEmpty(categoryQuery) || !string.IsNullOrEmpty(dateQuery)))
                    query += " WHERE ";

                query += categoryQuery;

                if (!string.IsNullOrEmpty(categoryQuery) && !string.IsNullOrEmpty(dateQuery))
                    query += " AND ";

                query += dateQuery;
            }

            using (db.cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listTable.DataSource = dt;
            }


            // Modify column headers
            listTable.Columns["StaffID"].HeaderText = "STAFF ID";
            listTable.Columns["StaffID"].FillWeight = 50;
            listTable.Columns["Name"].HeaderText = "NAME";
            listTable.Columns["Name"].FillWeight = 50;
            listTable.Columns["Details"].HeaderText = "DETAILS";
            listTable.Columns["Details"].FillWeight = 180;
            listTable.Columns["Category"].HeaderText = "CATEGORY";
            listTable.Columns["Category"].FillWeight = 60;
            listTable.Columns["Date"].HeaderText = "DATE";
            listTable.Columns["Date"].FillWeight = 40;
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryCB.Text == "ALL ADMIN")
                categoryQuery = $"Category = 'DELETE STAFF' OR Category = 'UPDATE STAFF' OR Category = 'ADD STAFF'";
            else if(categoryCB.Text == "ALL STUDENT")
                categoryQuery = $"Category = 'UPDATE ENROLL' OR Category = 'UPDATE STUDENT' OR Category = 'NEW ENROLL' OR Category = 'ATTENDANCE'";
            else if(categoryCB.Text == "ADD STAFF")
                categoryQuery = $"Category = 'ADD STAFF'";
            else if (categoryCB.Text == "DELETE STAFF")
                categoryQuery = $"Category = 'DELETE STAFF'";
            else if (categoryCB.Text == "UPDATE STAFF")
                categoryQuery = $"Category = 'UPDATE STAFF'";
            else if (categoryCB.Text == "UPDATE ENROLL")
                categoryQuery = $"Category = 'UPDATE ENROLL'";
            else if (categoryCB.Text == "NEW ENROLL")
                categoryQuery = $"Category = 'NEW ENROLL'";
            else if (categoryCB.Text == "UPDATE STUDENT")
                categoryQuery = $"Category = 'UPDATE STUDENT'";
            else if (categoryCB.Text == "ATTENDANCE")
                categoryQuery = $"Category = 'ATTENDANCE'";
            else if (categoryCB.Text == "SETTING")
                categoryQuery = $"Category = 'SETTING'";
            else
                categoryQuery = "";

            loadData();
        }

        private void dateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            checkDateCB();
            date = datePicker.Value.Date;
            loadData();
        }
        void checkDateCB()
        {
            if (dateCB.Text == "DAY")
                dateQuery = $"DAY(Date) = '{date.Day}'";
            else if (dateCB.Text == "MONTH")
                dateQuery = $"MONTH(Date) = '{date.Month}'";
            else if (dateCB.Text == "YEAR")
                dateQuery = $"YEAR(Date) = '{date.Year}'";
            else
                dateQuery = "";
        }
        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void datePicker_CloseUp(object sender, EventArgs e)
        {
            if (datePicker.Value.Date > DateTime.Now.Date)
            {
                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    header = "Woooops",
                    message = "Date value is invalid",
                    isYesNo = false
                };
                msg.ShowDialog();

                datePicker.Value = currentValue;
                return;
            }

            checkDateCB();
            date = datePicker.Value.Date;
            loadData();
        }

        private void datePicker_Click(object sender, EventArgs e)
        {
            currentValue = datePicker.Value.Date;
        }
    }
}
