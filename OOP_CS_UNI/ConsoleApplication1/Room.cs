namespace ConsoleApplication1
{
    public abstract class Room
    {
        public double area { get; set; }
        public string Color { get; set; }

        
        public Room(double area, string color)
        {
            this.area = area;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"Area: {area} Color: {Color}";
        }
    }
}