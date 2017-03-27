using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class CoolEventArgs : EventArgs
    {
        public bool IsCool { get; set; }
        public int Number { get; set; }
    }
}
