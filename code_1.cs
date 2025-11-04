using System;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        string[] grid = new string[height];
        for (int y = 0; y < height; y++)
        {
            grid[y] = Console.ReadLine();
        }

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (grid[y][x] == '0')
                {
                    int rightX = -1, rightY = -1;
                    int bottomX = -1, bottomY = -1;

                    for (int nx = x + 1; nx < width; nx++)
                    {
                        if (grid[y][nx] == '0')
                        {
                            rightX = nx;
                            rightY = y;
                            break;
                        }
                    }

                    for (int ny = y + 1; ny < height; ny++)
                    {
                        if (grid[ny][x] == '0')
                        {
                            bottomX = x;
                            bottomY = ny;
                            break;
                        }
                    }

                    Console.WriteLine($"{x} {y} {rightX} {rightY} {bottomX} {bottomY}");
                }
            }
        }
    }
}
