using System;

namespace _14.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoat = char.Parse(Console.ReadLine());
            var secondBoat = char.Parse(Console.ReadLine());
            var lines = byte.Parse(Console.ReadLine());
            
            var firstBoatSpeed = 0;
            var secondBoatSpeed = 0;
            var winnerMoves = 50;
            for (int i = 1; i <= lines; i++)
            {
                var input = Console.ReadLine();
                if (input == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        firstBoatSpeed += input.Length;

                        if (firstBoatSpeed >= winnerMoves)
                        {
                            Console.WriteLine(firstBoat);
                            return;
                        }
                    }
                    else
                    {
                        secondBoatSpeed += input.Length;

                        if (secondBoatSpeed >= winnerMoves)
                        {
                            Console.WriteLine(secondBoat);
                            return;
                        }
                    }  
                }
               

            }

            var winner = firstBoatSpeed > secondBoatSpeed ? firstBoat : secondBoat;

            Console.WriteLine(winner);

        }
    }
}
