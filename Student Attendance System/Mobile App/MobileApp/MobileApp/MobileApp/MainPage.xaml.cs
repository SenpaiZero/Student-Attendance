using Android.Content;
using Android.Graphics;
using Android.Media;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Plugin.Permissions;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Provider;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public static String _connectionString = "Server=tcp:student-attendance.database.windows.net,1433;" +
                                      "Initial Catalog=student-attendance;" +
                                      "Persist Security Info=False;" +
                                      "User ID=student_attendance;" +
                                      "Password=BSIT123sti;" +
                                      "MultipleActiveResultSets=False;" +
                                      "Encrypt=True;" +
                                      "TrustServerCertificate=False;" +
                                      "Connection Timeout=30;";
        public MainPage()
        {
            InitializeComponent();
            LoadStudentData(); // Call method to load student data
        }

        // Method to load student data
        private void LoadStudentData()
        {
            // Your Azure SQL Database connection string
            string connectionString = "Server=tcp:student-attendance.database.windows.net,1433;" +
                                      "Initial Catalog=student-attendance;" +
                                      "Persist Security Info=False;" +
                                      "User ID=student_attendance;" +
                                      "Password=BSIT123sti;" +
                                      "MultipleActiveResultSets=False;" +
                                      "Encrypt=True;" +
                                      "TrustServerCertificate=False;" +
                                      "Connection Timeout=30;";

            DataAccess dataAccess = new DataAccess(connectionString);
            List<Student> students = dataAccess.GetStudents();

            // Assign the list of students to the ListView's ItemSource
            studentListView.ItemsSource = students;
        }

        // Student class to hold student information
        public class Student
        {
            public string StudentID { get; set; }
            public string StudentName { get; set; }
        }

        // DataAccess class to retrieve data from the database
        public class DataAccess
        {
            private readonly string _connectionString;

            public DataAccess(string connectionString)
            {
                _connectionString = connectionString;
            }

            public List<Student> GetStudents()
            {
                List<Student> students = new List<Student>();

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT StudentID, Name FROM studentData";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            StudentID = reader["StudentID"].ToString(),
                            StudentName = reader["Name"].ToString()
                        };
                        students.Add(student);
                    }

                    reader.Close();
                }

                return students;
            }
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var studentID = button.CommandParameter.ToString();

            // Fetch image data from the database
            DataAccess dataAccess = new DataAccess(_connectionString);
            byte[] imageData = GetQRCode(studentID);

            if (imageData != null)
            {

                // Save the image data to a file locally
                string fileName = $"Student_{studentID}.png"; // Provide a suitable file name

                Java.IO.File externalFilesDir = Android.App.Application.Context.GetExternalFilesDir(null);
                string localPath = System.IO.Path.Combine(externalFilesDir.AbsolutePath, fileName);

                SaveImageToGallery(imageData, localPath);
                // Display a confirmation message
                await DisplayAlert("Image Saved", $"Image for Student ID: {studentID} saved locally.", "OK");
            }
            else
            {
                // Image data not found
                await DisplayAlert("Error", "Image data not found for the selected student.", "OK");
            }
        }
        public byte[] GetStudentImage(string studentID)
        {
            byte[] imageData = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Picture FROM studentIdentity WHERE studentID = @StudentID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (!reader.IsDBNull(0)) // Check if the column is not NULL
                    {
                        imageData = (byte[])reader["Picture"];
                    }
                }

                reader.Close();
            }

            return imageData;
        }
        public byte[] GetQRCode(string studentID)
        {
            byte[] qrCodeData = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT QRCode FROM studentIdentity WHERE studentID = @StudentID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", studentID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (!reader.IsDBNull(0)) // Check if the column is not NULL
                    {
                        qrCodeData = (byte[])reader["QRCode"];
                    }
                }

                reader.Close();
            }

            return qrCodeData;
        }
        public void SaveImageToGallery(string filePath)
        {
            Context context = Android.App.Application.Context;

            MediaScannerConnection.ScanFile(context, new string[] { filePath }, null, null);
        }
        public void SaveImageToGallery(byte[] bit, string studentID)
        {
            Bitmap finalBitmap = BitmapFactory.DecodeByteArray(bit, 0, bit.Length);

            ContentValues values = new ContentValues();
            values.Put(MediaStore.Images.Media.InterfaceConsts.Title, "Student_" + studentID);
            values.Put(MediaStore.Images.Media.InterfaceConsts.Description, "Student Image");
            values.Put(MediaStore.Images.Media.InterfaceConsts.MimeType, "image/jpeg");

            // Retrieve the current activity's context
            var context = Android.App.Application.Context;

            // Store the image using the MediaStore API
            var imageUri = context.ContentResolver.Insert(MediaStore.Images.Media.ExternalContentUri, values);

            if (imageUri != null)
            {
                using (var stream = context.ContentResolver.OpenOutputStream(imageUri))
                {
                    finalBitmap.Compress(Bitmap.CompressFormat.Jpeg, 100, stream);
                }
            }
        }




    }

}
