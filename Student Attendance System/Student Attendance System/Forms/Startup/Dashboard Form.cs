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

        Dictionary<string, Control> removedControls = new Dictionary<string, Control>();
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
            barContainer.AutoSize = true;
            lblVisibility(new Control[]{ lbl27, lbl28, lbl29, lbl30, lbl31});
            setComboBox();

            Task.Run(async () =>
            {
                await LoadData();
            });

            load = new loadingForm()
            {
                isTask = true,
                title = "Fetching Data",
                description = "Please Wait"
            };
            load.ShowDialog();

        }

        void removeControl(String[] controlNum)
        {
            for (int i = 0; i < controlNum.Length; i++)
            {
                // Store controls to be removed in the dictionary before removing
                StoreRemovedControl("Absent" + controlNum[i]);
                StoreRemovedControl("Excuse" + controlNum[i]);
                StoreRemovedControl("Present" + controlNum[i]);

                this.Controls.Find("lbl" + controlNum[i], true).FirstOrDefault().Visible = false;
            }
        }
        void StoreRemovedControl(string controlName)
        {
            Control removedControl = barContainer.Controls.Find(controlName, true).FirstOrDefault();
            if (removedControl != null)
            {
                removedControls[controlName] = removedControl; // Store the control in the dictionary
                barContainer.Controls.Remove(removedControl); // Remove from the container
            }
        }

        void addControl()
        {
            foreach (var removedControl in removedControls)
            {
                // Recreate the control using the stored information and add it back to the container
                barContainer.Controls.Add(removedControl.Value);
            }

            // Clear the dictionary after adding controls back
            removedControls.Clear();
        }

        void lblVisibility(Control[] lbl)
        {
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].Visible = true;
            }
        }
        void setComboBox()
        {
            dateCB.Text = DateTime.Now.Year.ToString();
            monthCB.SelectedIndex = (DateTime.Now.Month - 1);
        }
        // ==========================================================================
        // SORRY FOR THE MESS FOR MY WAY OF STORING THE CONTROL OF PROGRESS BAR FOR DASHBOARD.
        // ==========================================================================
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
            int days = DateTime.DaysInMonth(int.Parse(dateCB.Text), (monthCB.SelectedIndex+1));
            Console.WriteLine(days);
            absentBar = new List<Guna2ProgressBar> { Absent1, Absent2, Absent3, Absent4, Absent5, Absent6, Absent7, Absent8, Absent9, Absent10, Absent11, Absent12,
                            Absent13, Absent14, Absent15, Absent16, Absent17, Absent18, Absent19, Absent20, Absent21, Absent22, Absent23, Absent24, Absent25, Absent26,
                            Absent27, Absent28, Absent29, Absent30, Absent31 };
            presentBar = new List<Guna2ProgressBar> { Present1, Present2, Present3, Present4, Present5, Present6, Present7, Present8, Present9, Present10, Present11, Present12,
                            Present13, Present14, Present15, Present16, Present17, Present18, Present19, Present20, Present21, Present22, Present23, Present24, Present25, Present26, Present27,
                            Present28, Present29, Present30, Present31 };
            excuseBar = new List<Guna2ProgressBar> { Excuse1, Excuse2, Excuse3, Excuse4, Excuse5, Excuse6, Excuse7, Excuse8, Excuse9, Excuse10, Excuse11, Excuse12, Excuse13, Excuse14,
                                Excuse15, Excuse16, Excuse17, Excuse18, Excuse19, Excuse20, Excuse21, Excuse22, Excuse23, Excuse24, Excuse25, Excuse26, Excuse27, Excuse28, Excuse29,
                                Excuse30, Excuse31};

            if(days == 30)
            {
                absentBar.Remove(Absent31);
                presentBar.Remove(Present31);
                excuseBar.Remove(Excuse31);
            }

            if(days == 28)
            {
                absentBar.Remove(Absent31);
                presentBar.Remove(Present31);
                excuseBar.Remove(Excuse31);
                absentBar.Remove(Absent30);
                presentBar.Remove(Present30);
                excuseBar.Remove(Excuse30);
                absentBar.Remove(Absent30);
                presentBar.Remove(Present30);
                excuseBar.Remove(Excuse30);
                absentBar.Remove(Absent29);
                presentBar.Remove(Present29);
                excuseBar.Remove(Excuse29);
            }

            for (int i = 0; i < days; i++)
            {
                absentBar.ElementAtOrDefault(i).Value = (int)absentPercentage.ElementAtOrDefault(i);
                presentBar.ElementAtOrDefault(i).Value = (int)presentPercentage.ElementAtOrDefault(i);
                excuseBar.ElementAtOrDefault(i).Value = (int)excusePercentage.ElementAtOrDefault(i);

                if (DateTime.Now.Month == (monthCB.SelectedIndex + 1) && DateTime.Now.Year == int.Parse(dateCB.Text))
                    if ((i+1) > DateTime.Now.Day)
                    {
                        absentBar.ElementAtOrDefault(i).Value = 0;
                        presentBar.ElementAtOrDefault(i).Value = 0;
                        excuseBar.ElementAtOrDefault(i).Value = 0;
                    }
            }
        }
        async Task<List<int>> calculateAbsent()
        {
            List<int> monthlyAbsentList = new List<int>();
            List<int> dailyAbsentList = new List<int>();

            if(databaseHelper.con.State != ConnectionState.Open) await databaseHelper.con.OpenAsync();

            string query = @"
                    SELECT COUNT(DISTINCT s.StudentID) AS AbsentCount
                    FROM studentData AS s
                    WHERE s.EnrollDate <= DATEFROMPARTS(@year, @month, @day)
                        AND NOT EXISTS (
                            SELECT 1
                            FROM attendance AS a
                            WHERE a.StudentID = s.StudentID 
                             ";

            if (sizeCB.Text.ToUpper() == "MONTHLY")
            {
                query += @"AND DATEPART(day, a.Date) = @day
                            AND DATEPART(month, a.Date) = @month
                            AND DATEPART(year, a.Date) = @year);";
                for (int i = 0; i < 12; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
                    {
                        cmd.Parameters.AddWithValue("month", (i + 1));
                        cmd.Parameters.AddWithValue("year", dateCB.Text);

                        SqlDataReader dr = null;
                        int absentCount = 0;
                        for (int j = 0; j < DateTime.DaysInMonth(int.Parse(dateCB.Text), (i + 1)); j++)
                        {
                            cmd.Parameters.AddWithValue("day", (j + 1));
                            dr = cmd.ExecuteReader();

                            if (await dr.ReadAsync())
                                absentCount += dr.GetInt32(0);

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("month", (i + 1));
                            cmd.Parameters.AddWithValue("year", dateCB.Text);
                            dr.Close();
                        }

                        monthlyAbsentList.Add(absentCount);
                    }
                }

                return monthlyAbsentList;
            }
            else
            {
                query += @"AND DATEPART(day, a.Date) = @day
                            AND DATEPART(month, a.Date) = @month
                            AND DATEPART(year, a.Date) = @year);";
                for (int i = 0; i < DateTime.DaysInMonth(int.Parse(dateCB.Text), (monthCB.SelectedIndex + 1)); i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
                    {
                        cmd.Parameters.AddWithValue("month", (monthCB.SelectedIndex+1));
                        cmd.Parameters.AddWithValue("year", dateCB.Text);
                        cmd.Parameters.AddWithValue("day", (i + 1));

                         
                        int absentCount = 0;
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (await dr.ReadAsync())
                            absentCount += dr.GetInt32(0);
                        dr.Close();

                        dailyAbsentList.Add(absentCount);
                    }
                }

                return dailyAbsentList;
            }
        }

        async Task<List<int>> calculatePresent()
        {
            List<int> monthlyExcuseList = new List<int>();
            List<int> dailyExcuseList = new List<int>();

            if (databaseHelper.con.State != ConnectionState.Open) await databaseHelper.con.OpenAsync();
            String query = "SELECT COUNT(a.TimeIn)" +
                "FROM attendance AS a " +
                "WHERE EXISTS (" +
                "    SELECT 1" +
                "    FROM studentData AS s " +
                "    WHERE s.StudentID = a.StudentID " +
                "    AND s.EnrollDate <= a.Date) " +
                "AND a.StudentID IS NOT NULL ";

            // Get monthly
            if (sizeCB.Text.ToUpper() == "MONTHLY")
            {
                query += "AND DATEPART(month, a.Date) = @month " + //1 - 12 for month
                         "AND DATEPART(year, a.Date) = @year " +
                         "AND CONVERT(time, a.TimeIn) != '00:00:00';";

                for (int i = 0; i < 12; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
                    {
                        cmd.Parameters.AddWithValue("month", (i + 1));
                        cmd.Parameters.AddWithValue("year", dateCB.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (await dr.ReadAsync())
                            monthlyExcuseList.Add(dr.GetInt32(0));

                        dr.Close();
                    }
                }

                return monthlyExcuseList;
            }
            else
            {
                query += "AND DATEPART(day, a.Date) = @day " +
                         "AND DATEPART(month, a.Date) = @month " +
                         "AND DATEPART(year, a.Date) = @year " +
                         "AND CONVERT(time, a.TimeIn) != '00:00:00';";

                for (int i = 0; i < DateTime.DaysInMonth(int.Parse(dateCB.Text), (monthCB.SelectedIndex + 1)); i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
                    {
                        cmd.Parameters.AddWithValue("day", (i + 1));
                        cmd.Parameters.AddWithValue("month", (monthCB.SelectedIndex + 1));
                        cmd.Parameters.AddWithValue("year", dateCB.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (await dr.ReadAsync())
                            dailyExcuseList.Add(dr.GetInt32(0));

                        dr.Close();
                    }
                }

                return dailyExcuseList;
            }
        }

        async Task<List<int>> calculateExcuse()
        {
            List<int> monthlyExcuseList = new List<int>();
            List<int> dailyExcuseList = new List<int>();

            if (databaseHelper.con.State != ConnectionState.Open) await databaseHelper.con.OpenAsync();
            String query = "SELECT COUNT(a.TimeIn)" +
                "FROM attendance AS a " +
                "WHERE EXISTS (" +
                "    SELECT 1" +
                "    FROM studentData AS s " +
                "    WHERE s.StudentID = a.StudentID " +
                "    AND s.EnrollDate <= a.Date) " +
                "AND a.StudentID IS NOT NULL ";
                
            // Get monthly
            if (sizeCB.Text.ToUpper() == "MONTHLY")
            {
                query += "AND DATEPART(month, a.Date) = @month " + //1 - 12 for month
                         "AND DATEPART(year, a.Date) = @year " +
                         "AND CONVERT(time, a.TimeIn) = '00:00:00';";

                for (int i = 0; i < 12; i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
                    {
                        cmd.Parameters.AddWithValue("month", (i + 1));
                        cmd.Parameters.AddWithValue("year", dateCB.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (await dr.ReadAsync())
                            monthlyExcuseList.Add(dr.GetInt32(0));

                        dr.Close();
                    }
                }

                return monthlyExcuseList;
            }
            else
            {
                query += "AND DATEPART(day, a.Date) = @day " +
                         "AND DATEPART(month, a.Date) = @month " +
                         "AND DATEPART(year, a.Date) = @year " +
                         "AND CONVERT(time, a.TimeIn) = '00:00:00';";

                for (int i = 0; i < DateTime.DaysInMonth(int.Parse(dateCB.Text), (monthCB.SelectedIndex + 1)); i++)
                {
                    using (SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
                    {
                        cmd.Parameters.AddWithValue("day", (i + 1));
                        cmd.Parameters.AddWithValue("month", (monthCB.SelectedIndex+1));
                        cmd.Parameters.AddWithValue("year", dateCB.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (await dr.ReadAsync())
                            dailyExcuseList.Add(dr.GetInt32(0));

                        dr.Close();
                    }
                }

                return dailyExcuseList;
            }
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
            if (sizeCB.Text.ToUpper() == "MONTHLY")
                monthly();
            else 
                daily();
            
            load.closeForm();
        }


        private void attContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barContainer_SizeChanged(object sender, EventArgs e)
        {
            lbl0per.Location = new System.Drawing.Point(lbl0per.Location.X, barContainer.Bottom + 10);
            lbl20per.Location = new System.Drawing.Point(lbl20per.Location.X, barContainer.Bottom + 10);
            lbl40per.Location = new System.Drawing.Point(lbl40per.Location.X, barContainer.Bottom + 10);
            lbl60per.Location = new System.Drawing.Point(lbl60per.Location.X, barContainer.Bottom + 10);
            lbl80per.Location = new System.Drawing.Point(lbl80per.Location.X, barContainer.Bottom + 10);
            lbl100per.Location = new System.Drawing.Point(lbl100per.Location.X, barContainer.Bottom + 10);
            holder.Location = new System.Drawing.Point(lbl100per.Location.X, barContainer.Bottom + 30);
        }

        private void monthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void sizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await LoadData();
            });


            if (sizeCB.Text == "MONTHLY")
            {
                  
                removeControl(new string[] { "31", "30", "29", "28", "27", "26", "25", "24", "23", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13"});
            }
            else
            {
                addControl();
                lblVisibility(new Control[] { lbl31, lbl30, lbl29, lbl28, lbl27, lbl26, lbl25, lbl24, lbl23, lbl22, lbl21, lbl20, lbl19, lbl18, lbl17, lbl16, lbl15, lbl14, lbl13});
            }

            load = new loadingForm()
            {
                isTask = true,
                title = "Fetching Data",
                description = "Please Wait"
            };
            load.ShowDialog();
        }
    }
}
