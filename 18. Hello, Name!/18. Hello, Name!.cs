using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            readLine(name);

        }

        static void readLine (string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
