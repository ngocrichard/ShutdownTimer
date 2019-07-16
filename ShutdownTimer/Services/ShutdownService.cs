using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownTimer.Services
{
    public class ShutdownService
    {
        public void PerformShutdown()
        {
            Process.Start("cmd.exe", "/c shutdown /s /f /t 0");
        }
    }
}
