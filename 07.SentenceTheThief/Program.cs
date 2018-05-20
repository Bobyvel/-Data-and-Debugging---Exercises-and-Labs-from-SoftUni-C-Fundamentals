using System;

namespace _07.SentenceTheThief
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

            var sentense = 0d;
            var period = "year";
            if (idThief > 0)
            {
                sentense = Math.Abs((double)idThief / sbyte.MaxValue);
            }
            else
            {
                sentense = Math.Abs((double)idThief / sbyte.MinValue);
            }

            if (sentense > 1)
            {
                period += "s";
            }
            Console.WriteLine($"Prisoner with id {idThief} is sentenced to {Math.Ceiling(sentense)} {period}");
        }
    }
}
