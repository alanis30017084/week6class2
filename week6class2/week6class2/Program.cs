using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("<<< Question 1 >>>\nPlease enter a letter and I will tell you whether it's a vowel or not: ");
            string letter = Console.ReadLine().ToLower();

            if (letter == "a" || letter == "e" || letter == "i" || letter == "u" || letter == "o")
            {
                Console.WriteLine($"{letter} is a vowel.\nPlease press enter to exit.");
            }
            else
            {
                Console.WriteLine($"{letter} is a consonant.\nPlease press enter to exit.");
            }
            Console.ReadLine();
        }
    }
}
