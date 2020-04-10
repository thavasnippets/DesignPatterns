using System;
using Unity;
using System.Runtime.CompilerServices;
namespace DI_UNITY
{
    class Program
    {
        static void Main(string[] args)
        {
            derivedcls _ = new derivedcls();
            Console.WriteLine(   _.add(1));
            IUnityContainer _container = new UnityContainer();
            _container.RegisterType<MiddleLayer>();
            _container.RegisterType<iDAL, MYSQL>();
            _container.RegisterType<iDAL,SQLSERVER>();
          

            MiddleLayer _ml = _container.Resolve<MiddleLayer>();

            _ml.Add();
            Console.ReadKey();

        }
    }

    class MiddleLayer
    {
        private iDAL _dal;

        public MiddleLayer(iDAL dal)
        {
            _dal = dal;
        }
        public void Add()
        {
            _dal.Add();
        }
    }

    interface iDAL
    {
        void Add();
    }
    class SQLSERVER : iDAL
    {
        public void Add()
        {
            Console.WriteLine("Message from SQLSERVER");
        }
    }

    class MYSQL : iDAL
    {
        public void Add()
        {
            Console.WriteLine("Message from MYSQL");
        }
    }

    class basecls
    {
       
    }
    class derivedcls:basecls
    {
        public  char add(int a)
        {
            return 'a';
        }
        public int add(int a)
        {
            return 0;
        }
    }
}
