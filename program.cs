using System;

namespace CalculatorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;

            while (true)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Enter A");
                Console.WriteLine("2. Enter B");
                Console.WriteLine("3. Operation '+'");
                Console.WriteLine("4. Operation '-'");
                Console.WriteLine("5. Operation '*'");
                Console.WriteLine("6. Operation '/'");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                         // feature A
                        Console.Write("Enter A: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Enter B: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine($"Result: {a + b}");
                        break;
                    case "4":
                        Console.WriteLine($"Result: {a - b}");
                        break;
                    case "5":
                        Console.WriteLine($"Result: {a * b}");
                        break;
                    case "6":
                        if (b != 0) Console.WriteLine($"Result: {a / b}");
                        else Console.WriteLine("Error: Division by zero");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}