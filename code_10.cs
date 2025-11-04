using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());

        List<int> line = new List<int> { R };

        for (int currentLine = 1; currentLine < L; currentLine++)
        {
            List<int> nextLine = new List<int>();
            int count = 1;

            for (int i = 1; i < line.Count; i++)
            {
                if (line[i] == line[i - 1])
                {
                    count++;
                }
                else
                {
                    nextLine.Add(count);
                    nextLine.Add(line[i - 1]);
                    count = 1;
                }
            }

            nextLine.Add(count);
            nextLine.Add(line[line.Count - 1]);

            line = nextLine;
        }

        Console.WriteLine(string.Join(" ", line));
    }
}
