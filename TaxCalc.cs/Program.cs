using Employee;
using Employee.cs;

namespace TaxCalc.cs
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Indian emp = new Indian();

            emp.EmpId = 101;
            emp.Salary = 500000;

            double tax = emp.CalculateTax();

            Console.WriteLine($"Employee ID: {emp.EmpId}'s tax is amounted to {tax} ");
        }
    }
}
