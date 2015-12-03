using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fibonacci_Sequence
{
    class Program
    {

       static string userInput = "";

        static void Main(string[] args)
        {

            Console.WriteLine("Choose a number to run program. \n\n\n  1. Fibonacci Sequence \n\n\n type 'exit' to close application \n ");

            while (userInput.ToUpper() != "EXIT")
            {
              userInput =  Console.ReadLine();

                if (userInput == "1")
                {
                    runFibonacci();

                }
            }
        }

        static void runFibonacci()
        {
            // Fibonacci Sequence -Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.

            int numberEntered;
            string fibonacciNumberEntered = "";

            Console.WriteLine("Enter a number to show a Fibonacci sequence to that Nth number \n\n");

            while (userInput.ToUpper() != "EXIT")
            {
                userInput = Console.ReadLine();

                try
                {
                    numberEntered = int.Parse(userInput);

                    int[] fibSequenceArray = new int[numberEntered];

                    for (int i = 0; i < fibSequenceArray.Length; i++)
                    {
                        if (i == 0)
                        {
                            fibSequenceArray[0] = 0;
                        }
                        if (i == 1)
                        {
                            fibSequenceArray[1] = 1;
                        }
                        if (i >= 2)
                        {
                            fibSequenceArray[i] = (fibSequenceArray[i - 1] + fibSequenceArray[i - 2]);
                        }
                    }


                    Console.WriteLine("\nYour Sequence:\n\n");

                    for (int j = 0; j < fibSequenceArray.Length; j++)
                    {
                        Console.Write(fibSequenceArray[j].ToString() + ' ');
                    }
                    Console.WriteLine("\n");
                }
                catch
                {
                    if (userInput.ToUpper() == "EXIT")
                    {
                        Environment.Exit(0);
                    }

                    Console.WriteLine("\nThat's not a valid number dummy, try again\n");
                }


                

            }

        }


    }
}
