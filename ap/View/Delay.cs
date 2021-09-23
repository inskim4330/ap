using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anipang.View
{
    class Delay
    {
        private static int _milliSeconds = 50;
        public static int MilliSeconds
        {
            get { return _milliSeconds; }
            set { _milliSeconds = value; }
        }
        public static void Make(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }
        public static void Make()
        {
            System.Threading.Thread.Sleep(MilliSeconds);
        }
    }
}
