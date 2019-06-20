using System;
using EmployeeRegister.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int qtde = int.Parse(Console.ReadLine());

            for(int x = 1; x <= qtde; x++)
            {
                Console.WriteLine($"Employee #{x} data: ");
                Console.Write("Outsourced? (y/n): ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == "n")
                {
                    Employee empcreate = new Employee(name, hours, valuePerHour);
                    emp.Add(empcreate);
                } else if(type == "y")
                {
                    Console.Write("Additional charge: ");
                    double addcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee empcreate = new OutsourcedEmployee(name, hours, valuePerHour, addcharge);
                    emp.Add(empcreate);
                } else
                {
                    Employee empcreate = new Employee(name, hours, valuePerHour);
                    emp.Add(empcreate);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach(Employee x in emp)
            {
                Console.WriteLine(x.Name + " - $" + x.Payment().ToString("F2"));
            }
        }
    }
}
