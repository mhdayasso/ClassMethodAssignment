using System;

namespace ClassMethodAssignment
{
    // This class contains the method required for the assignment
    class MathOperation
    {
        // This void method takes two integers as parameters
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber + 10;

            // Display the result of the math operation
            Console.WriteLine("Result of the math operation on the first number: " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second number: " + secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathObject = new MathOperation();

            // Call the method by passing in two numbers
            mathObject.DoMath(5, 12);

            // Call the method again by specifying the parameters by name
            mathObject.DoMath(firstNumber: 8, secondNumber: 20);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}