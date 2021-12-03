using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03._12._2021
{
    class Employee:Salary

    {
        public string Name;
        public string Surname;
        
        public void Fullname()
        {
            Console.WriteLine($"          Name:   {Name} ");
            Console.WriteLine($"       Surname:   {Surname}");
            Console.WriteLine($"      Position:   {PositionName}");
        }


       





    }
}
