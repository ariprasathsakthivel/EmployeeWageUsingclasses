using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EmployeeUC2
    {
        //Constants
        static int IS_FULL_TIME = 1;
        static int EMP_RATE_PER_HOUR = 20;
        //Variables
        static int empHrs = 0;
        static int empWage = 0;
        static Random random = new Random();
        //Computation
        static int empCheck = random.Next(0, 2);
        public static void EmpAttendence()
        {
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }

    }
}
