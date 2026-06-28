//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Codez__project
//{
//    internal class Dev : employee, IBonusEligible
//    {
//        public Dev(string Name, int id, double salary) : base(Name, id, salary)
//        {
//        }

//        public string ProgramLanguage { get; set; }
//        public override double CalculateMonthlySalary()
//        {
//            return BaseSalary;

//        }
//        public double  CalculateBonus()
//        {

//            return BaseSalary * 0.05;
//        }

//        public override void Final()
//        {
//            Console.WriteLine($"The name is {name}");

//            Console.WriteLine($"The ID is {EmployeeID}");
//            Console.WriteLine($"The name is {BaseSalary}");
         
//        }
//    }
//}
