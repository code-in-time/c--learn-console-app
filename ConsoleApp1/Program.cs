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
            IWatch s = new Analogue(new models.WatchSettings { Count = 3, Name = "h1"});
            s.StartTimer();

            IWatch x = new Analogue(new models.WatchSettings { Count = 88, Name = "b3" });
            x.StartTimer();

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

    }
}
