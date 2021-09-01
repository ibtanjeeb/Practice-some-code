using System;

namespace TSP
{
    class Program
    {
        static int tsp(int[,] graph, bool[] v, int currpos,
            int n,int count,int cost,int ans)
        {
            if (count == n && graph[currpos,0]>0)
            {
                ans = Math.Min(ans, cost + graph[currpos, 0]);

                return ans;
            }

            for (var i= 0;  i < n ; i++)
            {
                if(v[i]== false && graph[currpos,i] > 0)
                {
                    v[i ]= true;
                    ans = tsp(graph, v, i, n, count + 1, cost + graph[currpos, i], ans);
                    v[i] = false;


                }
            }
            return ans;

            

        }
        static void Main(string[] args)
        {
            int n = 4;

            int[,] graph = {
                             {  10,0, 15, 20 },
                             { 10, 0, 25, 35 },
                             { 15, 35, 0, 30 },
                             { 20, 25, 30, 0 }
                             };

            // Boolean array to check if a node
            // has been visited or not
            bool[] v = new bool[n];

            // Mark 0th node as visited
            v[0] = true;
            int ans = int.MaxValue;

            // Find the minimum weight Hamiltonian Cycle
            ans = tsp(graph, v, 0, n, 1, 0, ans);

            Console.WriteLine(ans);
        }
    }
}
