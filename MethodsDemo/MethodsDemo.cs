using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class MethodsDemo
    {
        static void Main(string[] args)
        {



           

        }
        static double GetRactangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine(area);
            return area;
        }

        static void PrintLogo()
        {
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
        }


        static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
                {
                totalAmount += singleBookPrice;
                }
            Console.WriteLine("The total amount of all books is:" + totalAmount);
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            
                if (number2 > max)
                {
                max = number2;
                }
            Console.WriteLine("Maximal number: {0}", max);
        }

    }

}
