namespace OOP_Uni_Third
{
    public class Subject
    {
        public string name;
        

        public Subject(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}