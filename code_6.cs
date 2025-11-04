using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxSoFar = values[0];
        int maxLoss = 0;

        for (int i = 1; i < n; i++)
        {
            int loss = values[i] - maxSoFar;
            if (loss < maxLoss)
                maxLoss = loss;

            if (values[i] > maxSoFar)
                maxSoFar = values[i];
        }

        Console.WriteLine(maxLoss);
    }
}
