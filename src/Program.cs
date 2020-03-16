// using System;
// using PublicClass;
// // using Graph;
// using PublicTestTool;
namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Solution();
            Graph.Node n0 = new Graph.Node(0);
            Graph.Node n1 = new Graph.Node(1);
            Graph.Node n2 = new Graph.Node(2);
            Graph.Node n3 = new Graph.Node(3);
            n0.neighbors.Add(n1);
            n0.neighbors.Add(n3);
            n1.neighbors.Add(n0);
            n1.neighbors.Add(n2);
            n2.neighbors.Add(n1);
            n2.neighbors.Add(n3);
            n3.neighbors.Add(n0);
            n3.neighbors.Add(n2);
            a.CloneGraph(n0);
            System.Console.Write("hello");
        }
    }
}
