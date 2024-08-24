using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            int length = 0;
            int width = 0;
            int area = 0;
            int perimeter = 0;
            //Prompts user for length variable and stores in memory
            Console.Write("Enter the length of the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            //Prompts user for width variable and stores in memory
            Console.Write("Enter the width of the rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            //Calculate area and perimeter with length/width variables stored in memory
            area = Convert.ToInt32(length * width);
            perimeter = Convert.ToInt32(2*(length) + 2*(width));
            //Provides space for code
            Console.WriteLine("");
            //Output results
            Console.WriteLine("Results:");
            Console.WriteLine($"Area of the rectangle: {area}");
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
            //Allows user to view program before exiting
            Console.Read();

        }
    }
}
