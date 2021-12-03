using System;

namespace HomeWork_03._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Qeyd : 1 eded obyekt yaradib diger field-leri miras olaraq goturdum.

             Employee employee = new Employee();

            
            employee.Name = "Saxavat";
            employee.Surname = "Aliyev";
            

            employee.PositionName = "Network Engineer";
            employee.PositionDailySalary = 55;
            employee.PositionWorkDays = 22;

            Console.WriteLine("******************Employee Info******************\n");

            employee.Fullname(); 

            int result = employee.ClcSalary();
            Console.WriteLine($"Monthly salary:   {result} $\n");

            Console.WriteLine("**************Thanks your attention**************\n");

            Console.ReadLine();

        }
    }
}
