using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms.Startup
{
    public partial class recordForm : Form
    {
        DataGridViewButtonColumn button;
        DateTime currentValue;
        string totalAbsent, totalPresent;
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

        internal Classes.Helper.LocalSaveHelper LocalSaveHelper
        {
            get => default;
            set
            {
            }
        }

        internal databaseHelper databaseHelper
        {
            get => default;
            set
            {
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
            String query = "SELECT d.StudentID, d.Name " +
                           "FROM studentData d " +
                           "LEFT JOIN attendance a ON d.StudentID = a.StudentID AND CONVERT(DATE, a.Date) = @SelectedDate " +
                           "WHERE d.EnrollDate <= @SelectedDate AND a.StudentID IS NULL";

            if (!string.IsNullOrEmpty(searchTB.Text))
            {
                if (int.TryParse(searchTB.Text, out i))
                    query += $" AND d.StudentID LIKE '%{searchTB.Text}%'";
                else
                    query += $" AND d.Name LIKE '%{searchTB.Text}%'";
            }

            using (db.cmd = new SqlCommand(query, databaseHelper.con))
            {
                db.cmd.Parameters.AddWithValue("@SelectedDate", datePicker.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listTable.DataSource = dt;
            }

            // Modify column headers
            listTable.Columns["StudentID"].HeaderText = "STUDENT ID";
            listTable.Columns["Name"].HeaderText = "NAME";

            button = new DataGridViewButtonColumn();
            {
                button.Name = "presentBtn";
                button.HeaderText = "ACTION";
                button.Text = "PRESENT";
                button.UseColumnTextForButtonValue = true;
                this.listTable.Columns.Add(button);
            }
            listTable.Columns["presentBtn"].Width = 80;
        }


        void showPresent()
        {
            int i;
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query = "SELECT a.StudentID, d.Name, a.TimeIn, a.TimeOut " +
                           "FROM attendance a " +
                           "JOIN studentData d ON a.StudentID = d.StudentID " +
                           $"WHERE a.Date = '{datePicker.Value.Date}' AND d.EnrollDate <= a.Date";

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
            listTable.Columns["TimeIn"].HeaderText = "TIME IN";
            listTable.Columns["TimeOut"].HeaderText = "TIME OUT";

            button = new DataGridViewButtonColumn();
            {
                button.Name = "absentBtn";
                button.HeaderText = "ACTION";
                button.Text = "ABSENT";
                button.UseColumnTextForButtonValue = true;
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
            String query;
            removeActionBtn();

            if (viewBtn.Text == "ABSENTS")
                showAbsent();
            else
                showPresent();

            if(databaseHelper.con.State != ConnectionState.Open)
                databaseHelper.open();
            query = "SELECT COUNT(*) FROM attendance a " +
                           $"JOIN studentData d ON a.StudentID = d.StudentID WHERE a.Date = '{datePicker.Value.Date}'";
            using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                    totalPresent = dr.GetInt32(0).ToString();

                dr.Close();
            }

            query = "SELECT COUNT(*) " +
                           "FROM studentData d " +
                           "LEFT JOIN attendance a ON d.StudentID = a.StudentID AND CONVERT(DATE, a.Date) = @SelectedDate " +
                           "WHERE d.EnrollDate <= @SelectedDate AND a.StudentID IS NULL";
            using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
            {
                cmd.Parameters.AddWithValue("SelectedDate", datePicker.Value.Date);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    totalAbsent = dr.GetInt32(0).ToString();

                dr.Close();
            }


            absentLbl.Text = "TOTAL ABSENTS: " + totalAbsent.ToString();
            presentLbl.Text = "TOTAL PRESENTS: " + totalPresent.ToString();
        }

        private void recordForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            showData();
        }

        private void listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (databaseHelper.con.State != ConnectionState.Open)
                databaseHelper.open();

            databaseHelper db = new databaseHelper();
            String selectedID;

            if (listTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = listTable.SelectedRows[0];
                selectedID = selectedRow.Cells[0].Value.ToString();

                if (viewBtn.Text == "PRESENTS")
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        String remove_query = $"DELETE FROM attendance WHERE StudentID = @id";

                        using (db.cmd = new SqlCommand(remove_query, databaseHelper.con))
                        {
                            db.cmd.Parameters.AddWithValue("id", selectedID);
                            db.cmd.ExecuteNonQuery();
                        }
                        Console.WriteLine("teasdt");
                    }
                }
                else if (viewBtn.Text == "ABSENTS")
                {
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        String insert_query = $"INSERT INTO attendance (StudentID, Date, TimeIn, TimeOut) VALUES (@id, @date, @timein, @timeout)";
                        using (db.cmd = new SqlCommand(insert_query, databaseHelper.con))
                        {
                            db.cmd.Parameters.AddWithValue("id", selectedID);
                            db.cmd.Parameters.AddWithValue("date", datePicker.Value.Date);
                            db.cmd.Parameters.AddWithValue("timein", "00:00:00");
                            db.cmd.Parameters.AddWithValue("timeout", "00:00:00");
                            db.cmd.ExecuteNonQuery();
                        }
                        Console.WriteLine("test");
                    }
                }
                showData();
            }
        }


        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if(datePicker.Value.Date > DateTime.Now.Date)
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
            showData();
        }

        private void datePicker_Click(object sender, EventArgs e)
        {
            currentValue = datePicker.Value;
        }
    }
}
