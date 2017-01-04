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

            Console.WriteLine("Hello, World!");
            

            int integer1 = 10;
            bool boolean1 = true;
            double double1 = 1.0;
            char character1 = 'k';
            string string1 = "Hello";
            Console.WriteLine("");
            Console.WriteLine("integer1 = " + integer1);
            Console.WriteLine("boolean1 = " + boolean1);
            Console.WriteLine("double1 = " + double1);
            Console.WriteLine("character1 = " + character1);
            Console.WriteLine("string1 = " + string1);
            Console.WriteLine("");

            int winningNumber = 2;
             

            Console.WriteLine("Please enter a number 1-3 to find out if you have won!");
            string userNumber = Console.ReadLine();

            int userInt;
            int.TryParse(userNumber, out userInt);

            if (userInt == 2)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You Lost!");
        
            }
            Console.Read();
        }
    }
}
