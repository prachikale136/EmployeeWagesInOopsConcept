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
        //public const int FULL_DAY_PERHR = 8;
        //public const int PART_TIME_HRS = 4;
       
        public static int EmployeeAttendance()
        {
             int IS_FULL_TIME = 1;
             int IS_PART_TIME = 2;
            int EmpHrs = 0;
           Random random = new Random();
            int check = random.Next(0 , 3);
            if (check == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else if (check == IS_PART_TIME)
            {
                EmpHrs = 4;
            }
            else
            { 
                EmpHrs= 0;
            }
            int daliyWage = EmpHrs * WAGEPERHRS;
            return daliyWage;
        }

        

     }
}
