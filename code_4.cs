using System;
using System.Collections.Generic;

class Solution
{
    static Dictionary<string, int> cardValues = new Dictionary<string, int>()
    {
        {"2", 2}, {"3", 3}, {"4", 4}, {"5", 5}, {"6", 6}, {"7", 7}, {"8", 8}, {"9", 9},
        {"10", 10}, {"J", 11}, {"Q", 12}, {"K", 13}, {"A", 14}
    };

    static int GetCardValue(string card)
    {
        string value = card.Length == 3 ? card.Substring(0, 2) : card.Substring(0, 1);
        return cardValues[value];
    }

    static void Main(string[] args)
    {
        Queue<string> p1 = new Queue<string>();
        Queue<string> p2 = new Queue<string>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) p1.Enqueue(Console.ReadLine());

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++) p2.Enqueue(Console.ReadLine());

        int rounds = 0;

        while (p1.Count > 0 && p2.Count > 0)
        {
            rounds++;
            List<string> warPile1 = new List<string>();
            List<string> warPile2 = new List<string>();

            // Draw the top cards
            warPile1.Add(p1.Dequeue());
            warPile2.Add(p2.Dequeue());

            while (true)
            {
                int val1 = GetCardValue(warPile1[warPile1.Count - 1]);
                int val2 = GetCardValue(warPile2[warPile2.Count - 1]);

                if (val1 > val2)
                {
                    foreach (var c in warPile1) p1.Enqueue(c);
                    foreach (var c in warPile2) p1.Enqueue(c);
                    break;
                }
                else if (val2 > val1)
                {
                    foreach (var c in warPile1) p2.Enqueue(c);
                    foreach (var c in warPile2) p2.Enqueue(c);
                    break;
                }
                else
                {

                    if (p1.Count < 3 || p2.Count < 3)
                    {
                        Console.WriteLine("PAT");
                        return;
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        warPile1.Add(p1.Dequeue());
                        warPile2.Add(p2.Dequeue());
                    }

                    warPile1.Add(p1.Dequeue());
                    warPile2.Add(p2.Dequeue());
                }
            }
        }

        Console.WriteLine(p1.Count > 0 ? "1 " + rounds : "2 " + rounds);
    }
}
