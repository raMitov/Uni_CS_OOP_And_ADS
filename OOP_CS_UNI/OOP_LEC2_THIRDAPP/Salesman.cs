namespace OOP_LEC2_THIRDAPP
{
    public class Salesman : Employee
    {
        public decimal Commission { get; set; }
        public Salesman(string name, decimal baseSalary) : base(name, baseSalary)
        {
            Commission = Commission;
        }

        public override decimal GetTotaSalary()
        {
            return Commission + base.GetTotaSalary();
        }
    }
}