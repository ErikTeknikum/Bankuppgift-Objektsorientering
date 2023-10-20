using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Anställda_med_arv_och_polymorfism
{
    abstract class Employee
    {
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
        public double HourPay { get; set; }
        public int WorkHours { get; set; }

        public abstract double CalculateSalary();
    }    
}
