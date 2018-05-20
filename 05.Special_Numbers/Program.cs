using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A number is special when its sum of digits is 5, 7 or 11. 
            var number = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
                
            }

            var special = sum == 5 || sum == 7 || sum == 11 ? "is special" : "is not special";
            Console.WriteLine($"{number} {special}");
           
        }
    }
}
