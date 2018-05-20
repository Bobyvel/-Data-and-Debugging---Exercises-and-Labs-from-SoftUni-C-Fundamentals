using System;

namespace _08.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceFirst = Console.ReadLine();
            var priceSecond = Console.ReadLine();
            
            sbyte sbyteType;
            int intType;

            if (sbyte.TryParse(priceFirst, out sbyteType))
            {
                intType = int.Parse(priceSecond);
                
            }
            else
            {
                intType = int.Parse(priceFirst);
                sbyteType = sbyte.Parse(priceSecond);
            }

            long sum = (long)intType * 10 + sbyteType * 4;
            Console.WriteLine(sum);

            //second way
            var price1 = long.Parse(Console.ReadLine());
            var price2 = long.Parse(Console.ReadLine());

            sum = Math.Max(price1, price2) * 10 + Math.Min(price1, price2) * 4;
            Console.WriteLine(sum);

        }
    }
}
