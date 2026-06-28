using Codez__project;
using Codez__project.projectOOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee manager = new Manager("morad ",45,250,6);
        Employee developer = new Developer("morad ", 45, 250);
        Employee intern = new Intern("morad ", 45, 250);
        double SumOfMonthlySalary =0;

        Employee[] empolyee = {manager, developer,intern};

        foreach (Employee emp in empolyee)
        {
            SumOfMonthlySalary += emp.ClaculationMonthlySalary();
            emp.final();
        }
        Console.WriteLine($"The Sum Of Monthly Salary is : {SumOfMonthlySalary}");
    }
}






























//----------------------------------------------------------------------

//employee obj1 = new Manager("morad",22,200,500);
//employee obj2 = new Dev("Ahmad", 33, 500);
//employee obj3 = new Intern("Saleh", 11, 700);

//employee[] employees =
//{
//    new Manager("Ahmed",101,5000,5),     new Dev("Ali",102,4000),   new Intern("Sara",103,2000)
//};

//double totalPayroll = 0;

//foreach (employee emp in employees)
//{
//    double salary = emp.CalculateMonthlySalary();

//    if (emp is IBonusEligible bonusEmp)
//    {
//        salary += bonusEmp.CalculateBonus();
//    }

//    Console.WriteLine($"{emp.name} Final Salary = {salary}");

//    totalPayroll += salary;
//}

//Console.

//----------------------------------------------------------------------
















//BankAccount acount1 = new BankAccount("Mourad",520);

//acount1.Withdraw(2000);
//acount1.Deposit(520);
//acount1.PrintStatment();

//Car obj1 = new Car();
//Console.WriteLine();
//obj1.FullThrottal();

//Car obj1 = new Car();

//obj1.Model = "Mercedis Binz";
//obj1.Color = "Black";
//obj1.Year = 2019;
//Console.WriteLine(obj1);
//Car obj2 = new Car("BMW","White",2026);

//Car obj1 = new Car();
//obj1.Color = Console.ReadLine();
//Console.WriteLine( obj1.Color);