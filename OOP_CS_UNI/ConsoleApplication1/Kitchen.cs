namespace ConsoleApplication1
{
    public class Kitchen : Room
    {
        public Kitchen(double area, string color) : base(area, color)
        {
            
        }

        public override string ToString()
        {
            return $"This is a kitchen!" + base.ToString();
        }
    }
}