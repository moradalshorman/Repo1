using System;
using System.Collections.Generic;
using System.Text;

namespace Codez__project.projectOOP
{
    public abstract  class Employee 
    {

        public Employee(string name,int employeeID,double baleSalary) 
        {
            Name = name;
            EmployeeID = employeeID;
            BaseSalary = baleSalary;
        }
        private double baseSalary;

        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public double BaseSalary 
        { 
            get => baseSalary; 
            set 
            {
                if (value > 0)
                {
                    baseSalary = value;
                } 
                else
                {
                    Console.WriteLine("Rejict Negative Value ");
                }

            }
        }


        public abstract double ClaculationMonthlySalary();

        public virtual void final()
        {
            Console.WriteLine($"The Employee Name is : {Name}");
            Console.WriteLine($"The Employee ID is : {EmployeeID}");
            Console.WriteLine($"The Base Salary is : {BaseSalary}");
            Console.WriteLine($"-----------------------------------------\n\n");

        }


    }
}
