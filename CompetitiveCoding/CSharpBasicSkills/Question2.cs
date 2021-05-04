using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveCoding.CSharpBasicSkills
{
    

    public class Question2
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            return employees.GroupBy(x=>x.Company)
                .Select(x=>new {
                    Company = x.Key,
                    Age = Convert.ToInt32(x.Average(y=>y.Age))
                }).OrderBy(x=>x.Company).ToDictionary(res=>res.Company,res=>res.Age);

        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            return employees.GroupBy(x => x.Company)
                .Select(x => new {
                    Company = x.Key,
                    Count = x.Count()
                }).OrderBy(x => x.Company).ToDictionary(res => res.Company, res => res.Count);
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            return employees
                .GroupBy(x => x.Company)
                .Select(x => new {
                    Company = x.Key,
                    Employee = x.Where(y=>y.Age == x.Max(z=>z.Age)).FirstOrDefault(),
                }).OrderBy(x => x.Company).ToDictionary(res => res.Company,res=>res.Employee);
        }


        public static void Start()
        {

            int countOfEmployees = 12;

            string[] inputArr =
            {
                "Ainslee Ginsie Galaxy 28",
"Libbey Apdell Starbucks 44",
"Illa Stebbings Berkshire 49",
"Laina Sycamore Berkshire 20",
"Abbe Parnell Amazon 20",
"Ludovika Reveley Berkshire 30",
"Rene Antos Galaxy 44",
"Vinson Beckenham Berkshire 45",
"Reed Lynock Amazon 41",
"Wyndham Bamfield Berkshire 34",
"Loraine Sappson Amazon 49",
"Abbe Antonutti Starbucks 47"
            };

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string[] strArr = inputArr[i].Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
