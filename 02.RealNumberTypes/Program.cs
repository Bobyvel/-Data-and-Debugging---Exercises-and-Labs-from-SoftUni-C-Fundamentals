using System;

namespace _02.RealNumberTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfDigits = byte.Parse(Console.ReadLine());
            var realNumber = Console.ReadLine();

            if (countOfDigits < 7) //6-7 float
            {
                Console.WriteLine(float.Parse(realNumber));
            }
            else if(countOfDigits < 16)// 15-16 double
            {
               Console.WriteLine(double.Parse(realNumber));
            }
            else
            {
               Console.WriteLine(decimal.Parse(realNumber));
            }

            
        }
    }
}
