using Guna.UI2.WinForms;
using Student_Attendance_System.Classes;
using Student_Attendance_System.Classes.Helper;
using Student_Attendance_System.Startup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System.Forms
{
    public partial class splitPopup : Form
    {
        cameraHelper mainCam;
        public static bool isVisible { get; set; }
        public static Bitmap lastCapture { get; set; }
        public splitPopup()
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
        private void splitPopup_Load(object sender, EventArgs e)
        {
            mainCam = new cameraHelper();
        }

        private void splitPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainCam.closeForm();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void updateData(string id)
        {
            if (databaseHelper.con.State != ConnectionState.Open)
                databaseHelper.open();
            String query = $"SELECT d.StudentID, d.Name, d.Section, d.Year, i.Picture " +
                $"FROM studentData d JOIN studentIdentity i ON i.StudentID = d.StudentID" +
                $" WHERE d.StudentID = '{id}'";
            using(SqlCommand cmd = new SqlCommand(query, databaseHelper.con))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    idNumLbl.Text = dr.GetString(0);
                    nameLbl.Text = dr.GetString(1);
                    sectionYearLbl.Text = $"{dr.GetString(2)}&{dr.GetString(3)}";
                    idPic.Image = ConvertToImage((byte[])dr.GetValue(4));
                    dr.Close();
                }
            }
            if (lastCapture == null) lastCap.Image = Properties.Resources.No_Image_Placeholder_svg;
            else lastCap.Image = lastCapture;
            if (Config.colorPopupLabel == 1)
                changeColor(Color.LightSeaGreen);
            else if(Config.colorPopupLabel == 2)
                changeColor(Color.Orange);
            else if(Config.colorPopupLabel == 3)
                changeColor(Color.IndianRed);
        }

        void changeColor(Color color)
        {
            lblName.ForeColor = color;
            lblID.ForeColor = color;
            lvlSection.ForeColor = color;

            idNumLbl.ForeColor = color;
            nameLbl.ForeColor = color;
            sectionYearLbl.ForeColor = color;
        }
        public Bitmap ConvertToImage(byte[] binary)
        {
            if (binary == null || binary.Length == 0)
            {
                // Return a default image or handle the null case as needed
                return new Bitmap(1, 1);
            }

            using (MemoryStream stream = new MemoryStream(binary))
            {
                Bitmap image = new Bitmap(stream);
                return image;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
