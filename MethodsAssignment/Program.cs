using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MyClass class
            MyClass myClass = new MyClass();

            // Call the method in the class, passing in two numbers
            myClass.DoMathOperation(5, 7);

            // Call the method in the class, specifying the parameters by name
            myClass.DoMathOperation(firstNumber: 10, secondNumber: 3);

            Console.ReadLine();
        }
    }

    class MyClass
    {
        // Void method that takes two integers as parameters
        public void DoMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber * 2;

            // Display the second integer to the screen
            Console.WriteLine("Second number: " + secondNumber);

        }
    }
}
