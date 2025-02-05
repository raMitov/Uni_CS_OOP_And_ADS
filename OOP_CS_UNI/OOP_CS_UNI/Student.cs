namespace OOP_CS_UNI
{
    public class Student : Person
    {
        protected int Id { get; private set; }

        public Student(string name, int id) : base(name)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"{Name} (ID: {Id})";
        }
        
    }
}