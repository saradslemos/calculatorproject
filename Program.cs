﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;

        int result;

        string answer;

        Console.WriteLine("Hello, welcome to the calculator program!");
        Console.WriteLine("Please enter your first number.");

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your second number.");

        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What type of operation would you like to do?");
        Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or any key for division.");

        answer = Console.ReadLine();

        if (answer == "a")
        {
            result = num1 + num2;
        }

        else if (answer == "s")
        {
            result = num1 - num2;
        }

        else if (answer == "m")
        {
            result = num1 * num2;
        }

        else
        {
            result = num1 / num2;
        }

        Console.WriteLine("The result is " + result);
        Console.WriteLine("Thank you for using the calculator program!");

        Console.Read();
    }
}