using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Worker
    {
        //public event EventHandler<CoolEventArgs> WorkEvent;
        //
        //can use the sugar above to avoid declaring a delegate and just use the event
        //can't do that here because of the delegates usage in Program.cs

        public event EventHandler WorkEvent;
        public event EventHandler WorkDone;

        public void DoSomeWork(int hours)
        {
            //before calling events make sure the delegate list isn't empty

            for (int i = 0; i < hours; i++)
            {
                //raise workevent
                WorkEvent?.Invoke(this, new CoolEventArgs()
                {
                    IsCool = true,
                    Number = i + 1
                });
            }

            var args = new CoolEventArgs()
            {
                IsCool = true,
                Number = hours
            };
            //raise workdone
            WorkDone?.Invoke(this, args);
        }
    }
}
 