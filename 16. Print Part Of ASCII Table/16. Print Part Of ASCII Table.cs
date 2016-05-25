using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                char toChar = Convert.ToChar(num1);
                string toChar2 = toChar.ToString();
                Console.Write(toChar + " ");
                num1 += 1;
            }
            Console.WriteLine();

        }
    }
}
