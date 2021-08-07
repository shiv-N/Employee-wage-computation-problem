using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC 1
            int is_Full_day = 1;

            Random random = new Random();
            int day = random.Next(0, 2);

            if(day == is_Full_day)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }    
            
        }
    }
}
