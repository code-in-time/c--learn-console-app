using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IStopWatch s = new Analogue("wwwwww");
            s.StartTimer();
        }

    }
}
