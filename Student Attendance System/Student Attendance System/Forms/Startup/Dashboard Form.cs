using Guna.UI2.WinForms;
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
using System.Windows.Media;

namespace Student_Attendance_System.Forms.Startup
{
    public partial class Dashboard_Form : Form
    {
        List<Guna2ProgressBar> absentBar;
        List<Guna2ProgressBar> presentBar;
        List<Guna2ProgressBar> excuseBar;
        List<float> absentPercentage = new List<float>();
        List<float> presentPercentage = new List<float>();
        List<float> excusePercentage = new List<float>();
        int totalStudent = 0;
        List<int> absents = new List<int>();
        List<int> presents = new List<int>();
        List<int> excuses = new List<int>();
        loadingForm load;
        public Dashboard_Form()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                LoadData();
            });


            load = new loadingForm()
            {
                isTask = true,
                title = "Fetching Data",
                description = "Please Wait"
            };
            load.ShowDialog();
        }
        void monthly()
        {
            absentBar = new List<Guna2ProgressBar> { Absent1, Absent2, Absent3, Absent4, Absent5, Absent6, Absent7, Absent8, Absent9, Absent10, Absent11, Absent12 };
            presentBar = new List<Guna2ProgressBar> { Present1, Present2, Present3, Present4, Present5, Present6, Present7, Present8, Present9, Present10, Present11, Present12 };
            excuseBar = new List<Guna2ProgressBar> { Excuse1, Excuse2, Excuse3, Excuse4, Excuse5, Excuse6, Excuse7, Excuse8, Excuse9, Excuse10, Excuse11, Excuse12 };

            for (int i = 0; i < 12; i++)
            {
                absentBar.ElementAtOrDefault(i).Value = (int)absentPercentage.ElementAtOrDefault(i);
                presentBar.ElementAtOrDefault(i).Value = (int)presentPercentage.ElementAtOrDefault(i);
                excuseBar.ElementAtOrDefault(i).Value = (int)excusePercentage.ElementAtOrDefault(i);

                if(DateTime.Now.Month <= i)
                {
                    absentBar.ElementAtOrDefault(i).Value = 0;
                    presentBar.ElementAtOrDefault(i).Value = 0;
                    excuseBar.ElementAtOrDefault(i).Value = 0;
                }
            }
        }

        void daily()
        {

        }
        async Task<List<int>> calculateAbsent()
        {
            List<int> monthlyAbsentList = new List<int>();
            List<int> dailyAbsentList = new List<int>();

            if(databaseHelper.con.State != ConnectionState.Open) await databaseHelper.con.OpenAsync();

            string monthly_query = @"
                    SELECT COUNT(DISTINCT s.StudentID) AS AbsentCount
                    FROM studentData AS s
                    WHERE s.EnrollDate <= DATEFROMPARTS(@year, @month, @day)
                        AND NOT EXISTS (
                            SELECT 1
                            FROM attendance AS a
                            WHERE a.StudentID = s.StudentID
                            AND DATEPART(day, a.Date) = @day
                            AND DATEPART(month, a.Date) = @month
                            AND DATEPART(year, a.Date) = @year);";

            for (int i = 0; i < 12; i++)
            {
                using (SqlCommand cmd = new SqlCommand(monthly_query, databaseHelper.con))
                {
                    cmd.Parameters.AddWithValue("month", (i+1));
                    cmd.Parameters.AddWithValue("year", dateCB.Text);

                    SqlDataReader dr = null;
                    int absentCount = 0;
                    for (int j = 0; j < DateTime.DaysInMonth(int.Parse(dateCB.Text), (i+1)); j++)
                    {
                        cmd.Parameters.AddWithValue("day", (j+1));
                        dr = cmd.ExecuteReader();

                        if (await dr.ReadAsync())
                            absentCount += dr.GetInt32(0);

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("month", (i+1));
                        cmd.Parameters.AddWithValue("year", dateCB.Text);
                        dr.Close();
                    }

                    monthlyAbsentList.Add(absentCount);
                }
            }

            return monthlyAbsentList;
        }

        async Task<List<int>> calculatePresent()
        {
            List<int> monthlyPresentList = new List<int>();
            List<int> dailyPresentList = new List<int>();

            if (databaseHelper.con.State != ConnectionState.Open) await databaseHelper.con.OpenAsync();

            String monthly_query = "SELECT COUNT(a.TimeIn)" +
                "FROM attendance AS a " +
                "WHERE EXISTS (" +
                "    SELECT 1" +
                "    FROM studentData AS s " +
                "    WHERE s.StudentID = a.StudentID " +
                "    AND s.EnrollDate <= a.Date) " +
                "AND a.StudentID IS NOT NULL " +
                "AND DATEPART(month, a.Date) = @month " + //1 - 12 for month
                "AND DATEPART(year, a.Date) = @year " +
                "AND CONVERT(time, a.TimeIn) != '00:00:00';";

            for (int i = 0; i < 12; i++)
            {
                using (SqlCommand cmd = new SqlCommand(monthly_query, databaseHelper.con))
                {
                    cmd.Parameters.AddWithValue("month", (i + 1));
                    cmd.Parameters.AddWithValue("year", dateCB.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (await dr.ReadAsync())
                        monthlyPresentList.Add(dr.GetInt32(0));

                    dr.Close();
                }
            }

            return monthlyPresentList;
        }

        async Task<List<int>> calculateExcuse()
        {
            List<int> monthlyExcuseList = new List<int>();
            List<int> dailyExcuseList = new List<int>();

            if (databaseHelper.con.State != ConnectionState.Open) await databaseHelper.con.OpenAsync();

            String monthly_query = "SELECT COUNT(a.TimeIn)" +
                "FROM attendance AS a " +
                "WHERE EXISTS (" +
                "    SELECT 1" +
                "    FROM studentData AS s " +
                "    WHERE s.StudentID = a.StudentID " +
                "    AND s.EnrollDate <= a.Date) " +
                "AND a.StudentID IS NOT NULL " +
                "AND DATEPART(month, a.Date) = @month " + //1 - 12 for month
                "AND DATEPART(year, a.Date) = @year " +
                "AND CONVERT(time, a.TimeIn) = '00:00:00';";

            for (int i = 0; i < 12; i++)
            {
                using (SqlCommand cmd = new SqlCommand(monthly_query, databaseHelper.con))
                {
                    cmd.Parameters.AddWithValue("month", (i+1));
                    cmd.Parameters.AddWithValue("year", dateCB.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (await dr.ReadAsync())
                        monthlyExcuseList.Add(dr.GetInt32(0));

                    dr.Close();
                }
            }

            return monthlyExcuseList;
        }
        async Task LoadData()
        {
            absents = await calculateAbsent();
            presents = await calculatePresent();
            excuses = await calculateExcuse();

            int maxCount = Math.Max(absents.Count, Math.Max(presents.Count, excuses.Count));

            for (int i = 0; i < maxCount; i++)
            {
                float absentCount = absents.ElementAtOrDefault(i);
                float presentCount = presents.ElementAtOrDefault(i);
                float excuseCount = excuses.ElementAtOrDefault(i);

                float totalStudent = presentCount + absentCount + excuseCount;
                if (totalStudent <= 0) totalStudent = 1;

                float presentPercent = (presentCount / totalStudent) * 100;
                float absentPercent = (absentCount / totalStudent) * 100;
                float excusePercent = (excuseCount / totalStudent) * 100;

                presentPercentage.Add(presentPercent);
                absentPercentage.Add(absentPercent);
                excusePercentage.Add(excusePercent);

                Console.WriteLine($"Total: {totalStudent} :: Present: {presentPercent} :: Absent: {absentPercent} :: Excuse: {excusePercent}");
            }

            monthly();
            load.closeForm();
        }



        void loadYearlyAtt()
        {
            String query = "";
        }
        void loadMonthlyAtt()
        {

        }

        private void attContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
