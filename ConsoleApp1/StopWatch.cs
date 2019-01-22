using System;
using System.Threading;
using System.Timers;

namespace ConsoleApp1
{
    abstract class StopWatch : IStopWatch
    {
        string _name = null;
        Int64 _counter = 0;

        public StopWatch(string name)
        {
            Console.Write("watch");
            _name = name;
        }

        public void StartTimer()
        {
            Console.WriteLine("StartTimer {0}", _name);
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += (sender, e) => OnTimedEvent(sender, e, this);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;


            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        //public override void StopTimer();

        private static void OnTimedEvent(object source, ElapsedEventArgs e, StopWatch stopWatch)
        {
            Console.WriteLine("Hello World!", source);
            Console.WriteLine("v", stopWatch._counter);
            stopWatch._counter += 1;
            Console.WriteLine("_counter {0}", stopWatch._counter);
        }
    }
}
