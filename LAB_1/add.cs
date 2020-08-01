using System;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers one by one new Line");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum is {0}",num1+num2);

        }
    }
}

