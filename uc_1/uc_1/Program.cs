using System;

namespace uc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
