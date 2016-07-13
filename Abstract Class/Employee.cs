using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Employee
    {
        public string Name { get; set; }

        public abstract double GetSalary();
        ///<summary>
        ///print information of class
        ///<paramref name="none"/>
        ///</summary>


        public void Intro()
        {
            Console.WriteLine();
        }
    }
}
