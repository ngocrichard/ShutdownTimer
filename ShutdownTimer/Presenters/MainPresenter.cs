using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

using ShutdownTimer.Views;
using ShutdownTimer.Services;
using ShutdownTimer.Models;

namespace ShutdownTimer.Presenters
{
    public class MainPresenter
    {
        public readonly IMainView mainView;
        public readonly ITimeModel timeModel;
        public readonly Timer timer;
        public readonly TimeService timeService;
        public readonly ShutdownService shutdownService;

        public MainPresenter(IMainView mainView, ITimeModel timeModel,
            Timer timer, TimeService timeService, ShutdownService shutdownService)
        {
            // Inject các thành phần vào presenter
            this.mainView = mainView;
            this.timeModel = timeModel;
            this.timer = timer;
            this.timeService = timeService;
            this.shutdownService = shutdownService;

            // Thiết lập 1 chu kì bằng 1 giây
            timer.Interval = 1000;

            // Xử lí các sự kiện
            mainView.Load += LoadHandler;
            mainView.ShutDownCommand += ShutdownHandler;
            mainView.CancelCommand += CancelHandler;
            timer.Tick += TickHandler;
        }

        // Xử lí khi load chương trình
        public void LoadHandler(object sender, EventArgs e)
        {
            mainView.IsCounting = false;
            // Hiển thị thời gian còn lại lên view
            timeModel.TimeLeft = new TimeSpan(0, 0, 0);
            UpdateTimeLeftOnView();
        }

        // Đặt lệnh shutdown
        public void ShutdownHandler(object sender, EventArgs e)
        {
            // Nếu thời gian thiết lập bằng 0 thì bỏ qua
            if (mainView.Hour == 0 && mainView.Minute == 0)
                return;

            // Lấy TimeSpan từ NumericUpDown vào model
            timeModel.TimeLeft = new TimeSpan(mainView.Hour, mainView.Minute, 0);
            // Khởi động lại đồng hồ
            timer.Stop();
            timer.Start();
            // Hiển thị thời gian còn lại lên view
            UpdateTimeLeftOnView();
            mainView.IsCounting = true;
        }

        // Xử lí mỗi khi đồng hồ đếm được một giây
        public void TickHandler(object sender, EventArgs e)
        {
            // Tắt máy nếu thời gian đếm ngược về không
            if ((int)timeModel.TimeLeft.TotalSeconds <= 1)
            {
                shutdownService.PerformShutdown();
                return;
            }

            // Giảm đi một giây
            timeModel.TimeLeft -= new TimeSpan(0, 0, 1);
            // Nếu còn một phút thì thông báo
            if ((int)timeModel.TimeLeft.TotalSeconds == 59)
                ShowOneMinuteLeftWarning();
            // Cập nhật lên view
            UpdateTimeLeftOnView();
        }

        // Huỷ lệnh hẹn giờ
        public void CancelHandler(object sender, EventArgs e)
        {
            // Nếu đồng hồ đã tắt thì bỏ qua
            if (!mainView.IsCounting)
                return;

            // Dừng đồng hồ
            timer.Stop();
            // Reset thời gian còn lại của model và view
            timeModel.TimeLeft = new TimeSpan(0, 0, 0);
            UpdateTimeLeftOnView();
            mainView.IsCounting = false;
        }

        // Hàm cập nhật thời gian còn lại lên view
        public void UpdateTimeLeftOnView()
        {
            mainView.TimeLeft = timeModel.TimeLeftCaption + timeService.TimeSpanToString(timeModel.TimeLeft);
        }

        // Hàm hiển thị thông báo trên view khi còn một phút
        public void ShowOneMinuteLeftWarning()
        {
            string caption = "Chuẩn bị tắt máy";
            string message = "Còn một phút trước khi tắt máy";
            mainView.ShowNotifyMessage(caption, message);
        }
    }
}
