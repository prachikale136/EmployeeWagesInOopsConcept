using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeePayRoll
    {
        public const int WAGEPERHRS = 20;
        public const int FULL_DAY_PERHR = 8;
        public static int EmployeeAttendance()
        {
          const int IS_FULL_TIME = 1;
           Random random = new Random();
            int check = random.Next(0 , 3);
            return check;
        }

        public static int EmployeeDailyWage() 
        {
            int check = EmployeeAttendance();
            int empHrs = 0;
            switch (check)
            {
                case 0 :
                    empHrs = 0;
                    break;
                case 1 :
                    empHrs = 4;
                    break;
                case 2 :
                    empHrs = 8;
                    break;
            }
            int daliyWage = empHrs * WAGEPERHRS;
            return daliyWage;
        }

     }
}
