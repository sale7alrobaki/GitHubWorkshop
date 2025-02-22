
using System;

namespace newexample
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("examples in C#");
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(Subtract(10, 4));
            Console.WriteLine(Multiply(7, 6));
            Console.WriteLine(Divide(20, 4));
        }

        // first fun. add two numbers
        static int Add(int a, int b)
        {
            return a + b;
        }

        //subtract the second number from the first
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        //multiply two numbers
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        //divide the first number by the second
        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }


    }
}
