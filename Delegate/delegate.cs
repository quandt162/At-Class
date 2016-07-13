using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class DelegateDemo
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, NAME = "Quan1", SALARY = 1000, EXPERIENCE = 1 });
            empList.Add(new Employee() { ID = 102, NAME = "Quan2", SALARY = 1500, EXPERIENCE = 3 });
            empList.Add(new Employee() { ID = 103, NAME = "Quan3", SALARY = 2000, EXPERIENCE = 2 });
            empList.Add(new Employee() { ID = 104, NAME = "Quan4", SALARY = 2500, EXPERIENCE = 4 });

            ISPromote isPromoteable = new ISPromote(Promote);
            Employee.PromoteEmployee(empList, isPromoteable);

           // Employee.PromoteEmployee(empList, e => e.EXPERIENCE >= 5);

            Console.ReadLine();
        }
        public static bool Promote(Employee emp)
        {
            if (emp.EXPERIENCE >= 2)
            {
                return true;
            }
            else return false;
        }
    }

    delegate bool ISPromote(Employee emp);

    class Employee
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public double SALARY { get; set; }
        public int EXPERIENCE { get; set; }

        public static void PromoteEmployee(List<Employee> empList, ISPromote isEligibleToPromote)
        {
            foreach(Employee employee in empList)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.NAME + " promoted");
                }
            }
        }
    }
}
