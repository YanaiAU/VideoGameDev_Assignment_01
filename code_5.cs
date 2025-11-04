using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        int N = int.Parse(Console.ReadLine());
        inputs = Console.ReadLine().Split(' ');
        int X = int.Parse(inputs[0]);
        int Y = int.Parse(inputs[1]);

        int minX = 0, maxX = W - 1;
        int minY = 0, maxY = H - 1;

        while (true)
        {
            string bombDir = Console.ReadLine();

            if (bombDir.Contains("U")) maxY = Y - 1;
            if (bombDir.Contains("D")) minY = Y + 1;
            if (bombDir.Contains("L")) maxX = X - 1;
            if (bombDir.Contains("R")) minX = X + 1;

            X = (minX + maxX) / 2;
            Y = (minY + maxY) / 2;

            Console.WriteLine($"{X} {Y}");
        }
    }
}
