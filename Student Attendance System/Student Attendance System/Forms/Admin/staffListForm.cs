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
    public partial class staffListForm : Form
    {
        public staffListForm()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staffListForm_Load(object sender, EventArgs e)
        {
            showData(false);
        }
        void showData(bool isSearch)
        {
            int i;
            databaseHelper.open();
            databaseHelper db = new databaseHelper();
            String query = "SELECT Name, StaffID, Admin, Email, Phone, Gender, Age, Status FROM Accounts";
            if(isSearch)
            {
                if (int.TryParse(searchTB.Text, out i))
                    query += $" WHERE StaffID LIKE '%{searchTB.Text}%'";
                else
                    query += $" WHERE Name LIKE '%{searchTB.Text}%'";
                
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
            listTable.Columns["Name"].HeaderText = "NAME";
            listTable.Columns["Email"].HeaderText = "EMAIL";
            listTable.Columns["Phone"].HeaderText = "PHONE NUMBER";
            listTable.Columns["Admin"].HeaderText = "ADMIN";
            listTable.Columns["Gender"].HeaderText = "GENDER";
            listTable.Columns["Age"].HeaderText = "AGE";
            listTable.Columns["Status"].HeaderText = "STATUS";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String selectedID;
            if(listTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = listTable.SelectedRows[0];
                selectedID = selectedRow.Cells[1].Value.ToString();

                updateStaffForm upStaff = new updateStaffForm()
                {
                    staffId = selectedID
                };

                if(upStaff.ShowDialog() == DialogResult.OK)
                {
                    showData(false);
                }
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            showData(true);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String selectedID, selectedName;
            if (listTable.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = listTable.SelectedRows[0];
                selectedID = selectedRow.Cells[1].Value.ToString();
                selectedName = selectedRow.Cells[0].Value.ToString();

                MessageForm msg = new MessageForm()
                {
                    messageType = "Information",
                    header = "Hmmmmm.",
                    message = "Are you sure you want to delete a staff?",
                    isYesNo = true
                };

                if(msg.ShowDialog() == DialogResult.OK)
                {
                    databaseHelper.open();
                    databaseHelper db = new databaseHelper();
                    String query = $"DELETE FROM Accounts WHERE StaffID = '{selectedID}'";

                    using (db.cmd = new SqlCommand(query, databaseHelper.con))
                    {
                        db.cmd.ExecuteNonQuery();
                    }
                    logsHelper.insertDeleteStaff($"Removed {selectedName} from staff");
                    showData(false);
                }
            }
        }
    }
}
