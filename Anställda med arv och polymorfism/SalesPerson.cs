using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anställda_med_arv_och_polymorfism
{
    internal class SalesPerson : Employee
    {
        public override double CalculateSalary()
        {
            Salary = HourPay * WorkHours;
            return Salary;
        }        
    }
}
