using System;

namespace _06.IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var overflow = 0;
            byte sum = 0;
            for (int i = 0; i < lines; i++)
            {
                sum ++;

                if (sum == 0)
                {
                    overflow ++;
                }
            }

            Console.WriteLine(sum);
            if (overflow != 0)
            {
                Console.WriteLine($"Overflowed {overflow} times"); 
            }
            
        }
    }
}
