using System;

namespace _10.DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = ulong.Parse(Console.ReadLine());
            var num2 = ulong.Parse(Console.ReadLine());

            var biggerType = "ulong";
            var smallerType = "ulong";
            var biggerNumber = Math.Max(num1, num2);
            var smallerNumber = Math.Min(num1, num2);

            if (biggerNumber >= byte.MinValue && biggerNumber <= byte.MaxValue)
            {
                biggerType = "byte";
            }
            else if (biggerNumber >= ushort.MinValue && biggerNumber <= ushort.MaxValue)
            {
                biggerType = "ushort";
            }
            else if (biggerNumber >= uint.MinValue && biggerNumber <= uint.MaxValue)
            {
                biggerType = "uint";
            }


            if (smallerNumber >= byte.MinValue && smallerNumber <= byte.MaxValue)
            {
                smallerType = "byte";
            }
            else if (smallerNumber >= ushort.MinValue && smallerNumber <= ushort.MaxValue)
            {
                smallerType = "ushort";
            } 
            else if (smallerNumber >= uint.MinValue && smallerNumber <= uint.MaxValue)
            {
                smallerType = "uint";
            }

            
            var divider = 0d;
            switch (smallerType)
            {
                case "byte":
                    divider = byte.MaxValue;
                    break;
                case "ushort":
                    divider = ushort.MaxValue;
                    break;
                case "uint":
                    divider = uint.MaxValue;
                    break;
                case "ulong":
                    divider = ulong.MaxValue;
                    break;
            }

            var overflow = Math.Round(biggerNumber / divider);

            Console.WriteLine($"bigger type: {biggerType}");
            Console.WriteLine($"smaller type: {smallerType}");
            Console.WriteLine($"{biggerNumber} can overflow {smallerType} {overflow} times");
        }



    }
}
