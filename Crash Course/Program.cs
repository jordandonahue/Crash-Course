using System;
using System.Collections;
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
            for (int i = 1; i <= 100; i++)
            {

                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else{ Console.WriteLine(i);
                }
           }
            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }


            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");

            //    }
            //        Console.WriteLine(i);

            //    }
            //}
            
            
            
            
            
            //List<string> listOfStuff = new List<string>();
            //List<int> listOfNumbers = new List<int>();
            
            
            //ArrayList listOfStuff = new ArrayList();
            //listOfStuff.Add("Thing-0");
            //listOfStuff.Add("Thing-1");
            //listOfStuff.Add("Thing-2");
            //listOfStuff.Add("Thing-3");
            //listOfStuff.Add("Thing-4");

            //foreach (string thing in listOfStuff)
            //{
            //    Console.WriteLine(thing);
            //}


            //Console.WriteLine(listOfStuff.Count);

            //int destroyIndex = listOfStuff.IndexOf("Thing-1");
            //listOfStuff.RemoveAt(destroyIndex);

            //foreach (string thing in listOfStuff)
            //{
            //    Console.WriteLine(thing);
            //}

            //Console.WriteLine(listOfStuff.Count);

            //string[] arrayOfStuff = new string[5];
            //arrayOfStuff[0] = "Thing-0";
            //arrayOfStuff[1] = "Thing-1";
            //arrayOfStuff[2] = "Thing-2";
            //arrayOfStuff[3] = "Thing-3";
            //arrayOfStuff[4] = "Thing-4";

            //for (int i = 0; i < arrayOfStuff.Length; i++) 
            //{
            //    Console.WriteLine(arrayOfStuff[i]);
            //}


            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hello World!");

            //}

            //int counter = 5;
            //do
            //{
            //    Console.WriteLine("Hello World!");
            //    counter--;
            //}
            //while (counter > 5);

            /*while(counter > 0)
            {
                Console.WriteLine("Hello World!");
                counter--;
            }
            */

            Console.Read();
        }
    }
}
