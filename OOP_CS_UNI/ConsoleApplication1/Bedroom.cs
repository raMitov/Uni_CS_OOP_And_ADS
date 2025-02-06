namespace ConsoleApplication1
{
    public class Bedroom : Room
    {
        public Bedroom(double area, string color) : base(area, color)
        {
            
        }

        public override string ToString()
        {
            return $"This is a bedroom!" + base.ToString();
        }
    }
}