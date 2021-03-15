using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Calculate
    {             
        public void GetAnswer()
        {
            string answer;
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!\n");
            do
            { 
                Console.WriteLine("Enter Length:");
                decimal.TryParse(Console.ReadLine(), out decimal length);

                Console.WriteLine("Enter Length:");
                decimal.TryParse(Console.ReadLine(), out decimal width);

                Calculate calculate = new Calculate();

                Console.WriteLine($"Area:{calculate.CalculateArea(length, width)}");
                Console.WriteLine($"Perimeter:{calculate.CalculatePerimeter(length, width)}\n");

                Console.WriteLine("Continue? (y/n)");
                answer = Console.ReadLine();

            } while (answer == "y");

            if (answer == "n")
            {
                Console.WriteLine("Thank you! Have a good day!");
            }
        }
        public decimal CalculatePerimeter(decimal length, decimal width)
        {            
            return 2 * (length + width);
        }
        public decimal CalculateArea(decimal width, decimal length)
        {

            return length * width;
        }        
    }
}
