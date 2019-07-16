using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ShutdownTimer.Core
{
    public class SingleInstanceApplicationStarter : WindowsFormsApplicationBase
    {
        protected SingleInstanceApplicationStarter()
        {
            IsSingleInstance = true;
        }

        public static void Run(Form mainForm, StartupNextInstanceEventHandler handler)
        {
            var starter = new SingleInstanceApplicationStarter();

            starter.MainForm = mainForm;
            starter.StartupNextInstance += handler;
            starter.Run(Environment.GetCommandLineArgs());
        }
    }
}
