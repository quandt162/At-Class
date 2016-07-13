using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Worker : Employee
    {
        private const double RATE = 2.54;
        public int WorkingHours { get; set; }

        public Worker(string name, int workingHours)
        {
            Name = name;
            WorkingHours = workingHours;
        }
        
        public override double GetSalary()
        {
            return RATE * WorkingHours;
        }
    }
}
