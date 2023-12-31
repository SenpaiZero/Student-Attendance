using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class AttendanceData
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }

        
    }
}