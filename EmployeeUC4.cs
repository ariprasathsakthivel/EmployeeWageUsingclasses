using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EmployeeUC4
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_HOUR = 20;
        //Variable
        private static int empHrs = 0;
        private static int empWage = 0;
        static Random random = new Random();
        //Computation
        static int empCheck = random.Next(0, 3);
        public static void EmpCheck()
        {
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
