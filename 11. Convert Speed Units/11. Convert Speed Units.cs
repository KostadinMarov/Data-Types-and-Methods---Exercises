using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());

            int km = meters / 1000;
            float mi = meters / 1609f;

            int totalSec = ((hour * 60) * 60) + (min * 60) + sec;
            float totalHour = hour + min / 60f + sec / 60f / 60f ;

            Console.WriteLine((float)meters/totalSec);
            Console.WriteLine(km / totalHour);
            Console.WriteLine(mi / totalHour);
        }
    }
}
