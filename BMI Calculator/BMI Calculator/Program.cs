using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("<<< Question 2 >>>\nThis app will calculate your BMI (Body Mass Index)\n Please enter your weight in Kg's: ");
            double kgs = double.Parse(Console.ReadLine());
            Console.Write("Now please enter your height in CM's: ");
            double cms = double.Parse(Console.ReadLine());

            double meters = cms / 100;
            double userBmi = kgs / (meters * meters);
            Console.WriteLine($"Your BMI is: {userBmi}\nPlease press ENTER to quit.....");
            Console.ReadLine();

        }
    }
}
