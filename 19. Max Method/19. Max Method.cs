using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GetMax();

        }
        
        static void GetMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = Math.Max(a, b);
            Console.WriteLine(max);
        }



    }
}
