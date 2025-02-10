namespace OOP_Uni_Third
{
    public class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string UniqueNumber { get; private set; }

        public Book(string name, string author, string uniqueNumber)
        {
            UniqueNumber = uniqueNumber;
            Name = name;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Name} - {Author} - {UniqueNumber}";
        }
    }
}