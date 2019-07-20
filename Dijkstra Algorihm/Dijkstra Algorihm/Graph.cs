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
    }
}
