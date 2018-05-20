using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

           
            for (int i = 1; i <= number; i++)
            {
                var sum = 0;
                var currentNum = i;
                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                var isSpesial = sum == 5 || sum == 7 || sum == 11;
                
                    Console.WriteLine($"{i} -> {isSpesial}");
                
            }
        }
    }
}
