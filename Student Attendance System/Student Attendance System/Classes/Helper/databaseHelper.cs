using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class databaseHelper
    {
        public static SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
    }
}
