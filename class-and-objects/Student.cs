public class Student{

    #region Declaration
    int Student roll;
    int Student stream;
    int Student age;
    string Student name;
    #endregion

    #region Constructor
    
    #endregion

    #region Member Function
    public void setStudentDetails(int r, int s, int a, string n){
        roll = r;
        stream = s;
        age = a;
        name = n;
    }

    public void getStudentDetails(){
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Roll: " + roll);
        Console.WriteLine("Student Stream: " + stream);
        Console.WriteLine("Student Age: " + age);
    }
    #endregion

    
}