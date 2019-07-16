namespace ShutdownTimer.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.mainNotifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotifier = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMenuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuTimeLeft = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.menuNotifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(13, 41);
            this.nudHour.Margin = new System.Windows.Forms.Padding(4);
            this.nudHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(72, 27);
            this.nudHour.TabIndex = 1;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(96, 41);
            this.nudMinute.Margin = new System.Windows.Forms.Padding(4);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(72, 27);
            this.nudMinute.TabIndex = 0;
            this.nudMinute.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblHour
            // 
            this.lblHour.Location = new System.Drawing.Point(10, 9);
            this.lblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(75, 28);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Giờ";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinute
            // 
            this.lblMinute.Location = new System.Drawing.Point(93, 9);
            this.lblMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(75, 28);
            this.lblMinute.TabIndex = 3;
            this.lblMinute.Text = "Phút";
            this.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(188, 9);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(100, 59);
            this.btnShutdown.TabIndex = 2;
            this.btnShutdown.Text = "Tắt máy";
            this.btnShutdown.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 59);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(101, 83);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(205, 20);
            this.lblTimeLeft.TabIndex = 7;
            this.lblTimeLeft.Text = "Thời gian còn lại: 00:00:00";
            // 
            // mainNotifier
            // 
            this.mainNotifier.ContextMenuStrip = this.menuNotifier;
            this.mainNotifier.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifier.Icon")));
            this.mainNotifier.Text = "Hẹn giờ tắt máy";
            this.mainNotifier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NotifierOnClick);
            // 
            // menuNotifier
            // 
            this.menuNotifier.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNotifier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuTimeLeft,
            this.btnMenuCancel});
            this.menuNotifier.Name = "menuNotifier";
            this.menuNotifier.Size = new System.Drawing.Size(250, 52);
            // 
            // btnMenuCancel
            // 
            this.btnMenuCancel.Name = "btnMenuCancel";
            this.btnMenuCancel.Size = new System.Drawing.Size(249, 24);
            this.btnMenuCancel.Text = "Huỷ lệnh tắt máy";
            // 
            // btnMenuTimeLeft
            // 
            this.btnMenuTimeLeft.Name = "btnMenuTimeLeft";
            this.btnMenuTimeLeft.Size = new System.Drawing.Size(249, 24);
            this.btnMenuTimeLeft.Text = "Thời gian còn lại: 00:00:00";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 119);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hẹn giờ tắt máy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOnClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.menuNotifier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.NotifyIcon mainNotifier;
        private System.Windows.Forms.ContextMenuStrip menuNotifier;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCancel;
        private System.Windows.Forms.ToolStripMenuItem btnMenuTimeLeft;
    }
}

