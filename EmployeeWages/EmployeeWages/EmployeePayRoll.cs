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
        public const int PART_TIME_HRS = 4;
        public static int EmployeeAttendance()
        {
          const int IS_FULL_TIME = 1;
            int EmpHrs = 0;
           Random random = new Random();
            int check = random.Next(0 , 2);
            if (check == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs= 4;
            }
            int daliyWage = EmpHrs * WAGEPERHRS;
            return daliyWage;
        }

        

     }
}
