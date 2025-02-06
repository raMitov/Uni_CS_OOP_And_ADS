namespace OOP_LEC2_THIRDAPP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var company = new Company("company");
            var admin = new Administrator("Admin", 125.5m);
            var salesman = new Salesman("Salesman", 125.5m);
            var worker = new Worker("Worker", 125.5m, 12.4m);
            worker.AddHours(120);
        }
    }
}