using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Algorihm
{
    class Graph
    {
        /// <summary>
        /// Матрица смежности
        /// </summary>
        int[,] graph;

        /// <summary>
        /// Массив для восстановления кратчайшего пути
        /// </summary>
        int[] FinalWay;

        /// <summary>
        /// Стоимость кратчайшего пути
        /// </summary>
        int FinalWeight;

        Graph(int[,] graph)
        {
            this.graph = graph;
            FinalWay = new int[graph.GetLength(0)];
        }

        public static int[,] CreateRandomGraph(int N)
        {
            Random random = new Random();
            int[,] graph = new int[N + 1, N + 1];
            for(int i=0; i<graph.GetLength(0); i++)
            {
                for(int j=0; j<graph.GetLength(1); j++)
                {
                    graph[i, j] = j <= i ? int.MaxValue : random.Next(1000);
                }
            }
            return graph;
        }
    }
}
