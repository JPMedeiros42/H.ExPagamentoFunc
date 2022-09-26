using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.ExPagamentoFunc.Entities
{
    class OutsorcedEmployee : Employee
    {

        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee(string name, int hours, double value, double additionalcharge):base(name,hours,value)
        {
            AdditionalCharge = additionalcharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
