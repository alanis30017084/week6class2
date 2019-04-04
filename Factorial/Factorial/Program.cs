using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< Question 4 >>>\nThis app will calculate the factorial of 10");
            int counter = 1;
            int sum = 1;
            while (counter <= 10)
            {
                sum *= counter;
                counter++;
            }
            Console.WriteLine($"10 factorial is: {sum}\nPlease press ENTER to quit.....");
            Console.ReadLine();

        }
    }
}
