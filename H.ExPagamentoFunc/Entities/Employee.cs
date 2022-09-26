using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.ExPagamentoFunc.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double value)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = value;
        }
        
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
        public override string ToString()
        {
            return ($"{Name} - $ {Payment()}");
        }
    }
}
