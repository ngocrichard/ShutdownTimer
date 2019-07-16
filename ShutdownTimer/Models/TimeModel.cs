using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Models
{
    public class TimeModel : ITimeModel
    {
        public string TimeLeftCaption { get; protected set; }
        public TimeSpan TimeLeft { get; set; }

        public TimeModel()
        {
            TimeLeftCaption = "Thời gian còn lại: ";
        }
    }
}
