using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]);
        int lightY = int.Parse(inputs[1]);
        int thorX = int.Parse(inputs[2]);
        int thorY = int.Parse(inputs[3]);

        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine());

            string move = "";

            if (thorY > lightY) move += "N";
            else if (thorY < lightY) move += "S";

            if (thorX > lightX) move += "W";
            else if (thorX < lightX) move += "E";

            Console.WriteLine(move);

            if (move.Contains("N")) thorY--;
            if (move.Contains("S")) thorY++;
            if (move.Contains("W")) thorX--;
            if (move.Contains("E")) thorX++;
        }
    }
}
