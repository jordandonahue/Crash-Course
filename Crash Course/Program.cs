using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //give the user directions(1-5)
            Console.WriteLine("Pick a number (1-5)");
            //set the winning numbers
            const int winningNumber1 = 3;
            const int winningNumber2 = 5;
            //get data from the user
            string userData = Console.ReadLine();
            //convert it to int
            int userValue;
            int.TryParse(userData, out userValue);
            //do they match?
            switch(userValue)
            {
                case winningNumber1:
                    Console.WriteLine("You win!");
                    break;
                case winningNumber2:
                    Console.WriteLine("You kinda win!");
                    break;
                default:
                    Console.WriteLine("You definitely lose!");
                    break;

            }


            Console.Read();
        }
    }
}
