using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* */
            Console.WriteLine("Simple Calculator!");
            Console.Write("Please enter a number: ");
            string userValue = Console.ReadLine();
            double value;
            if (double.TryParse(userValue, out value))
            {
                Console.WriteLine("You entered {0}! Enter +, -, x or /. This is to add, subtract, multiply or divide, respectively: ", userValue);
                Operations();
            }
            else
            {
                string message = "Hm, I don't understand. Enter a number: ";
                Console.WriteLine(message);
            }
        }
        /* invokes the add, multiply, subtract, divide operations*/
        private static void Operations()
        {
            string userValue = Console.ReadLine();

            if (userValue == "+")
            {
                Addition();
            }
            if (userValue == "-")
            {
                Subtraction();
            }
            if (userValue == "x")
            {
                Multiplication();
            }
            if (userValue == "/")
            {
                Division();
            }
        }
        /*userValue1 adds to userValue2*/
        private static void Addition()
        {
            string userValue = Console.ReadLine();
        }
        private static void Subtraction()
        {
            string userValue = Console.ReadLine();
        }
        private static void Multiplication()
        {
            string userValue = Console.ReadLine();
        }
        private static void Division()
        {
            string userValue = Console.ReadLine();
        }

        /* Perhaps append each value to separate arrays? How to continously loop until userValue double is met? */


    }
}
