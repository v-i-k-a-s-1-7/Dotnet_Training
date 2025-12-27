using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSchedule.Model
{
    public class StudentAndSession
    {
        public StudentAndSession() { }
        public string? Id { get; set; }
        public List<Student> Students { get; set; }

    }
}
