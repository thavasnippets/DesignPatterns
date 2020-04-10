using System;
using System.Collections.Generic;
using System.Text;

namespace Dep_Inj
{
    class MethodInjection
    {
        public void print(iCalc calc)
        {
            Console.WriteLine(calc.Add(1, 3));
        }
    }
}
