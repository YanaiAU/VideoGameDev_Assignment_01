using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int nbFloors = int.Parse(inputs[0]);
        int width = int.Parse(inputs[1]);
        int nbRounds = int.Parse(inputs[2]);
        int exitFloor = int.Parse(inputs[3]);
        int exitPos = int.Parse(inputs[4]);
        int nbTotalClones = int.Parse(inputs[5]);
        int nbAdditionalElevators = int.Parse(inputs[6]);
        int nbElevators = int.Parse(inputs[7]);

        Dictionary<int, int> elevators = new Dictionary<int, int>();
        for (int i = 0; i < nbElevators; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int elevatorFloor = int.Parse(inputs[0]);
            int elevatorPos = int.Parse(inputs[1]);
            elevators[elevatorFloor] = elevatorPos;
        }

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int cloneFloor = int.Parse(inputs[0]);
            int clonePos = int.Parse(inputs[1]);
            string direction = inputs[2];

            if (cloneFloor == -1) 
            {
                Console.WriteLine("WAIT");
                continue;
            }

            int targetPos;
            if (cloneFloor == exitFloor)
                targetPos = exitPos;
            else if (elevators.ContainsKey(cloneFloor))
                targetPos = elevators[cloneFloor];
            else
                targetPos = 0;

            if ((direction == "RIGHT" && clonePos > targetPos) ||
                (direction == "LEFT" && clonePos < targetPos))
            {
                Console.WriteLine("BLOCK");
            }
            else
            {
                Console.WriteLine("WAIT");
            }
        }
    }
}
