using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {

        static void Main(string[] args)
        {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Subtraction(300, 10));
        }
    }
public class Calculator
{
    public int Subtraction(int a, int b)
    {
        return a - b;
    }
}


