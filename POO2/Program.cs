using System;
using System.Globalization;
using POO2.Entities;
using POO2.Entities.Enums;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("ENTER WORKER DATA: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department department = new Department(deptName);

            Worker worker = new Worker(name,level,baseSalary,department);

            Console.Write("How many contracts to this worker? ");
            int quantityContracts = int.Parse(Console.ReadLine());

            HourContract contract;
            for(int i = 0; i < quantityContracts; i++)
            {
                Console.WriteLine("ENTER #" + (i+1) + " contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            double income = worker.Income(year, month);
            Console.WriteLine("Income for " + monthAndYear +": " + worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));




        }
    }
}
