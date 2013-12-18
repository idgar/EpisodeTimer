using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EpisodeTimer
{
    public partial class TimerForm : Form
    {
        private StopWatch watch = new StopWatch(UpdateTime);
        private bool isRunning = false;

        private static TimerForm activeInstance;

        public TimerForm()
        {
            InitializeComponent();
            activeInstance = this;
        }

        public static void UpdateTime(TimeSpan time)
        {
            activeInstance.lblDuration.Text = (time.Hours * 60 + time.Minutes).ToString() + ":"
                + (time.Seconds > 9 ? time.Seconds.ToString() : "0" + time.Seconds.ToString());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                watch.TimerStop();
                btnStart.Text = "Start";
                isRunning = false;
            }
            else
            {
                watch.TimerStart();
                btnStart.Text = "Stop";
                isRunning = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            watch.TimerReset();
            lblDuration.Text = "0:00";
        }
    }
}
