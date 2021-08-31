using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_PRG
{
    // This class requires "using System.Threading;" at the top of the class to work
    public class MusicTimer
    {
        private int Time = 0;

        public MusicTimer(int TimeToRunForInSeconds = 10)
        {
            Time = TimeToRunForInSeconds;
        }

        public int Start(Action<int> TickFunction)
        {
            // The function passed in needs to be marked "static"
            TickFunction(Time);
            Time -= 1;

            Thread.Sleep(1000);

            if (Time > 0)
                Start(TickFunction);
            return Time;
        }
    }
}
