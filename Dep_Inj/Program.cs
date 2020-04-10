using System;

namespace Dep_Inj
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Constructorinjection obj = new Constructorinjection(new Calc());
            obj.print();


            Propertyinjuction probObj = new Propertyinjuction();
            probObj.calcType = new Calc();
            probObj.print();

            MethodInjection methodInj = new MethodInjection();
            methodInj.print(new Calc());


            DependencyInversion _inver = new DependencyInversion();
            _inver.Add();


            Console.ReadKey();


        }
    }
}
