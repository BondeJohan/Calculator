namespace Calculator
{
    public class Calculator
    {
        public static double SelectOperation(double num1, double num2, int choice)
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
                result  = num1 * num2;
            }

            else if (choice == 4)
            {
                result = num1 / num2;                
            }
            return result;
        }
    }
}
