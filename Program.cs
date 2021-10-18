using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runApp = true;

            List<string> previousCalculation = new List<string>();
            
            Console.WriteLine("Calculator");
            
            while (runApp)
            {

                /*
                Console.WriteLine("Please enter your name.");
                string name = Console.ReadLine();
                */
                Console.WriteLine("Please enter the first number.");
                double num1 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Please enter the second number.");
                double num2 = Convert.ToDouble(Console.ReadLine());
                                
                Console.WriteLine("Choose which operation you want to do"); // {0}.", name);
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");                
                int choice = Convert.ToInt32(Console.ReadLine());

                double result = SelectOperation(num1, num2, choice);
                previousCalculation.Add(SaveCalculations(num1, num2, result, choice));
                
                /*
                 
                if (choice == 1)
                {
                    Console.WriteLine("Your result: {0} + {1} = {2}", num1, num2, result);
                    string addToList = string.Format("{0} + {1} = {2}", num1, num2, result);
                    previousCalculation.Add(addToList);
                    
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Your result: {0} - {1} = {2}", num1, num2, result);
                    string addToList = string.Format("{0} - {1} = {2}", num1, num2, result);
                    previousCalculation.Add(addToList);
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Your result: {0} * {1} = {2}", num1, num2, result);
                    string addToList = string.Format("{0} * {1} = {2}", num1, num2, result);
                    previousCalculation.Add(addToList);
                }

                else if (choice == 4)
                {
                    Console.WriteLine("Your result: {0} / {1} = {2}", num1, num2, result);
                    string addToList = string.Format("{0} / {1} = {2}", num1, num2, result);
                    previousCalculation.Add(addToList);
                }
                
                 */
                
                                
                Console.WriteLine("1. Do more calculations.");
                Console.WriteLine("2. See your previous caclulations.");
                Console.WriteLine("3. Close Calculator");
                int stopChoice = Convert.ToInt32(Console.ReadLine());
                                

                if (stopChoice == 2)
                {
                    foreach (string lastCalculation in previousCalculation)
                    {
                        Console.WriteLine("Previous Operation: {0}", lastCalculation);
                    }
                }

                else if (stopChoice == 3)
                {
                    runApp = false;
                }
            }

            double SelectOperation(double num1, double num2, int choice)
            {
                double result = 0;

                if (choice == 1)
                {
                    result = num1 + num2;
                }

                else if (choice == 2)
                {
                    result = num1 - num2;
                }

                else if (choice == 3)
                {
                    result = num1 * num2;
                }

                else if (choice == 4)
                {
                    result = num1 / num2;
                }
                return result;
            }

            string SaveCalculations(double num1, double num2, double result, int choice)
            {
                string addToList = "";

                if (choice == 1)
                {
                    addToList = string.Format("{0} + {1} = {2}", num1, num2, result);
                }

                else if (choice == 2)
                {                    
                    addToList = string.Format("{0} - {1} = {2}", num1, num2, result);                    
                }

                else if (choice == 3)
                {                    
                    addToList = string.Format("{0} * {1} = {2}", num1, num2, result);                    
                }

                else if (choice == 4)
                {                    
                    addToList = string.Format("{0} / {1} = {2}", num1, num2, result);                    
                }

                return addToList; 
            }

            void PrintCalculations()
            {

            }
        }
    }
}
