using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare global variables.
            bool runApp = true;
            string name;
            double num1;
            double num2;

            // List to save calculations.
            List<string> previousCalculation = new List<string>();
            
            // Write Calculator and ask user for a name input.
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
                string enterName = Console.ReadLine();
                return enterName;
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
            void SelectOperation(double selectNum1, double selectNum2, string selectName)
            {                                
                Console.WriteLine("Choose which operation you want to do {0}.", selectName);
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                int selectChoice = Convert.ToInt32(Console.ReadLine());
                double selectResult;

                switch (selectChoice)
                {
                    case 1:
                        selectResult = selectNum1 + selectNum2;
                        Console.WriteLine("Your result: {0} + {1} = {2}", selectNum1, selectNum2, selectResult);
                        previousCalculation.Add(string.Format("{0} + {1} = {2}", selectNum1, selectNum2, selectResult));
                        break;
                    case 2:
                        selectResult = selectNum1 - selectNum2;
                        Console.WriteLine("Your result: {0} + {1} = {2}", selectNum1, selectNum2, selectResult);
                        previousCalculation.Add(string.Format("{0} - {1} = {2}", selectNum1, selectNum2, selectResult));
                        break;

                    case 3:
                        selectResult = selectNum1 * selectNum2;
                        Console.WriteLine("Your result: {0} + {1} = {2}", selectNum1, selectNum2, selectResult);
                        previousCalculation.Add(string.Format("{0} * {1} = {2}", selectNum1, selectNum2, selectResult));
                        break;
                    case 4:
                        selectResult = selectNum1 + selectNum2;
                        Console.WriteLine("Your result: {0} / {1} = {2}", selectNum1, selectNum2, selectResult);
                        previousCalculation.Add(string.Format("{0} / {1} = {2}", selectNum1, selectNum2, selectResult));
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        SelectOperation(selectNum1, selectNum2, selectName);
                        break;



                }
            }

            // Asks the user if they want to continue to do more calculations, see their prevoius calculations or end the session.
            void ContinueSeePreviousOrStop(string continueStopName)
            {
                Console.WriteLine("1. Do more calculations.");
                Console.WriteLine("2. See your previous calculations.");
                Console.WriteLine("3. Close Calculator");
                int stopChoice = Convert.ToInt32(Console.ReadLine());

                switch (stopChoice)
                {
                    case 1:
                        Console.WriteLine("Starting new calculation {0}.", continueStopName);
                        break;
                    case 2:
                        Console.WriteLine("Your previous calculations {0}.", continueStopName);
                        PrintSavedCalculations();
                        ContinueSeePreviousOrStop(continueStopName);
                        break;
                    case 3:
                        runApp = StopApp(continueStopName);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        ContinueSeePreviousOrStop(continueStopName);
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
            bool StopApp(string stopName)
            {
                bool stopApp = false;

                Console.WriteLine("Goodbye {0}", stopName);
                return stopApp;
            }
        }
    }
}
