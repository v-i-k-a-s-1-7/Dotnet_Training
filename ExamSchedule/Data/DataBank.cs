using ExamSchedule.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSchedule.Data
{
    public class DataBank
    {
        public DataBank() { }

        /// <summary>
        /// Retrieves a list of students with their identifiers and names.
        /// </summary>
        /// <returns>A list of <see cref="Student"/> objects, each containing the identifier and name of a student. The list will
        /// contain all available students; the list is empty if no students are available.</returns>
        public static List<Student> GetStudentDetails() => new List<Student>
            {
                new Student(1, "Vikas"),
                new Student(2, "Amit"),
                new Student(3, "Sonal"),
                new Student(4, "Rohit")

            };

        /// <summary>
        /// Retrieves a list of available student session details.
        /// </summary>
        /// <returns>A list of <see cref="StudentSession"/> objects representing the available student sessions. The list will be
        /// empty if no sessions are available.</returns>
        public static List<StudentSession> GetStudentSessionDetails() => new List<StudentSession>
            {
                new StudentSession{ Id="2024CSES1"},
                new StudentSession{ Id="2022CSES1"},
                new StudentSession{ Id="2022CSES2"},
                new StudentSession{ Id="2024CSES3"}
            };

        public static List<StudentAndSession> GetStudentAndSessionDetails() => new List<StudentAndSession>
            {
                new StudentAndSession
                {
                    Id="2024CSES1",
                    Students=new List<Student>
                    {
                        new Student(1, "Vikas"),
                        new Student(2, "Amit")
                    }
                },
                new StudentAndSession
                {
                    Id="2022CSES1",
                    Students=new List<Student>
                    {
                        new Student(3, "Sonal"),
                        new Student(4, "Rohit")
                    }
                }
            };
    }
}
