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
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Add(new OutsourcedEmployee(name, hours, valuePerHour, addcharge));
                } else 
                {
                    emp.Add(new Employee(name, hours, valuePerHour));
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
