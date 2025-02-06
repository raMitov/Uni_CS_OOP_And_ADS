using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_LEC2_THIRDAPP
{
    public class Company
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; private set; }

        public decimal SalaryCosts
        {
            get
            {
                return Employees.Sum(a => a.GetTotaSalary());
            }
        }

        public Company(string name)
        {
            Name = name;
        }

        public void HireEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (Employee employee in Employees)
            {
                result.AppendLine(employee.ToString());
            }
            return result.ToString();
        }
    }
}