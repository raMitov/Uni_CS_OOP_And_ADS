using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Uni_Third
{
    public class Specialty
    {
        public string Name { get; set; }
        public int CourseYear { get; private set; }
        public List<Subject> CommonSubjects { get; set; }
        public List<Subject> ElectiveSubjects { get; set; }
        public List<Student> Students { get; set; }

        public Specialty(string name, int courseYear, List<Subject> commonSubjects, List<Student> students)
        {
            this.Name = name;
            this.CourseYear = courseYear;
            this.CommonSubjects = commonSubjects ?? new List<Subject>();
            this.ElectiveSubjects = new List<Subject>();
            this.Students = students ?? new List<Student>();
        }

        public Student AddStudent(string name, string facultyNumber, List<Subject> electives)
        {
            Student student = new Student(name, facultyNumber);
            
            foreach (Subject subject in electives)
            {
                student.InsertGrade(subject, 0);
            }

            foreach (Subject subject in CommonSubjects)
            {
                student.InsertGrade(subject, 0);
            }
            
            this.Students.Add(student);
            return student;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Common Subjects:");
            foreach (Subject subject in CommonSubjects)
            {
                Console.WriteLine(subject.Name);
            }

            Console.WriteLine("Elective Subjects:");
            foreach (Subject subject in ElectiveSubjects)
            {
                Console.WriteLine(subject.Name);
            }
        }

        public List<Student> GetStudentsBySubject(Subject subject)
        {
            return Students.Where(student => student.Grades.ContainsKey(subject)).ToList();
        }

        public double GetAvgScore(Subject subject)
        {
            var validGrades = Students.Where(s => s.Grades.ContainsKey(subject) && s.Grades[subject] != 0)
                                      .Select(s => s.Grades[subject])
                                      .ToList();
            
            return validGrades.Count > 0 ? validGrades.Average() : 0;
        }

        public double GetAvgScore()
        {
            var validAverages = Students.Select(s => s.GetAvgGrade()).Where(avg => avg != 0).ToList();
            return validAverages.Count > 0 ? validAverages.Average() : 0;
        }

        public List<Student> BestStudents(int n)
        {
            return Students.OrderByDescending(s => s.GetAvgGrade())
                           .ThenBy(s => s.Name)
                           .Take(n)
                           .ToList();
        }

        public void PrintTopStudents(int n)
        {
            var topStudents = BestStudents(n);
            foreach (var student in topStudents)
            {
                Console.WriteLine($"Student: {student.Name}, Avg Score: {student.GetAvgGrade():0.00}");
            }
        }
    }
}

