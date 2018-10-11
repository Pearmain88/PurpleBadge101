using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Methods_And_Repository_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Hello(name);
            var age = GetAge();
        }

        private static void Hello(string name)
        {
            throw new NotImplementedException();
        }

        private static object GetAge()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            return age;
        }
    }
}
