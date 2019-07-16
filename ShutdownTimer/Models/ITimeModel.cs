using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Models
{
    public interface ITimeModel
    {
        string TimeLeftCaption { get; }
        TimeSpan TimeLeft { get; set; }
    }
}
