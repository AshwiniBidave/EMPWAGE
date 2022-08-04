using System;

namespace uc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int empcheck;
            int Emp_Rate_per_hour = 20;
            int empHrs = 0;
            int empWage = 0;

            int Is_Full_Time = 1;
            Random random = new Random();
            empcheck = random.Next(0, 2);

            if (empcheck == Is_Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("Employyee is present");
            }
            else
            {

                Console.WriteLine("Employee is Absent");

            }
            empWage = empHrs * Emp_Rate_per_hour;
            Console.WriteLine("empwage is :" + empWage);
        }
    }
}
