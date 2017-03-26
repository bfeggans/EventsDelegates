using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkHandler(int workId);

    public class Delegates
    {
        public Delegates()
        {
        }

        public static int WorkPerformed1(int id)
        {
            Console.WriteLine($"Work Performed 1: {id}");
            return id + 1;
        }

        public static int WorkPerformed2(int id)
        {
            Console.WriteLine($"Work Performed 2: {id}");
            return id + 2;
        }

        public static int WorkPerformed3(int id)
        {
            Console.WriteLine($"Work Performed 3: {id}");
            return id + 3;
        }
    }
}
