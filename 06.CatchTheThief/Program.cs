using System;
using System.Linq;

namespace _06.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            var idType = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());

            var idThief = long.MinValue;

            for (int i = 0; i < lines; i++)
            {
                var number = long.Parse(Console.ReadLine());

                if (idType == "sbyte" && number <= sbyte.MaxValue && number > idThief)
                {
                    idThief = number;
                }
                else if (idType == "int" && number <= int.MaxValue && number > idThief)
                {
                    idThief = number;
                }
                else if (idType == "long" && number <= long.MaxValue && number > idThief)
                {
                    idThief = number; 
                }
            }

            Console.WriteLine(idThief);
        }
    }
}
