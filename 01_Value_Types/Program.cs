using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        public enum GenderType
        {
            Male, Female, Unknown
        }

        static void Main(string[] args)
        {
            //-- Declaration
            int myAge;

            //-- Initialization
            myAge = 30;

            //-- Intergers
            int i = 100;

            //-- Other Types
            byte by = 255;
            short sh = 32767;
            int iToo = 2147483647;
            float PI = 3.141592653f;
            Console.WriteLine(PI);
            double d = 780.01;
            decimal p = 7.80m;
            int? noValue = null;
            long youTubeMinutesWatched = 7654652168462168463;
            Console.WriteLine(youTubeMinutesWatched);



            //-- Booleans
            bool isEarly = true;

            //-- Boolean Logic/Conditionals
            if(isEarly)
                Console.WriteLine("Need more coffee");


            //--Declare Enum
            GenderType myGender = GenderType.Female;
            var everyoneElse = GenderType.Male;

            switch(myGender)
            {
                case GenderType.Male:
                    Console.WriteLine("Welcome sir");
                    break;
                case GenderType.Female:
                    Console.WriteLine("Welcome Ma'am");
                    break;
                case GenderType.Unknown:
                    Console.WriteLine("Welcome friend");
                    break;
            }
        }
    }
}
