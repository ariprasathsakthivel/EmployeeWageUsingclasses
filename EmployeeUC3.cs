using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EmployeeUC3
    {
        //Constants
        private static int  IS_FULL_TIME = 1;
        private static int EMP_RATE_PER_HOUR = 20;
        //Variables
        private static int empHrs = 0;
        private static int empWage = 0;
        static  Random random = new Random();
        //Computation
        static  int empCheck = random.Next(0, 2);
        public void EmpCheck()
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
