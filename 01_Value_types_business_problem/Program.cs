using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_types_business_problem
{
    class Program
    {
        public enum VehicleType { Car = 1, Motorcycle, Boat, Plane }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo! What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What kind of vehicle are you insuring?\n" +
                "1. Car\n" +
                "2. Motorcycle\n" +
                "3. Boat\n" +
                "4. Plane\n");
            int type = int.Parse(Console.ReadLine());
            
            VehicleType vehicleType = (VehicleType)type;

            decimal premium = 0;

            //switch(vehicleType)
            //{
            //    case VehicleType.Car:
            //        if(age >= 18 && age <= 27) { return }

            //}


            Console.WriteLine($"Hello {name}, you are {age} years old and are insuring a {vehicleType}. \n" +
                $"Your premium will be ${premium} per month. \n" +
                $"Thank you!");
            





        }
    }
}
