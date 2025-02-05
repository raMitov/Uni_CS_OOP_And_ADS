using System;
using System.Collections.Generic;

namespace OOP_CS_UNI
{
    public class Teacher : Person

    {
        
       protected List<Discipline> disciplines;

       public Teacher(string name) : base  (name)
       {
           disciplines = new List<Discipline>();
       }

       void AddDiscipline(Discipline discipline)
       {
           this.disciplines.Add(discipline);
       }

       public override string ToString()
       {
           string result = $"{Name} teaches:\n";
           foreach (var discipline in disciplines)
           {
               result += $"{discipline}\n";
           }
           return result;
       }
    }
}