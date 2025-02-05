using System;
using OOP_CS_UNI;
using System.Collections.Generic;

namespace OOP_CS_UNI
{
    public class Classroom
    {
        protected int id;
        protected List <Student> students;
        protected List<Teacher> teachers;
        protected string comment;

        public Classroom(int id, List<Student> students, List<Teacher> teachers, string comment)
        {
            this.id = id;
            this.students = students;
            this.teachers = teachers;
            this.comment = comment;
        }

        void addStudent(Student student)
        {
            this.students.Add(student);
        }

        void addTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        void addComment(string comment)
        {
            this.comment = comment;
        }
        void showInfo() {
            Console.WriteLine("Classroom ID: " + this.id);
            Console.WriteLine("Students:");
            for (int i = 0; i < this.students.Count; i++)
            {
                Student.getName
            }
        }

    }
}