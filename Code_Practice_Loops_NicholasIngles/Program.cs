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

        }
        catch
        {
            Console.WriteLine("Error ocurred");
        }
    }
}