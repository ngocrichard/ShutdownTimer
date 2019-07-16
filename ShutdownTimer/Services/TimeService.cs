using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Services
{
    public class TimeService
    {
        public string TimeSpanToString(TimeSpan time)
        {
            return String.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
        }

        public TimeSpan StringToTimeSpan(string time)
        {
            var timeArr = time.Split(':');
            var hour = Convert.ToInt32(timeArr[0]);
            var minute = Convert.ToInt32(timeArr[1]);
            var second = Convert.ToInt32(timeArr[2]);

            if (hour < 0 || hour > 23)
                throw new Exception("Invalid time");
            if (minute < 0 || minute > 59)
                throw new Exception("Invalid time");
            if (second < 0 || second > 59)
                throw new Exception("Invalid time");

            return new TimeSpan(hour, minute, second);
        }
    }
}
