using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asyncEmp
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }

    public class EmployeeManager
    {
        private List<Employee> employeesList;

        public EmployeeManager()
        {
            employeesList = new List<Employee>()
        {
            new Employee() { EmployeeId = 1, EmployeeName = "Kiran1" },
            new Employee() { EmployeeId = 2, EmployeeName = "Kiran2" },
            new Employee() { EmployeeId = 3, EmployeeName = "Kiran3" },
            new Employee() { EmployeeId = 4, EmployeeName = "Kiran4" },
            new Employee() { EmployeeId = 5, EmployeeName = "Kiran5" },
            new Employee() { EmployeeId = 6, EmployeeName = "Kiran6" },
            new Employee() { EmployeeId = 7, EmployeeName = "Kiran7" },
            new Employee() { EmployeeId = 8, EmployeeName = "Kiran8" },
            new Employee() { EmployeeId = 9, EmployeeName = "Kiran9" },
            new Employee() { EmployeeId = 10, EmployeeName = "Kiran10" }
        };
        }

        public async Task UpdateEmployeeAsync()
        {
            var updateTasks = new List<Task>();

             foreach (var item in employeesList)
            {
                updateTasks.Add(UpdateAsync(item));
            }

            await Task.WhenAll(updateTasks);
        }


        public async Task UpdateAsync(Employee emp)
        {
            await Task.Delay(2000); 
            Console.WriteLine($"\nUpdating employee {emp.EmployeeName} with ID {emp.EmployeeId}");
            var dbEmployee = employeesList.FirstOrDefault(e => e.EmployeeId == emp.EmployeeId);
            dbEmployee.EmployeeName = emp.EmployeeName;

            Console.WriteLine($"\nEmployee {emp.EmployeeName} with ID {emp.EmployeeId} has been updated.");
        }

    }

    public class Program
    {
        public static async Task Main()
        {
            var manager = new EmployeeManager();
            await manager.UpdateEmployeeAsync();
        }
    }
}