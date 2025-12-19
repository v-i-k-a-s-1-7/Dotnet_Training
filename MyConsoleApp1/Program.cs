// See https://aka.ms/new-console-template for more information
using System;

class addTwo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Prime Number");
        int num = Console.ReadLine();
        int count = 0;

        for (int i = 3; i < num; i = i + 2) {
            if (num % i == 0) {
                count++;
            }
        }

        if (count > 2) {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("NOT Prime");
        }
    }
}