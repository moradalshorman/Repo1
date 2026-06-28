using System;
using System.Collections.Generic;
using System.Text;

namespace Codez__project.projectOOP
{
    public  class Developer : Employee, IBounsEligible
    {
        public Developer(string name, int employeeID, double baleSalary) : base(name, employeeID, baleSalary)
        {


        }

        public string ProgramLanguage { get; set; }
        public override double ClaculationMonthlySalary()
        {
            return BaseSalary;
        }
        public double CalculateBonus()
        {
            return 0.05 * BaseSalary;
        }
        
        public override void final()
        {
            Console.WriteLine($"The Employee Name is : {Name}");
            Console.WriteLine($"The Employee ID is : {EmployeeID}");
            Console.WriteLine($"The Monthly Salary is : {ClaculationMonthlySalary()}");
            Console.WriteLine($"The Bonus is : {CalculateBonus()}");
            Console.WriteLine($"-----------------------------------------\n\n");

        }

    }
}
