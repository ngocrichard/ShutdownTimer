using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer.Views
{
    public interface IMainView : IActivateView
    {
        bool IsCounting { get; set; }
        int Hour { get; }
        int Minute { get; }
        string TimeLeft { get; set; }

        event EventHandler Load;
        event EventHandler ShutDownCommand;
        event EventHandler CancelCommand;

        void ShowNotifyMessage(string caption, string message);
    }
}
