using System;
using System.Globalization;
using System.Collections.Generic;
using employees.Entities;

namespace employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                //Is a outsourced?
                Console.Write("Outsourced? (y/n)? ");
                char outSourced = char.Parse(Console.ReadLine());
                //Name
                string name = Console.ReadLine();
                //Hours
                int hours = int.Parse(Console.ReadLine());
                //Value per hour
                double valuePerHour = double.Parse(Console.ReadLine());
                
                //Declaring Employee variable
                Employee employee;

                if(outSourced == 'y')
                {
                    //Pick the fourth value of the type
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    //Then add to the list
                    employee = new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
                }
                else
                {
                    employee = new Employee(name, hours, valuePerHour);
                }
                //Finally add to the list
                employeesList.Add(employee);
            }
            
        }
    }
}
