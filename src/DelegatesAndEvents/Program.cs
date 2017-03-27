using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkHandler del1 = new WorkHandler(Delegates.WorkPerformed1);
            WorkHandler del2 = new WorkHandler(Delegates.WorkPerformed2);
            WorkHandler del3 = new WorkHandler(Delegates.WorkPerformed3);

            del1 += del3 + del2;

            int retVal = DoWork(del1);
            Console.WriteLine(retVal);

            var worker = new Worker();
            worker.DoSomeWork(7);

            Console.Read();
        }

        static int DoWork(WorkHandler del)
        {
            int retVal = 0;
            //after doing some work, call my delegate
            for (int i = 0; i < 1000; i++)
            {
                retVal += 1;
                continue;
            }

            return del(new object(), new CoolEventArgs() {
                IsCool = true,
                Number = retVal});
        }
    }
}
