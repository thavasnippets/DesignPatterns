using System;
using System.Collections.Generic;
using System.Text;

namespace Dep_Inj
{
    class Propertyinjuction
    {
        public iCalc calcType { get; set; }

        public void print()
        {
            Console.WriteLine(calcType.Add(1, 3));
        }
    }
}
