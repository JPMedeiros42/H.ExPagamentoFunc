using System;
using System.Collections.Generic;
using System.Globalization;
using H.ExPagamentoFunc.Entities;

namespace H.ExPagamentoFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: " );
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (resp == 'y')
                {
                    Console.Write("Additional char: ");
                    double additional = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsorcedEmployee(name, hours, value, additional));
                }
                else 
                {
                    list.Add(new Employee(name, hours, value));
                }
                    

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
