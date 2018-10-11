using _04_Employee_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EmployeeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo repo = new EmployeeRepo();

            Console.WriteLine("Enter employee id");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter employee name");
            var name = Console.ReadLine();

            Console.WriteLine("enter empployee age");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter employee salary");
            var salary = double.Parse(Console.ReadLine());

            Employee newEmployee = new Employee()
            {
                EmployeeID = id,
                Name = name,
                Age = age,
                Salary = salary
            };

            repo.AddEmployeeToList(newEmployee);

            var newList = repo.GetList();

            foreach(Employee e in newList)
            {
                Console.WriteLine(e.EmployeeID +" "+ e.Name);
            }
            Console.ReadKey();

        }
    }
}
