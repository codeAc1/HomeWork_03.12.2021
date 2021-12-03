using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03._12._2021
{
    class Salary:Positions
    {

        public int ClcSalary()
        {
            int result = 0;
            for (int i = 0; i < PositionWorkDays; i++)

              {
                result = PositionDailySalary * PositionWorkDays;
              }
            return result;
        }



    }
}
