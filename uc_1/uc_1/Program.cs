using System;

namespace uc_4
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hrs_In_Month = 100;
        static void Main(string[] args)
        {
            int empHour = 0;
            int totalworkingdays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalworkingdays < Num_Of_Working_Days)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case Is_Part_Time:
                        empHour = 4;
                        break;
                    case Is_Full_Time:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalEmpHrs += empHour;
                Console.WriteLine("Days: " + totalworkingdays + "  Emp hrs :" + empHour);
            }

            int totalEmpWage = totalEmpHrs + Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage : " + totalEmpWage);


        }
    }

    
}
