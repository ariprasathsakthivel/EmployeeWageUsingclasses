using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class EmployeeUC1
    {
        //Constants
        private static int IS_FULL_TIME = 1;
        private static Random random = new Random();

        //Computation
        private static int empCheck = random.Next(0, 2);
        public static void EmpAttendence()
        {
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
