using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class clsSingleTon
    {
        private static int instanceCreationCounter = 0;
        private static readonly object _obj = new object();
        //private static clsSingleTon instance = null;
        //public static clsSingleTon getInstance
        //{
        //    get
        //    {
        //        lock (_obj)
        //        {
        //            if (instance == null)
        //                instance = new clsSingleTon();
        //        }
        //        return instance;

        //    }
        //}


        //Egar loading
        //private static readonly  clsSingleTon instance = new clsSingleTon();
        //public static clsSingleTon getInstance
        //{
        //    get
        //    {
        //        return instance;

        //    }
        //}

        //Lazy Loading
        private static readonly Lazy<clsSingleTon> instance = new Lazy<clsSingleTon>(()=> new clsSingleTon() );
        public static clsSingleTon getInstance
        {
            get
            {
                return instance.Value;

            }
        }
        private clsSingleTon()
        {
            instanceCreationCounter++;
            Console.WriteLine("Instance:" + instanceCreationCounter);

        }
        public void printValue(string val)
        {
            Console.WriteLine(val);
        }
    }
}
