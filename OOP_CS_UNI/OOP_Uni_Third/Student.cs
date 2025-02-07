using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Uni_Third
{
    public class Student
    {
        private string name;
 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
 
        private string facultyNumber;
 
        public Student(string name, string facultyNumber)
        {
            this.Grades = new Dictionary<Subject, double>();
            Name = name;
            FacultyNumber = facultyNumber;
        }
 
        public string FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }
 
        public Dictionary<Subject, double> Grades { get; private set; }
 
        public bool InsertGrade(Subject subject, double grade)
        { 
            if ( grade >6)
            {
                return false;
            }
            if (!this.Grades.ContainsKey(subject)) {
                this.Grades.Add(subject, grade);
                return true;
            }
            else
            {
                this.Grades[subject] = grade;
                return true;
            }
            return false;
        }
        public int GetCountOfSubjects()
        {
            return this.Grades.Count;
        }
        public List<Subject> GetSubjects()
        {
            return this.Grades.Keys.ToList();
        }
        public double GetGradeBySubject(Subject subject) {
            if (this.Grades.TryGetValue(subject, out double value))
            {
                return value;
            }
            throw new Exception("Student has not signed up for that subject!");
        }
        public double GetAvgGrade()
        {
            return this.Grades.Values.Average();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format(
                $"Name: {Name}, Faculty number: {FacultyNumber}"));
 
            foreach (Subject subject in Grades.Keys)
            {
                sb.Append("Subject: " + subject.Name);
                sb.Append("Grade: " + Grades[subject] + "\n");
            }
            return sb.ToString();
        }
    }
    
}