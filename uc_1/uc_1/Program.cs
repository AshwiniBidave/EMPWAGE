using System;

namespace uc_8
{
    class EmpWageBuilderObject
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        private String company;
        private int Emp_Rate_Per_Hour = 20;
        private int Num_Of_Working_Days = 20;
        private int Max_Hrs_In_Month = 100;
        private int totalEmpWage;


        public EmpWageBuilderObject(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            this.company = company;
            this.Emp_Rate_Per_Hour = Emp_Rate_Per_Hour;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.Max_Hrs_In_Month = Max_Hrs_In_Month;
        }
        public void computeEmpWage()

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
            int empWage = empHour * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage : " + empWage);
            
        }
        public string toString()
        {
            return "total company:" + this.company + "is" + this.totalEmpWage;
        }

        

        private static void Main(string[] args)
        {

            EmpWageBuilderObject dmart=new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 20, 2, 10);

           
        }

    }

    
}
