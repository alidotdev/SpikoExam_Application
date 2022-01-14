using SpikoDesktop.Services;
using System.Windows.Forms;

namespace SpikoDesktop.Utility
{
    class TimerUtility
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        private Form form;

        public TimerUtility() { }
        public TimerUtility(int hr, int min, int sec)
        {
            Hours = hr;
            Minutes = min;
            Seconds = sec;
        }

        public void AssignForm(Form f)
        {
            form = f;
        }
        public void ResetTimer()
        {
            Logger.log.Info("Timer is reset");
            Hours = 0;
            Minutes = 0;
            Seconds = 1;
        }

    }
}
