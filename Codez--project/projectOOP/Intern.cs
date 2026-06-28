using System;
using System.Collections.Generic;
using System.Text;

namespace Codez__project.projectOOP
{
    public class Intern : Employee
    {
        public Intern(string name, int employeeID, double baleSalary) : base(name, employeeID, baleSalary)
        {

        }

        public override double ClaculationMonthlySalary()
        {
            return BaseSalary * 0.5;        
        }
        public override void final()
        {
            Console.WriteLine($"The Employee Name is : {Name}");
            Console.WriteLine($"The Employee ID is : {EmployeeID}");
            Console.WriteLine($"The Monthly Salary is : {ClaculationMonthlySalary()}");
            Console.WriteLine($"-----------------------------------------\n\n");

        }
    }
}
