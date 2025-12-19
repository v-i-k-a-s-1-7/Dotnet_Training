// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // 
using static Question1;
using static Question2;
using static Question3;

public class Entry{

     public static void Main(string[] args){

        // taking input and parsing it to int

        #region question 1
        // int height = int.Parse(Console.ReadLine());

        // Console.WriteLine("According to your height you are " + Height_Feed(height));
        #endregion

        #region question 2
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());
        // int c = int.Parse(Console.ReadLine());

        // Console.WriteLine("The Largest Number is " + Largest(a,b,c));
        #endregion
        
        #region question3
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Year " + year + " is " + (IsLeapYear(year) ? "Leap Year" : "Not a Leap Year") );
       #endregion
        
    }

}