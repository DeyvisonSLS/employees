using System;
using employees.Entities;

namespace employees.Entities
{
    class OutsourceEmployee : Employee
    {
        double AdditionalCharge { get; set;}
        public OutsourceEmployee()
        {
        }
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            double payment = base.Payment();
            return payment + payment * 1.1;
        }
    }
}