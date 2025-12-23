using OopsSession.Constructor ;

public class Program{

    public static void Main(string[] args){

        //Visitor visitor = new Visitor();
        //Visitor visitor1 = new Visitor(1);

        //Visitor visitor2 = new Visitor(2, "VIKAS");
        //Console.WriteLine(visitor1.LogHistory);
        //Associate associate = new Associate(-1, "John Doe", 5);

        //string x = Console.ReadLine();

        Account account = new Account(12345, "vikas");//{ 12345, "vikas" };
        account.GetAccountDetails();

        Console.WriteLine(

    }

}