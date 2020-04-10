using System;
using System.Collections.Generic;
using System.Text;

namespace Dep_Inj
{
   public interface IUser
    {
        void AddUser();
    }
   public class DL : IUser
    {
        public void AddUser()
        {
            Console.WriteLine("Saved!");
        }

    }

   public class BL
    {
        IUser _dal;
      public  BL(IUser _ref)
        {
            _dal = _ref;
        }
        public void InsertUser()
        {
            _dal.AddUser();
        }
    }
    class DependencyInversion
    {
        public void Add()
        {
          
            BL BL = new BL(new DL());
            BL.InsertUser();

        }
       

    }
}
