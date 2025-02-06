using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person pesho = new Person("Pesho");
            Kitchen kitchen = new Kitchen(50.5, "yellow");
            Bathroom bathroom = new Bathroom(20, "yellow");
            Bedroom bedroom = new Bedroom(35, "yellow");
            Bedroom bedroom1 = new Bedroom(50, "darkyellow");
            House house = new House(5, "yellow", pesho);
            house.Rooms.Add(bedroom);
            house.Rooms.Add(bedroom1);
            house.Rooms.Add(bathroom);
            house.Rooms.Add(kitchen);
            Console.WriteLine(house.ToString());
        }
    }
}