class Student{

    private int StudentID{get; }
    private string StudentName{get; }
    private string StudentProgram{get; set; }
    
    public Student(int studentID, string studentName, string studentProgram){
        StudentID = studentID;
        StudentName = studentName;
        StudentProgram = studentProgram;
    }
}
