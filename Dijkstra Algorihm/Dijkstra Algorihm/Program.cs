using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Algorihm
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] graphMatrix = Graph.CreateRandomGraph(N);
            Graph graph = new Graph(graphMatrix);
            Console.WriteLine(graph.FindCheapestWay());
            Console.WriteLine(graph.RestoreTheWay());
            Console.WriteLine(graph);
            Console.ReadKey();
        }
    }
}