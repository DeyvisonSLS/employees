using System;
using System.Globalization;

namespace employees.Entities
{
    class Employee
    {
        public string Name { get; protected set; }
        public int Hours { get; protected set; }
        public double ValuePerHour { get; protected set; }
        public Employee()
        {
        }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Name + " - $" + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}