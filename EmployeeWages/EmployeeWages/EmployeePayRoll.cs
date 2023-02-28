using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeePayRoll
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHrs;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;

        public EmployeePayRoll(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth) 
        {
            this.company = company;
            this.empRatePerHrs= empRatePerHr; 
            this.numOfWorkingDays = numOfWorkingDays;  
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public void ComputeEmployeeWages()
        {
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int empHrs = 0;

            while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * this.empRatePerHrs;
            Console.WriteLine("total emp wage for company: " + company + "is:" + totalEmpWage);
            //return totalEmpWage;

        }
            public string toString()
            {
                return "total emp wage for company: " + this.company + " is:" + this.totalEmpWage;
            }
     }
}
