using System;

namespace uc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_part_time = 1;
            int Is_Full_Time = 2;
            int empHrs = 0;
            int empWage = 0;
            int Emp_Rate_Per_hour = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 2);



            if (empcheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else if (empcheck == Is_part_time)
            {
                empHrs = 4;
            }
            else
            {

                empHrs = 0;

            }
            empWage = empHrs * Emp_Rate_Per_hour;
            Console.WriteLine("empwage is :" + empWage);
        }
    }
}
