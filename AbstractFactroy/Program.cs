using System;

namespace AbstractFactroy
{
    public abstract class Tree
    {
      
        public virtual string GetTreeName() { return ""; }
    }
    public class BananaTree : Tree
    {
        public override string GetTreeName()
        {
            return "My Name Is Banana Tree";
        }
    }

    public class CoconutTree : Tree
    {

        public override string GetTreeName()
        {
            return "My Name Is Coconut Tree";
        }
    }

  
    class Program
    {
        static void Main(string[] args)
        {
            Tree _tree = new BananaTree();
            Console.WriteLine(_tree.GetTreeName());
            _tree = new CoconutTree();
            Console.WriteLine(_tree.GetTreeName());
            
            Console.ReadKey();
        }
    }
}
