using System;
using System.Collections.Generic;


namespace Delegate_task
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public float Experiance { get; set; }

        public static void PromoteEmp(List<Employee> EmployeeList, Func<Employee, bool> promoteCondition)
        {
            foreach (Employee emp in EmployeeList)
            {
                if (promoteCondition(emp))
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee { ID = 1, Name = "Ram", salary = 50000, Experiance = 3 },
            new Employee { ID = 2, Name = "Seeta", salary = 60000, Experiance = 6 },
            new Employee { ID = 3, Name = "Sai", salary = 70000, Experiance = 4 },
            new Employee { ID = 4, Name = "Kiran", salary = 80000, Experiance = 7 }
        };

            Employee.PromoteEmp(employees,emp => emp.Experiance>5);
        }
    }
}
