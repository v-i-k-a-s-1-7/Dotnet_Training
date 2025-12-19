// See https://aka.ms/new-console-template for more information
using System;

class addTwo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Prime Number");
        int num = Console.Read();
        int count = 0;

        for (int i = 3; i < num; i = i + 2) {
                count++;
            }
        }
        Console.WriteLine(count);


        if (count == 2) {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("NOT Prime");
        }
    }
}