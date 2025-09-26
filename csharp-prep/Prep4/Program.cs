using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = -1;
        List<int> numbers = new List<int>();

        while (num != 0)
        {
            Console.Write("Enter number: ");
            string numstr = Console.ReadLine();
            num = int.Parse(numstr);
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        double sum = 0;
        foreach (int nums in numbers)
        {
            sum += nums;
        }
        int bignum = 0;
        foreach (int nums in numbers)
        {
            if (nums > bignum)
            {
                bignum = nums;
            }
        }
        double avg = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {bignum}");
    }
}