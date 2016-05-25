using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Numbers_In_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {

            NumbersInReversedOrder();

        }

        static int NumbersInReversedOrder()
        {
            int num = int.Parse(Console.ReadLine());
            int reversed = 0;

                do
                {
                    reversed = num % 10;
                    num /= 10;
                    Console.Write(reversed);
                }

                while (num > 0);

            Console.WriteLine();

            return reversed;  
        }
    }
}
