using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class CheckEmp
    {
        public static void EmpAtten()
        {
            Random random = new Random();
            int n = random.Next(2);
            if (n == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Abscent");
            }
        }
    }
}
