using System.Security.Cryptography;

namespace OOP_CS_UNI
{
    public class Discipline
    {
        protected string name { get; private set; }
        protected int numLectures { get; private set; }
        protected int numExercises { get; private set; }
        

        public Discipline(string name, int numLectures, int numExercises)
        {
            name = name;
            numLectures = numLectures;
            numExercises = numExercises;
        }

        public override string ToString()
        {
            return $"{name}: {numLectures} lectures -{numExercises} exercises";
        }
    }
}