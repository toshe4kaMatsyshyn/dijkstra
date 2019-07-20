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
        int FinalCost;

        public Graph(int[,] graph)
        {
            this.graph = graph;
            FinalWay = new int[graph.GetLength(0)];
        }

        public int FindCheapestWay()
        {
            int[] Cost = new int[graph.GetLength(0)];
            for(int i=1; i<Cost.Length; i++)
            {
                Cost[i] = int.MaxValue;
            }
            Cost[0] = 0;

            List<int> CurrentVertex = new List<int>();
            CurrentVertex.Add(0);

            while(CurrentVertex.Count!=0)
            {
                for(int i=0; i<CurrentVertex.Count;i++)
                {
                    for (int j = CurrentVertex[i] + 1; j<graph.GetLength(1); j++)
                    {
                        if(graph[CurrentVertex[i],j]!=int.MaxValue)
                        {
                            CurrentVertex.Add(j);
                            if(Cost[j] > Cost[CurrentVertex[i]]+graph[CurrentVertex[i],j])
                            {
                                Cost[j] = Cost[CurrentVertex[i]] + graph[CurrentVertex[i], j];
                                FinalWay[j] = CurrentVertex[i]; 
                            }
                        }
                    }
                    CurrentVertex.Remove(CurrentVertex[i]);
                    i--;
                }
            }
            FinalCost = Cost[Cost.Length - 1];
            return Cost[Cost.Length - 1];
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

        public static int[,] ReadGraphFromConsole(int N)
        {
            string[] inputdata = new string[N];
            for(int i=0; i<N; i++)
                inputdata[i] = Console.ReadLine();

            int[,] graph = new int[N + 1, N + 1];
            for(int i=0; i<N; i++)
            {
                string[] s = inputdata[i].Split(' ');
                for(int j=i; j<N; j++)
                {
                    graph[i, j + 1] = int.Parse(s[j-i]);
                }
            }
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    graph[i, j] = int.MaxValue;
                }
            }
            return graph;
        }
    }
}
