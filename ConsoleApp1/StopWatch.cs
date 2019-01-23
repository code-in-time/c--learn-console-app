using System;
using System.Threading;
using System.Timers;

namespace ConsoleApp1
{
    abstract class StopWatch : IWatch
    {
        string _name = null;
        Int64 _counter = 0;
        System.Timers.Timer aTimer = null;

        public StopWatch(models.WatchSettings ws)
        {
             _name = ws.Name;
            _counter = ws.Count;
        }

        public void StartTimer()
        {
            Console.WriteLine("StartTimer {0}", _name);
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += (sender, e) => OnTimedEvent(sender, e, this);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;


        }

        public void StopTimer()
        {
            aTimer.Enabled = false;
        }

        public void ResetTimer()
        {
            _counter = 0;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e, StopWatch stopWatch)
        {
            Console.WriteLine("name: {1}- count - {0}", stopWatch._counter, stopWatch._name);
            stopWatch._counter += 1;
        }
    }
}
