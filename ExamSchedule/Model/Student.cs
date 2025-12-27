using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSchedule.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


    }
}
