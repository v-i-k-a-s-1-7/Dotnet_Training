// See https://aka.ms/new-console-template for more information

public class Calc{

    // Function for checking even numbers
    public static bool IsEven(int number){

        if(number % 2 == 0){
            return true;
        }else{
            return false;
        }
    }


    // EntryPoint
    public static void Main(string[] args){

        // constructor
        //Calc calc = new Calc();

        // we don't need  constructor you dumbo it's in same class

        // printing and function calling
        Console.WriteLine("Is 4 even?" + IsEven(4));
        Console.WriteLine("Is 7 even?" + IsEven(7));
    }
}