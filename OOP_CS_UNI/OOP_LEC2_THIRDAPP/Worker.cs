namespace OOP_LEC2_THIRDAPP
{
    public class Worker : Employee
    {
        public int HoursWorked { get; private set; }
        public decimal HourlySalary { get; private set; }
        public Worker(string name, decimal baseSalary, decimal hourlySalary) : base(name, baseSalary)
        {
            HourlySalary = hourlySalary;
        }

        public void AddHours(int hourWorked)
        {
            HoursWorked += hourWorked;
        }
        public override decimal GetTotaSalary()
        {
            return (HoursWorked * HourlySalary) + base.GetTotaSalary();
        }
        
    }
}