using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.ApplicationServices;
using ShutdownTimer.Presenters;

namespace ShutdownTimer.Core
{
    public class MainApplication : IApplication
    {
        public readonly MainPresenter mainPresenter;

        public MainApplication(MainPresenter mainPresenter)
        {
            this.mainPresenter = mainPresenter;
        }

        private void StartupNextInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {
            mainPresenter.mainView.ActivateView();
        }

        #region Hiện thực interface

        public void Run()
        {
            var mainForm = mainPresenter.mainView as Form;
            SingleInstanceApplicationStarter.Run(mainForm, StartupNextInstanceHandler);
            mainForm.Dispose();
        }

        #endregion
    }
}
