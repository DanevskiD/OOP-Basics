using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfEmpolyees
{
    internal class Program
    {
        /*
         Define a class Employee with fields: Name, Salary, Position, Department, Email and Age
        Write a program which:
        - Reads n rows with the employees inserted from the console;
        - Finds the department with the highest salary;
        - For every employee from that department print us his name, salary, email and age;
        - The employees must be sorted by their salary, by descending order;
        - If information about employee's email is missing, the console should print us "n/a";
        - If information about employee's age is missing, the console should print us "-1";
        - The salary must be printed with two decimals.
        Input:
        n: number of employees
        Name Salary Position Department Email Age
        Output:
        Highest Average Salary: Department
        Name Salary Email Age

         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<Employee>> employeesByDepartment = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                Employee employee = ReadEmployee();

                if (!employeesByDepartment.ContainsKey(employee.Department))
                    employeesByDepartment[employee.Department] = new List<Employee>();
                employeesByDepartment[employee.Department].Add(employee);
            }

            /*string highestAverageSalaryDepartment = employeesByDepartment
                .OrderByDescending(x => x.Value.Sum(e => e.Salary) / x.Value.Count)
                .First()
                .Key;*/

             /*string highestAverageSalaryDepartment = employeesByDepartment
                .MaxBy(x => x.Value.Sum(e => e.Salary) / x.Value.Count)
                .Key;*/

            string highestAverageSalaryDepartment = string.Empty;
            decimal highestAverageSalary = 0;

           /* foreach (KeyValuePair<string, List<Employee>> kvp in employeesByDepartment)
            {
                string department = kvp.Key;
                List<Employee> employees = kvp.Value;

                decimal currentAverage = employees.Sum(e => e.Salary) / employees.Count;
                if (currentAverage > highestAverageSalary)
                {
                    highestAverageSalaryDepartment = department;
                    highestAverageSalary = currentAverage;
                }
            }*/

            foreach (var (department, employees) in employeesByDepartment)
            {
                decimal currentAverage = employees.Sum(e => e.Salary) / employees.Count;
                if (currentAverage > highestAverageSalary) 
                {
                    highestAverageSalaryDepartment = department;
                    highestAverageSalary = currentAverage;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment}");

            foreach (Employee employee in employeesByDepartment[highestAverageSalaryDepartment]
                .OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }

        static Employee ReadEmployee()
        {
            string[] inputData = Console.ReadLine().Split();

            Employee employee = new Employee();
            employee.Name = inputData[0];
            employee.Salary = decimal.Parse(inputData[1]);
            employee.Position = inputData[2];
            employee.Department = inputData[3];

            if (inputData.Length == 6)
            {
                employee.Email = inputData[4];
                employee.Age = int.Parse(inputData[5]);
            }
            else if (inputData.Length == 5)
            {
                if (int.TryParse(inputData[4], out int age))
                    employee.Age = age;
                else employee.Email = inputData[4];
            }

            return employee;

        }
    }
}
