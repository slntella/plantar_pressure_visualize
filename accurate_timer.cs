// AccurateTimer.cs
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Semester_Project_Plantar_Pressure
{
    class AccurateTimer
    {
        private delegate void TimerEventDel(int id, int msg, IntPtr user, int dw1, int dw2);
        private const int TIME_PERIODIC = 1;
        private const int EVENT_TYPE = TIME_PERIODIC;
        [DllImport("winmm.dll")]
        private static extern int timeBeginPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeEndPeriod(int msec);
        [DllImport("winmm.dll")]
        private static extern int timeSetEvent(int delay, int resolution, TimerEventDel handler, IntPtr user, int eventType);
        [DllImport("winmm.dll")]
        private static extern int timeKillEvent(int id);

        Action mAction;
        Form mForm;
        private int mTimerId;
        private TimerEventDel mHandler;
        private bool mRunning = false;

        public AccurateTimer(Form form, Action action, int delay)
        {
            if (delay != -1)
            {
                mAction = action;
                mForm = form;
                timeBeginPeriod(1);
                mHandler = new TimerEventDel(TimerCallback);
                mTimerId = timeSetEvent(delay, 0, mHandler, IntPtr.Zero, EVENT_TYPE);
                mRunning = true;
            }
            else
            {
                mRunning = false;
            }

        }

        public void Stop()
        {
            int err = timeKillEvent(mTimerId);
            mRunning = false;
            timeEndPeriod(1);
            System.Threading.Thread.Sleep(100);// Ensure callbacks are drained
        }

        private void TimerCallback(int id, int msg, IntPtr user, int dw1, int dw2)
        {
            if (mTimerId != 0)
                mForm.BeginInvoke(mAction);
        }

        public bool IsRunning()
        {
            return mRunning;
        }
    }
    public class MyStopwatch : Stopwatch
    {
        public TimeSpan StartOffset { get; private set; }

        public MyStopwatch(TimeSpan startOffset)
        {
            StartOffset = startOffset;
        }
        public new long ElapsedMilliseconds
        {
            get
            {
                return base.ElapsedMilliseconds + (long)StartOffset.TotalMilliseconds;
            }
        }

        public new long ElapsedTicks
        {
            get
            {
                return base.ElapsedTicks + StartOffset.Ticks;
            }
        }
    }
}