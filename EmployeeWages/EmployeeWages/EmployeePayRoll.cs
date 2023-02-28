using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeePayRoll
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

      public static int ComputeEmployeeWages(string company, int empRatePerHr, int numberOfWorkingDay, int maxHrsPerMonth)
      {
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        int empHrs = 0;

            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < numberOfWorkingDay)
            { 
                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case 0:
                        empHrs = 0;
                        break;
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "emp hrs" + empHrs);
            }
             int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("total emp wage for company: " + company + "is:" + totalEmpWage);
            return totalEmpWage;
     }
        
                    
    }

    
}
