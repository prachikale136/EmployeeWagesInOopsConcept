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
        public const int IS_FULL_TIME = 8;
        public const int IS_PART_TIME = 4;
        public const int WORKINGDAYPERMONTH = 20;
        //public const int FULL_DAY_PERHR = 8;
        //public const int PART_TIME_HRS = 4;

        public static int EmployeeAttendance()
        {
           Random random = new Random();
           int check = random.Next(0 , 3);
           return check;
        }

        public static int EmployeeDailyWage()
        {
            int EmpHrs = 0;
            int check = EmployeeAttendance();
            switch (check) 
            {
                case 0:
                    EmpHrs = 0;
                    break;
                case 1: 
                    EmpHrs = 8;
                    break;
                case 2:
                    EmpHrs = 4;
                    break;
            }
            int daliyWage = EmpHrs * WAGEPERHRS;
            return daliyWage;
        }

        public static int MonthlyWage()
        {
            int totalEmpWage = 0;
            for (int i = 1; i <= WORKINGDAYPERMONTH; i++)
            {
                totalEmpWage += EmployeeDailyWage();
            }
            return totalEmpWage;

        }

     }
}
