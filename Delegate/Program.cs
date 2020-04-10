using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //E.g: 2
        public delegate int operation(int i, int j);
        static int sum(int i, int j)
        {
            return i * j;
        }

        static void Main(string[] args)
        {
            //E.g: 1
            MyClass _myClass = new MyClass();
            _myClass.LongRunningQueue(callback);

            //E.g: 2

            operation _obj = sum;
            Console.WriteLine(_obj(1, 4));
           

            //E.3 : Anonymous  

            operation _AnoObj = new operation(
                delegate (int i, int j)
                {
                    return i + j;
                }
                );
            Console.WriteLine(_AnoObj(1, 6));

            //E.g: 2: Lamda
            operation _lamda = (i, j) => i * j;

            Console.WriteLine(_lamda(1, 6));

            //E.g: 2: Func
            Func<int,int,int> _func = (i, j) => i * j;

            Console.WriteLine(_func(1, 6));

            //E.g: 2: Action
            Action<string> _action = inp =>Console.WriteLine(inp);

           _action("Hello");

            //E.g: 2: predicate
            Predicate<string> _predicate = inp =>inp.Length>5;

            Console.WriteLine(_predicate("Hello"));

            Console.ReadKey();
        }

        //E.g: 1
        public static void callback(int i)
        {
            Console.WriteLine(i);
        }

    }

    //E.g: 1
    class MyClass
    {
        public delegate void Callback(int i);
        public void LongRunningQueue(Callback obj)
        {
            for (int i = 0; i < 100; i++)
            {
                obj(i);
            }
        }
    }
}
