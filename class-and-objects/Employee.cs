public class Employee{

#region Declaration

    public int EmpId{get;}
    private string Name{get;}
    private int EmpAge{get; set;}
    private double EmpSalary{get;}
    #endregion

#region Constructor
public Employee(int EmpId, int EmpAge, int EmpSalary)
{
    EmpId = EmpId;
    EmpSalary = EmpSalary;
    EmpAge = EmpAge;
    
}
#endregion

#region getter
public void getEmployeeDetails(){
    Console.WriteLine("Employee ID: " + EmpId);
    Console.WriteLine("Employee Age: " + EmpAge);
    Console.WriteLine("Employee Salary: " + EmpSalary);
}
#endregion

}