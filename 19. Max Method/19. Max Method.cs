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

            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(c, GetMax()));

        }
        
        static int GetMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
   
            return (Math.Max(a, b));
        }
    }
}
