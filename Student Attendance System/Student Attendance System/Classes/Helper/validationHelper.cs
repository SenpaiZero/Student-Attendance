using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Student_Attendance_System
{
    internal class validationHelper
    {
        public static bool internetAvailability()
        {
            try
            {
                Ping ping = new Ping();
                String host = "portal.azure.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOption = new PingOptions();
                PingReply reply = ping.Send(host, timeout, buffer, pingOption);
                return (reply.Status == IPStatus.Success);
            } catch(Exception)
            {
                return false;
            }
        }
    }
}
