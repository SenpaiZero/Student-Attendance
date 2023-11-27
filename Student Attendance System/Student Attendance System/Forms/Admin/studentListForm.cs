using Student_Attendance_System.Classes;
using Student_Attendance_System.Classes.Helper;
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
    public partial class studentListForm : Form
    {
        bool isViewEnroll = true;
        public studentListForm()
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
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            showData(true, isViewEnroll);
        }
        void showData(bool isSearch, bool isEnrolled)
        {
            int i;
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query;
            if (isEnrolled)
                 query = "SELECT data.StudentID, data.Name, data.Section, data.Year, data.StudentType FROM studentData data";
            else
                query = "SELECT data.StudentID, data.Name, data.Section, data.Year, data.StudentType FROM studentData_unenroll data";
            if (isSearch)
            {
                if (int.TryParse(searchTB.Text, out i))
                    query += $" WHERE data.StudentID LIKE '%{searchTB.Text}%'";
                else
                    query += $" WHERE data.Name LIKE '%{searchTB.Text}%'";

            }
            using (db.cmd = new SqlCommand(query, databaseHelper.con))
            {

                SqlDataAdapter da = new SqlDataAdapter(db.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listTable.DataSource = dt;
            }


            // Modify column headers
            listTable.Columns["StudentID"].HeaderText = "STAFF ID";
            listTable.Columns["Name"].HeaderText = "NAME";
            listTable.Columns["Section"].HeaderText = "SECTION";
            listTable.Columns["Year"].HeaderText = "YEAR";
            listTable.Columns["StudentType"].HeaderText = "STUDENT TYPE";
        }

        private void studentListForm_Load(object sender, EventArgs e)
        {
            showData(false, isViewEnroll);
        }

        private void unerollBtn_Click(object sender, EventArgs e)
        {
            String selectedID, selectedName;
            if (listTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = listTable.SelectedRows[0];
                selectedID = selectedRow.Cells[0].Value.ToString();
                selectedName = selectedRow.Cells[1].Value.ToString();

                string prefix = isViewEnroll ? "unenroll" : "enroll";
                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    header = "Hmmmmm.",
                    message = $"Are you sure you want to {prefix} a student?",
                    isYesNo = true
                };

                if (msg.ShowDialog() == DialogResult.OK)
                {
                    if (databaseHelper.con.State != ConnectionState.Open)
                        databaseHelper.open();
                    databaseHelper db = new databaseHelper();
                    string tablePrefix = isViewEnroll ? "" : "_unenroll";
                    string tablePrefixInsert = !isViewEnroll ? "" : "_unenroll";

                    string[] query = {
                        $"DELETE FROM studentData{tablePrefix} WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentIdentity{tablePrefix} WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentFather{tablePrefix} WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentMother{tablePrefix} WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentInformation{tablePrefix} WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentContacts{tablePrefix} WHERE StudentID = '{selectedID}'"
                    };

                    string query_insert =
                        $"INSERT INTO studentContacts{tablePrefixInsert} (StudentID, Email, PhoneNumber, Address) SELECT StudentID, Email, PhoneNumber, Address FROM studentContacts{tablePrefix} WHERE StudentID = @id; " +
                        $"INSERT INTO studentData{tablePrefixInsert} (StudentID, Name, Section, Year, StudentType, EnrollDate) SELECT StudentID, Name, Section, Year, StudentType, EnrollDate FROM studentData{tablePrefix} WHERE StudentID = @id; " +
                        $"INSERT INTO studentFather{tablePrefixInsert} (StudentID, Name, Email, PhoneNumber, Occupation) SELECT StudentID, Name, Email, PhoneNumber, Occupation FROM studentFather{tablePrefix} WHERE StudentID = @id; " +
                        $"INSERT INTO studentMother{tablePrefixInsert} (StudentID, Name, Email, PhoneNumber, Occupation) SELECT StudentID, Name, Email, PhoneNumber, Occupation FROM studentMother{tablePrefix} WHERE StudentID = @id; " +
                        $"INSERT INTO studentIdentity{tablePrefixInsert} (StudentID, QRCode, Picture) SELECT StudentID, QRCode, Picture FROM studentIdentity{tablePrefix} WHERE StudentID = @id; " +
                        $"INSERT INTO studentInformation{tablePrefixInsert} (StudentID, Age, Religion, Gender, MoreDetails, Birthday) SELECT StudentID, Age, Religion, Gender, MoreDetails, Birthday FROM studentInformation{tablePrefix} WHERE StudentID = @id;";

                    using (SqlCommand insert_cmd = new SqlCommand(query_insert, databaseHelper.con))
                    {
                        insert_cmd.Parameters.AddWithValue("id", selectedID);
                        insert_cmd.ExecuteNonQuery();
                    }

                    foreach (var item in query)
                    {
                        using (db.cmd = new SqlCommand(item, databaseHelper.con))
                        {
                            db.cmd.ExecuteNonQuery();
                        }
                    }
                    string logPrefix = !isViewEnroll ? "ENROLL" : "UNENROLL";
                    logsHelper.insertUpdateEnroll($"Updated {selectedName}'s enrollment to {logPrefix}");
                    showData(false, isViewEnroll);
                }
            }
        }
        private void viewBtn_Click(object sender, EventArgs e)
        {
            String selectedID;
            if (listTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = listTable.SelectedRows[0];
                selectedID = selectedRow.Cells[0].Value.ToString();

                updateStudentForm updateStd = new updateStudentForm();
                updateStd.studentID = selectedID;
                updateStd.ShowDialog();
            }
        }

        private void changeViewBtn_Click(object sender, EventArgs e)
        {
            if(isViewEnroll)
            {
                changeViewBtn.Text = "UNENROLLED";
                unerollBtn.Text = "ENROLL";
            }
            else
            {
                changeViewBtn.Text = "ENROLLED";
                unerollBtn.Text = "UNENROLL";
            }
            isViewEnroll = !isViewEnroll;
            viewBtn.Enabled = isViewEnroll;
            printBtn.Enabled = isViewEnroll;

            showData(false, isViewEnroll);
        }

        private void listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
