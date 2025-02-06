namespace OOP_LEC2_THIRDAPP
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, decimal baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
        }

        public virtual decimal GetTotaSalary()
        {
            return this.BaseSalary;
        }

        public override string ToString()
        {
            return $"Name of employee is {this.Name}, Salary is {this.BaseSalary}";
        }
    }
}