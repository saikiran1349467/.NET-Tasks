using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection_Linq
{

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDepartment { get; set; }
        public int EmployeeSalary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, EmployeeName = "Ravi Kumar", EmployeeDepartment = "IT", EmployeeSalary = 50000 },
            new Employee { EmployeeId = 2, EmployeeName = "Sai Kiran", EmployeeDepartment = "HR", EmployeeSalary = 60000 },
            new Employee { EmployeeId = 3, EmployeeName = "Hari", EmployeeDepartment = "Finance", EmployeeSalary = 70000 },
        };

            var projectionResult = employees.Select(e => new { e.EmployeeName , e.EmployeeSalary });

            foreach (var emp in projectionResult)
            {
                Console.WriteLine($"Employee Name: {emp.EmployeeName} Salary: {emp.EmployeeSalary}");
            }
        }
    }
}
