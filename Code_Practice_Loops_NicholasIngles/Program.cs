using System;
using System.Numerics;

public partial class Program
{
    public static void Main()
    {
        Console.WriteLine("+2 -5\n");
        int number = 20;
        Random rand = new Random();
        int count = 0;
        Console.WriteLine(number);
        while (number > 0 && number < 50)
        {
            int variable = rand.Next(0, 10);
            count++;
            if (variable == 2 || variable == 4 || variable == 6 || variable == 8)
            {
                number -= 5;
            }
            else
            {
                number += 2;
            }
            Console.WriteLine("Count: " + count + " Random: " + variable + " Current: " + number);
        }
        Console.WriteLine("\nFizz Buzz\n");
        try
        {
            int integer = 0;
            while (integer <= 0)
            {
                Console.Write("Give a positive integer: ");
                integer = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= integer; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        catch
        {
            Console.WriteLine("\nError occurred");
        }
        Console.WriteLine("\nFactorial\n");
        try
        {
            int factorial = 0;
            while (factorial <= 0)
            {
                Console.Write("Give a positive integer: ");
                factorial = int.Parse(Console.ReadLine());
            }
            for (int i = factorial - 1; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("Result: " + factorial);
        }
        catch
        {
            Console.WriteLine("\nError occurred");
        }
    }
}