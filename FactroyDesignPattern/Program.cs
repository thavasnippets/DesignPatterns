using System;

namespace FactroyDesignPattern
{
    public interface ITree
    {
        string GetTreeName();
    }
    public class BananaTree : ITree
    {
        public string GetTreeName()
        {
            return "My Name Is Banana Tree";
        }
    }

    public class CoconutTree : ITree
    {
        public string GetTreeName()
        {
            return "My Name Is Coconut Tree";
        }
    }

    public interface TreeType
    {
        ITree GetTree(string tree);
    }

    public class ConcreteTreeType : TreeType
    {

        public ITree GetTree(string tree)
        {

            if (tree == "COCONUT")
                return new CoconutTree();
            else
                return new BananaTree();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeType oTreeType = new ConcreteTreeType();

            ITree banana = oTreeType.GetTree("BANANA");
            Console.WriteLine(banana.GetTreeName());

            ITree cOCONUT = oTreeType.GetTree("COCONUT");
            Console.WriteLine(cOCONUT.GetTreeName());

            Console.ReadKey();

        }
    }
}
