using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PiToNthConsole
{
    class Program
    {
        // objective: find PI to the Nth Digit - Enter a number and have the program generate PI 
        // up to that many decimal places. Keep a limit to how far the program will go. 

        const double piNum = System.Math.PI;
        static string inputResult = "";
        static int decimalLength = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Greetings traveler.\n\nEnter a number to generate a PI number with that many decimal places.\n");
            Console.WriteLine("Type derp to exit.\n");

           while (inputResult != "derp")
           {
             inputResult = Console.ReadLine();

             if (checkValidInput())
             {

                 //the following can only handle 15 decimal places
                // Console.WriteLine("\nBehold! Your Pi!\n");
                //   Console.WriteLine(Math.Round(piNum, decimalLength));

                 
                 //the following is a custom class that can handle any size decimal 
                 BigNumber x = new BigNumber(decimalLength);
                 BigNumber y = new BigNumber(decimalLength);
                 x.ArcTan(16, 5);
                 y.ArcTan(4, 239);
                 x.Subtract(y);
                 Console.WriteLine(x.Print());
             }
           }

           Environment.Exit(0);
        }

        protected static void showNonValidMessage()
        {
            Console.WriteLine("\nit looks like you didn't enter a valid number.\n\n 'Round these parts, we read and follow instructions.\n\nTryAgain\n");
        }

        protected static bool checkValidInput()
        {
            bool returnVal = false;

            try
            {
                decimalLength = int.Parse(inputResult);
                returnVal = true;
            }
            catch
            {
                //user didn't enter a valid number
                showNonValidMessage();
            }

            return returnVal;
            
        }

    }
}
