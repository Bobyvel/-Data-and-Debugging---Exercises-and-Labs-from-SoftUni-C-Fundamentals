using System;
using System.Runtime.InteropServices;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = Convert.ToBoolean(input);

            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            
        }
    }
}
