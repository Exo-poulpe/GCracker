using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GCracker
{
    class BaseAttackor
    {

        public Form1 Parent { get; set; }

        private static Timer tmr;

        public void Init()
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Start();
            tmr.Elapsed += ElapsedTick;
        }

        public virtual void ElapsedTick(object sender, ElapsedEventArgs e)
        {
            new NotImplementedException();
        }
        public void Stop()
        {
            tmr.Stop();
        }


    }
}
