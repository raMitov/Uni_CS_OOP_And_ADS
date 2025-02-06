namespace ConsoleApplication1
{
    public class Bathroom : Room
    {
        public Bathroom(double area, string color) : base(area, color)
        {
            
        }

        public override string ToString()
        {
            return $"This is a bathroom!" + base.ToString();
        }
    }
}