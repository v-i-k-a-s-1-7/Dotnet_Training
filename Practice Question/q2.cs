public class Question2{

    /// give three arguments to use this function  
    /// it's three numbers
    public static int Largest(int a, int b, int c){

        if ( a>b){
            if ( a> c){
                return a;
            }
            else{
                return c;
            }
        }
        else{
            if (b > c){
                return b;
            }else{
                return c;
            }
        }
    }

    // public static void Main(string[] args){

    //     int a = int.Parse(Console.ReadLine());
    //     int b = int.Parse(Console.ReadLine());
    //     int c = int.Parse(Console.ReadLine());

    //     Console.WriteLine("The Largest Number is " + Largest(a,b,c));

    // }
}