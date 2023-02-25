using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeePayRoll
    {
        
        public static void EmployeeAttendance()
        {
          const int IS_FULL_TIME = 1;
        Random random = new Random();
            int check = random.Next(0 , 2);
            if (check == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else 
            {
                Console.WriteLine("Employee is absent");
            }

                   
        }
     }
}
