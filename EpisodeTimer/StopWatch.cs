using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EpisodeTimer
{
    class StopWatch
    {
        public delegate void Callback(TimeSpan time);
        public Callback timerCallback;

        private DateTime startTime;
        private TimeSpan savedTime;

        private Timer clock;

        public StopWatch(Callback callback)
        {
            timerCallback = callback;
            savedTime = TimeSpan.Zero;

            clock = new Timer();
            clock.Interval = 100;
            clock.Tick += new EventHandler(TimerTick);
        }

        public void TimerReset()
        {
            TimerStop();
            savedTime = TimeSpan.Zero;
        }

        public void TimerStart()
        {
            clock.Start();
            startTime = DateTime.Now;
        }

        public void TimerStop()
        {
            clock.Stop();
            savedTime  = (DateTime.Now - startTime) + savedTime;
        }
        
        public void TimerTick(object sender, EventArgs e)
        {
            timerCallback((DateTime.Now - startTime) + savedTime);
        }
    }
}
