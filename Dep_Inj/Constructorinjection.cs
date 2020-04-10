using System;
using System.Collections.Generic;
using System.Text;

namespace Dep_Inj
{
    class Constructorinjection
    {
        private iCalc _calc;
        public Constructorinjection(iCalc cal)
        {
            _calc = cal;

        }
        public void print()
        {
            Console.WriteLine(_calc.Add(1, 3));
        }
    }
}
