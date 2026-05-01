using System;

namespace Programme
{
    class Calculator
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("-----------------");
                Console.WriteLine("SIMPLE CALCULATOR");
                Console.WriteLine("-----------------");

                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your option: ");
                
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Your result: {0} + {1} = {2}", num1, num2, result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Your result: {0} - {1} = {2}", num1, num2, result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Your result: {0} * {1} = {2}", num1, num2, result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Your result: {0} / {1} = {2}", num1, num2, result);
                        break;

                    default: 
                        Console.WriteLine("That was not a valid option.");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = No): ");
            } while(Console.ReadLine().ToUpper() == "Y");
            
            Console.WriteLine("Bye");
            Console.ReadKey();
            
        }
    }
}