﻿namespace BasicMathExpressionParser
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a basic math expression: ");
            string mathExpression = Console.ReadLine() ?? "";

            Console.WriteLine(mathExpression);
        }
    }
}