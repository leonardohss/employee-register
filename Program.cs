using System;
using EmployeeRegister.Entities;

namespace EmployeeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("bob", 3, 100.0);
            Employee emp2 = new OutsourcedEmployee("bob", 3, 100.0, 10);

            Console.WriteLine(emp1.Payment());
            Console.WriteLine(emp2.Payment());
        }
    }
}
