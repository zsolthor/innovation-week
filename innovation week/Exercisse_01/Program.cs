using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////Exercise 1//////////
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondtNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber + secondtNumber;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondtNumber, answer);

            //////////Exercise 2//////////
            const double per_square_foot = 5.50;

            Console.WriteLine("Enter the length of Your room:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of Your room:");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double price = area * per_square_foot;

            Console.WriteLine("The price to carpet Your {0} by {1} room (area: {3}) is {2:C2}", length, width, price, area);

            //////////Exercise 3//////////

            Console.WriteLine("Enter the total mount of time in minutes:");
            int totalTimeInMinutes = int.Parse(Console.ReadLine());

            int hours = totalTimeInMinutes / 60;
            int remainingMinutes = totalTimeInMinutes % 60;

            Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes", totalTimeInMinutes, hours, remainingMinutes);


        }
    }
}
