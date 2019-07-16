using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            SetEvents();
        }

        private void SetEvents()
        {
            btnShutdown.Click += TriggerShutdown;
            btnCancel.Click += TriggerCancel;
            btnMenuCancel.Click += TriggerCancel;
        }

        // Kích hoạt event đăng kí lệnh shutdown
        private void TriggerShutdown(object sender, EventArgs e)
        {
            ShutDownCommand?.Invoke(this, EventArgs.Empty);

            // Hiển thị notify icon
            mainNotifier.Visible = true;
        }
        // Kích hoạt event huỷ lệnh shutdown
        private void TriggerCancel(object sender, EventArgs e)
        {
            CancelCommand?.Invoke(this, EventArgs.Empty);

            // Ẩn notify icon
            mainNotifier.Visible = false;

            // Nếu huỷ từ tray (form đang ẩn) thì thoát chương trình
            if (!Visible)
                Close();
        }

        // Hiển thị lại form nếu nhấn vào notifier
        private void NotifierOnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                Activate();
            }
        }

        // Huỷ quyền thoát chương trình khi đang đếm ngược
        private void FormOnClosing(object sender, FormClosingEventArgs e)
        {
            if (IsCounting)
            {
                e.Cancel = true;
                Hide();
            }
        }

        #region Hiện thực interface
        public bool IsCounting { get; set; }
        public int Hour => (int)nudHour.Value;
        public int Minute => (int)nudMinute.Value;
        public string TimeLeft
        {
            get => lblTimeLeft.Text;
            set
            {
                lblTimeLeft.Text = value;
                btnMenuTimeLeft.Text = value;
            }
        }

        public event EventHandler ShutDownCommand;
        public event EventHandler CancelCommand;

        public void ShowNotifyMessage(string caption, string message)
        {
            mainNotifier.ShowBalloonTip(3000, caption, message, ToolTipIcon.Warning);
        }

        public void ActivateView()
        {
            WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }
        #endregion
    }
}
