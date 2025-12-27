namespace OopsInterface
{
    public class Program : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Hello from IPrint interface default method.");
        }
        static void Main(string[] args)
        {
            IPrint printer = new Program();
            printer.Print();
        }
    }
}
