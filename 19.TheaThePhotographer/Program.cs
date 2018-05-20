using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalPictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine()); //in seconds
            var goodPictures = long.Parse(Console.ReadLine()); // percentage 
            var uploadedTime = long.Parse(Console.ReadLine()); //in seconds

            var goodPicturesCount = (long) Math.Ceiling((totalPictures * goodPictures) / 100d);
            var totalTime = totalPictures * filterTime + goodPicturesCount * uploadedTime; //in seconds

            //timeSpan
            var result = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine($"{result.Days:D1}:{result.Hours:D2}:{result.Minutes:D2}:{result.Seconds:D2}");

            // as timeSpan
            var day = 0l;
            var hour = 0l;
            var seconds = totalTime % 60;
            var minutes = totalTime / 60;
            if (minutes > 59)
            {
                hour = minutes / 60;
                minutes = minutes % 60;

                if (hour > 23)
                {
                    day = hour / 24;
                    hour = hour % 24;
                }
            }

            Console.WriteLine($"{day:D1}:{hour:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
