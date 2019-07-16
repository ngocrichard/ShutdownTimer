using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ninject;
using ShutdownTimer.Models;
using ShutdownTimer.Views;
using ShutdownTimer.Presenters;
using ShutdownTimer.Core;

namespace ShutdownTimer
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cấu hình IoC container
            var kernel = new StandardKernel();
            kernel.Bind<IMainView>().To<MainView>();
            kernel.Bind<ITimeModel>().To<TimeModel>();
            kernel.Bind<IApplication>().To<MainApplication>();

            // Tạo single instance application và chạy chương trình
            var app = kernel.Get<IApplication>();
            app.Run();
        }
    }
}
