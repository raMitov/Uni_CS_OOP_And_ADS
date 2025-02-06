namespace ConsoleApplication1
{
    public abstract class Building
    {
        public virtual double Area { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public Building( double height, string color)
        {
            this.Height = height;
            this.Color = color;
        }
    }
}