namespace Employee.cs
{

    /// <summary>
    /// Represents an employee with a unique identifier and salary information. Serves as a base class for specific
    /// types of employees.
    /// </summary>
    /// <remarks>Inherit from this class to implement employee-specific behavior, such as tax calculation.
    /// This class cannot be instantiated directly.</remarks>
    public abstract class Employee
    {

        public int EmpId;
        public double Salary;
        public abstract double CalculateTax();
        
    }
    
    /// <summary>
    /// Represents an employee whose tax calculation follows Indian tax regulations.
    /// </summary>
    public class Indian : Employee
    {
        public override double CalculateTax()
        {
            return Salary * 0.30;
        }
    }


    /// <summary>
    /// Represents an employee located in the United States with tax calculation logic specific to U.S. tax rates.
    /// </summary>
    public class US : Employee
    {
        public override double CalculateTax()
        {
            return Salary * 0.40;
        }
    }



}
