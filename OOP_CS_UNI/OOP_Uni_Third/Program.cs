using System;

namespace OOP_Uni_Third
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("pesho", "12121241");
            Subject subject = new Subject("OOP2");     
            Subject subject2 = new Subject("OOP3");
            student.InsertGrade(subject, 4.39);
            student.InsertGrade(subject, 5.50);
            Console.WriteLine("Cunt of Subjects: " + student.GetCountOfSubjects());
            var allSubjects = student.GetSubjects();
            foreach (var item in allSubjects)
            {
                Console.WriteLine($"Subject: {item.Name}\n");
            }
            Console.WriteLine("Average Grade: " + student.GetAvgGrade());
            Console.WriteLine(student);
            
        }
        
    }
}