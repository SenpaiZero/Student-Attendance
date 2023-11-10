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
            showData(true);
        }
        void showData(bool isSearch)
        {
            int i;
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query = "SELECT data.StudentID, data.Name, data.Section, data.Year, data.StudentType FROM studentData data";
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
            showData(false);
        }

        private void unerollBtn_Click(object sender, EventArgs e)
        {
            String selectedID;
            if (listTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = listTable.SelectedRows[0];
                selectedID = selectedRow.Cells[0].Value.ToString();

                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    header = "Hmmmmm.",
                    message = "Are you sure you want to delete a student?",
                    isYesNo = true
                };

                if (msg.ShowDialog() == DialogResult.OK)
                {
                    if (databaseHelper.con.State != ConnectionState.Open)
                        databaseHelper.open();
                    databaseHelper db = new databaseHelper();
                    String[] query = 
                        {
                        $"DELETE FROM studentData WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentIdentity WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentFather WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentMother WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentInformation WHERE StudentID = '{selectedID}'",
                        $"DELETE FROM studentContacts WHERE StudentID = '{selectedID}'"
                        };

                    foreach (var item in query)
                    {
                        using (db.cmd = new SqlCommand(item, databaseHelper.con))
                        {
                            db.cmd.ExecuteNonQuery();
                        }
                    }

                    showData(false);
                }
            }
        }
    }
}
