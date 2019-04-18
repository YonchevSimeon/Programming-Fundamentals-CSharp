using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoHealthPoints = 100;
            int goshoHealthPoints = 100;

            int peshoAttackPower = int.Parse(Console.ReadLine());
            int goshoAttackPower = int.Parse(Console.ReadLine());

            int turn = 0;
            int restorePointsTurn = 3;

            while (true)
            {
                goshoHealthPoints -= peshoAttackPower;
                turn++;
                if(goshoHealthPoints <= 0)
                {
                    Console.WriteLine($"Pesho won in {turn}th round.");
                    return;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealthPoints} health.");

                if (turn >= restorePointsTurn)
                {
                    peshoHealthPoints += 10;
                    goshoHealthPoints += 10;
                    restorePointsTurn += 3;
                }


                peshoHealthPoints -= goshoAttackPower;
                turn++;
                if(peshoHealthPoints <= 0)
                {
                    Console.WriteLine($"Gosho won in {turn}th round.");
                    return;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealthPoints} health.");
                if (turn >= restorePointsTurn)
                {
                    peshoHealthPoints += 10;
                    goshoHealthPoints += 10;
                    restorePointsTurn += 3;
                }

            }
        }
    }
}
