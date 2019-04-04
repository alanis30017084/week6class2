using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< Question 3 >>>\nThis app will calculate the sum of 20 numbers.");
            double sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Please ener number {i}: ");
                double num1 = double.Parse(Console.ReadLine());
                sum += num1;
            }
            Console.WriteLine($"The sum of the number you entered is: {sum}\nPlease press ENTER to quit.....");
            Console.ReadLine();
        }
    }
}
