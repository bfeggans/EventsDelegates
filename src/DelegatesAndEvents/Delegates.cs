using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkHandler(object sender, CoolEventArgs e);

    public class Delegates
    {
        public Delegates()
        {
        }

        public static int WorkPerformed1(object sender, CoolEventArgs e)
        {
            Console.WriteLine($"Work Performed 1: {e.Number}");
            return e.Number + 1;
        }

        public static int WorkPerformed2(object sender, CoolEventArgs e)
        {
            Console.WriteLine($"Work Performed 2: {e.Number}");
            return e.Number + 2;
        }

        public static int WorkPerformed3(object sender, CoolEventArgs e)
        {
            Console.WriteLine($"Work Performed 3: {e.Number}");
            return e.Number + 3;
        }
    }
}
