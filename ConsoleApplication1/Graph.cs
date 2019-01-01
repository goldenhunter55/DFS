using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Graph
    {
        int V;
        List<List<int>> adjList;

        public Graph(int V)
        {
            this.V = V;
            adjList = new List<List<int>>();
            for (int i = 0; i < V; i++)
            {
                adjList.Add(new List<int>());
            }
        }
        public void addEdge(int v, int edge)
        {
            adjList[v].Add(edge);
        }

        public void BFS(int S)
        {
            bool[] Visited = new bool[V];
            for (int i = 0; i < V; i++)
            {
                Visited[i] = false;
            }
            Visited[S] = true;
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(S);

            while (Q.Count > 0)
            {
                S = Q.Dequeue();
                Console.Write(S + " ");
                for (int i = 0; i < adjList[S].Count; i++)
                {
                    if (Visited[adjList[S][i]] == false)
                    {
                        Visited[adjList[S][i]] = true;
                        Q.Enqueue(adjList[S][i]);
                    }
                }
            }
        }

        public void DFSUtill(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            for (int i = 0; i < adjList[v].Count; i++)
            {
                int j = adjList[v][i];
                if (visited[j] == false)
                {
                    DFSUtill(j, visited);
                }
            }
        }
        public void DFS(int s)
        {
            bool [] Visited=new bool [V];

            DFSUtill(s, Visited);
        }

    }
}
