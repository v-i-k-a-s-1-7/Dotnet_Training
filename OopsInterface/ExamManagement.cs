namespace OopsInterface
{
    public abstract class Employee
    {
        public int Emp_Id { get; set; }
        public string Name { get; set; }

    }

    public abstract class Department : Employee
    {
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
    }

    public abstract class Role : Department
    {
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
    }

    public interface IExamManagement
    {
       
    }


}
