using MathsLib;
using ScienceLib;

namespace MainCalcApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Algebra math = new Algebra();

            int res = math.add(2, 3);

            Console.WriteLine(res);

            SciLogin sci = new SciLogin();

            sci.Login();
        }
    }
}
