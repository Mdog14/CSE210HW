using System;
using System.Collections.Generic;  // <-- Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<double> numbers = new List<double>();

        double total = 0;       // Declare outside the loop
        double average = 0;
        double largest = 0;

        while (true)
        {
            Console.Write("Enter Number: ");
            double num = double.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            numbers.Add(num);
        }

        // Calculate sum
        foreach (double n in numbers)
            total += n;

        // Calculate average
        if (numbers.Count > 0)
        {
            average = total / numbers.Count;
        }

        // Calculate largest
        if (numbers.Count > 0)
        {
            largest = numbers[0];
            foreach (double n in numbers)
            {
                if (n > largest)
                {
                    largest = n;
                }
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // Smallest positive number (nullable double)
        double? smallestPositive = null;
        foreach (double n in numbers)
        {
            if (n > 0 && (smallestPositive == null || n < smallestPositive))
            {
                smallestPositive = n;
            }
        }

        // Sort list
        numbers.Sort();

        if (smallestPositive.HasValue)
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        else
            Console.WriteLine("No positive numbers were entered.");

        Console.WriteLine("The sorted list is: ");
        foreach (double n in numbers)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
