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
    public partial class dashboardStats : Form
    {
        public dashboardStats()
        {
            InitializeComponent();
        }

        internal databaseHelper databaseHelper
        {
            get => default;
            set
            {
            }
        }

        private void guna2Panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardStats_Load(object sender, EventArgs e)
        {
            loadingForm load = new loadingForm()
            {
                loadTime = 1500,
                title = "Fetching Data",
                description = "Please wait"
            };
            Task.Run(() =>
            {
                updateLabels();
            });
            load.ShowDialog();
        }

        void updateLabels()
        {

            totalStudentLbl.Text = (countRecord("studentData", "") + countRecord("studentData_unenroll", "")).ToString();
            totalMaleLbl.Text = countRecord("studentInformation", "Gender = 'MALE'").ToString();
            totalFemaleLbl.Text = countRecord("studentInformation", "Gender = 'FEMALE'").ToString();
            totalEnrolleeLbl.Text = countRecord("studentData", "StudentType = 'Enrollee'").ToString();
            totalReturneeLbl.Text = countRecord("studentData", "StudentType = 'Returnee'").ToString();
            totalTransfereeLbl.Text = countRecord("studentData", "StudentType = 'Transferee'").ToString();
            totalEnrollLbl.Text = countRecord("studentData", "").ToString();
            totalUnenrollLbl.Text = countRecord("studentData_unenroll", "").ToString();

            totalGrade7Lbl.Text = countRecord("studentData", "Year = '7'").ToString();
            totalGrade8Lbl.Text = countRecord("studentData", "Year = '8'").ToString();
            totalGrade9Lbl.Text = countRecord("studentData", "Year = '9'").ToString();
            totalGrade10Lbl.Text = countRecord("studentData", "Year = '10'").ToString();

            totalStaffLbl.Text = countRecord("Accounts", "").ToString();
            totalAdminLbl.Text = countRecord("Accounts", "Admin = 'ADMIN'").ToString();
            totalTeacherLbl.Text = countRecord("Accounts", "Admin = 'REGULAR'").ToString();
            totalStaffFemaleLbl.Text = countRecord("Accounts", "Gender = 'FEMALE'").ToString();
            totalStaffMaleLbl.Text = countRecord("Accounts", "Gender = 'MALE'").ToString();
        }
        int countRecord(String table, String condition)
        {
            String query;
            if (databaseHelper.con.State != ConnectionState.Open)
                databaseHelper.open();

            query = $"SELECT COUNT(*) FROM {table}";
            if (condition.Contains("="))
                query += $" WHERE {condition}";

            query += ";";

            using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    int data = dr.GetInt32(0);
                    dr.Close();
                    return data;
                }
            }

            return 0;
        }
    }
}
