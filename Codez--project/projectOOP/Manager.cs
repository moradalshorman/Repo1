using System;
using System.Collections.Generic;
using System.Text;

namespace Codez__project.projectOOP
{
    public class Manager : Employee, IBounsEligible
    {
        public Manager(string name, int employeeID, double baleSalary , int teamSize) : base(name, employeeID, baleSalary)
        {
            TeamSize = teamSize;
        }

        public int TeamSize { get; set; }

        

        public override double ClaculationMonthlySalary()
        {
            double Monthly = BaseSalary + (TeamSize * 100);
            return Monthly;
        }
        public override void final()
        {
            Console.WriteLine($"The Employee Name is : {Name}");
            Console.WriteLine($"The Employee ID is : {EmployeeID}");
            Console.WriteLine($"The Monthly Salary is : {ClaculationMonthlySalary()}");
            Console.WriteLine($"The Bonus is : {CalculateBonus()}");
            Console.WriteLine($"-----------------------------------------\n\n");

        }

        public double CalculateBonus()
        {
            return BaseSalary * 0.1 + (50 * TeamSize);
        }

    }
}
