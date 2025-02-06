using System.Collections.Generic;
using System.Linq;
namespace ConsoleApplication1
{
    public class House : Building
    {
        public override double Area
        {
            get
            {
                return calcArea();

            }
        }

        private double calcArea()
        {
            double sum = 0;
            foreach (var rooom in Rooms)
            {
                sum += rooom.area;
            }
            return sum;
        }
        public List<Room> Rooms{get;set;}
        public Person Owner{get;set;}
        public House( double height ,string color, Person person) : base( height, color)
        {
            
            this.Owner = person;
            this.Rooms = new List<Room>();
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Rooms.Count; i++)
            {
                result += Rooms[i].ToString();
            }
            result += $"House owner: {Owner}";
            return result;
        }
    }
}