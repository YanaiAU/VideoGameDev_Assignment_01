using System;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int N = int.Parse(inputs[0]);
        int L = int.Parse(inputs[1]);
        int E = int.Parse(inputs[2]);

        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for (int i = 0; i < N; i++) graph[i] = new List<int>();

        for (int i = 0; i < L; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int N1 = int.Parse(inputs[0]);
            int N2 = int.Parse(inputs[1]);
            graph[N1].Add(N2);
            graph[N2].Add(N1);
        }

        HashSet<int> gateways = new HashSet<int>();
        for (int i = 0; i < E; i++)
        {
            int EI = int.Parse(Console.ReadLine());
            gateways.Add(EI);
        }

        while (true)
        {
            int SI = int.Parse(Console.ReadLine());

            int cut1 = -1, cut2 = -1;

            foreach (int neighbor in graph[SI])
            {
                if (gateways.Contains(neighbor))
                {
                    cut1 = SI;
                    cut2 = neighbor;
                    break;
                }
            }

            if (cut1 == -1)
            {
                cut1 = SI;
                cut2 = graph[SI][0];
            }

            graph[cut1].Remove(cut2);
            graph[cut2].Remove(cut1);

            Console.WriteLine($"{cut1} {cut2}");
        }
    }
}
