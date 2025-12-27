/*Calculate bill: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; 
 * above 600 @ 2.00. Add 15% surcharge if bill > 400. */

using System;

public class Question6
{

    public static double CalculateBill(int units){
        
        double bill = 0; 
        if (units <= 199){
           bill = units * 1.20;
        }
        else if (units <= 400  ){
            bill = (199 * 1.20) + ((units - 199)* 1.50);
        }
        else if( units <= 600){
            bill = (199*1.20) + (201 *1.50) + ((units - 400)*1.80);
        }
        else{
            bill = (199 * 1.20) + (201 * 1.50) + (200 * 1.80) + ((units - 600)*2.0);
        }

        if ( bill > 400){
            bill = bill + bill * 0.15 ;
        }

        return bill;
    }
    //  public static void Main(string[] args){

    //     Console.WriteLine("Enter your bill units");
    //     int units = Console.ReadLines();
    //     Console.WriteLine("Your Bill is " + CalculateBill(units));
    //  }
}
