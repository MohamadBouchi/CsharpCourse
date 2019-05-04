using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmp fte = new FullTimeEmp()
            {
                ID = 1,
                FirstName = "emp1",
                LastName = "lemp1",
                AnnualSalary = 50000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("-------");

            ContractEmp cte = new ContractEmp()
            {
                ID = 1,
                FirstName = "emp2",
                LastName = "lemp2",
                HourlyPay = 20,
                TotalHours = 40
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
