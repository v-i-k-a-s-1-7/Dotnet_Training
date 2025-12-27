// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // 
using static Question1;
using static Question2;
using static Question3;
using static Question5;
using static Question6;


public class Entry{

     public static void Main(string[] args){

        // taking input and parsing it to int

        #region question 1
        // int height = int.Parse(Console.ReadLine());

        // Console.WriteLine("According to your height you are " + Height_Feed(height));
        #endregion

        #region question 2
        // int a = (int.TryParse(Console.ReadLine(), out a) ? a : 0);
        // int b = (int.TryParse(Console.ReadLine(), out b) ? b : 0);
        // int c = (int.TryParse(Console.ReadLine(), out c) ? c : 0);

        // Console.WriteLine("The Largest Number is " + Largest(a,b,c));
        #endregion
        
        #region question 3
        // int year = (int.TryParse(Console.ReadLine(), out year)) ? year : 0;

        // Console.WriteLine("Year " + year + " is " + (IsLeapYear(year) ? "Leap Year" : "Not a Leap Year") );
       #endregion

       #region question 5
        // Input Marks 
      //   Console.WriteLine("Enter Maths Marks: ");
      //   int Mmarks = (int.TryParse(Console.ReadLine(), out Mmarks) ? Mmarks : 0);
        
      //   Console.WriteLine("Enter Physics Marks: ");
      //   int Pmarks = (int.TryParse(Console.ReadLine(), out Pmarks) ? Pmarks : 0);
        
      //   Console.WriteLine("Enter Chemistry Marks: ");
      //   int Cmarks = (int.TryParse(Console.ReadLine(), out Cmarks) ? Cmarks : 0);

      //   Console.WriteLine((IsEligible(Mmarks,Pmarks,Cmarks))? "Yes They are Eligible" : "NO, they are not eligible");
       #endregion

       #region question 6

       // Input Units 
      Console.WriteLine("Enter your bill units");
      int units = (int.TryParse(Console.ReadLine(), out units) ? units : 0);
      double bill = Math.Round(CalculateBill(units), 2);
      Console.WriteLine($"Your Bill is   {bill} ");

      #endregion  
    }

}