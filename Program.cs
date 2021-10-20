using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runApp = true;
            string name;
            double num1;
            double num2;

            // List to save calculations.
            List<string> previousCalculation = new List<string>();
            
            Console.WriteLine("Calculator");
            name = EnterName();
            
            // While loop
            while (runApp)
            {
                num1 = EnterNumber();
                num2 = EnterNumber();
                SelectOperation(num1, num2, name);
                ContinueSeePreviousOrStop(name);
            }
            
            // Asks the user for thier name.
            string EnterName()
            {
                Console.WriteLine("Enter your name.");
                string name = Console.ReadLine();
                return name;
            }
            
            // Asks the user for a number.
            double EnterNumber()
            {
                Console.WriteLine("Enter a number.");
                double num = Convert.ToDouble(Console.ReadLine());
                return num;
            }           
 
            // Asks the user what kind of operation they want to use with the numbers they have enterd.
            // Calculates the result and prints it.
            // Converts the numbers to string to save it in the string list.          
            void SelectOperation(double num1, double num2, string name)
            {                                
                Console.WriteLine("Choose which operation you want to do {0}.", name);
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                int choice = Convert.ToInt32(Console.ReadLine());
                double result;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("Your result: {0} + {1} = {2}", num1, num2, result);
                        previousCalculation.Add(string.Format("{0} + {1} = {2}", num1, num2, result));
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("Your result: {0} + {1} = {2}", num1, num2, result);
                        previousCalculation.Add(string.Format("{0} - {1} = {2}", num1, num2, result));
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine("Your result: {0} + {1} = {2}", num1, num2, result);
                        previousCalculation.Add(string.Format("{0} * {1} = {2}", num1, num2, result));
                        break;
                    case 4:
                        result = num1 + num2;
                        Console.WriteLine("Your result: {0} / {1} = {2}", num1, num2, result);
                        previousCalculation.Add(string.Format("{0} / {1} = {2}", num1, num2, result));
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        SelectOperation(num1, num2, name);
                        break;



                }
            }

            // Asks the user if they want to continue to do more calculations, see their prevoius calculations or end the session.
            void ContinueSeePreviousOrStop(string name)
            {
                Console.WriteLine("1. Do more calculations.");
                Console.WriteLine("2. See your previous calculations.");
                Console.WriteLine("3. Close Calculator");
                int stopChoice = Convert.ToInt32(Console.ReadLine());

                switch (stopChoice)
                {
                    case 1:
                        Console.WriteLine("Starting new calculation {0}.", name);
                        break;
                    case 2:
                        Console.WriteLine("Your previous calculations {0}.", name);
                        PrintSavedCalculations();
                        ContinueSeePreviousOrStop(name);
                        break;
                    case 3:
                        StopApp(name);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        ContinueSeePreviousOrStop(name);
                        break;

                }
            }

            // Prints out the saved calculations saved in the list.
            void PrintSavedCalculations()
            {
                foreach (string lastCalculation in previousCalculation)
                {
                    Console.WriteLine("Previous Operation: {0}", lastCalculation);
                }
            }

            // Returns a false value to stop the program.
            bool StopApp(string name)
            {
                runApp = false;

                Console.WriteLine("Goodbye {0}", name);
                return runApp;
            }
        }
    }
}
