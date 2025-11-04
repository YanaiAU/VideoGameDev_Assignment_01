using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] xs = new int[N];
        int[] ys = new int[N];

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            xs[i] = int.Parse(inputs[0]);
            ys[i] = int.Parse(inputs[1]);
        }

        Array.Sort(xs);
        Array.Sort(ys);

        int xMin = xs[0];
        int xMax = xs[N - 1];

        int yMedian = ys[N / 2];

        long totalLength = (long)(xMax - xMin);

        foreach (int y in ys)
        {
            totalLength += Math.Abs(y - yMedian);
        }

        Console.WriteLine(totalLength);
    }
}
