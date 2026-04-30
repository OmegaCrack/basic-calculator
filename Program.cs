using System;
 
class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number  : ");
        double a = double.Parse(Console.ReadLine() ?? "0");
 
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine() ?? "+";
 
        Console.Write("Enter second number : ");
        double b = double.Parse(Console.ReadLine() ?? "0");
 
        double result = op == "+" ? a + b
                      : op == "-" ? a - b
                      : op == "*" ? a * b
                                  : a / b;
 
        Console.WriteLine($"{a} {op} {b} = {result}");
    }
}