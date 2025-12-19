Using Calc;


public class Program{

    public static void Main(string[] args){

        //constructor
        Calc calc = new Calc();

         // printing and function calling
        Console.WriteLine("Is 4 even?" + calc.IsEven(4));
        Console.WriteLine("Is 7 even?" + calc.IsEven(7));
    }
}