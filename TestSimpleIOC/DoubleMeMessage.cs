using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSimpleIOC
{
    public class DoubleMeMessage
    {

        public DoubleMeMessage(int d, Action<int> f)
        {
            DoubleMe = d;
            Feedabck = f;
        }

        public int DoubleMe { get; set; }
        public Action<int> Feedabck { get; set; }
    }
}
