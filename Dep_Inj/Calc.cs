using System;
using System.Collections.Generic;
using System.Text;

namespace Dep_Inj
{
    public class Calc : iCalc
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
