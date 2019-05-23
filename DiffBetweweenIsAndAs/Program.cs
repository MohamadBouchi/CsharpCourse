using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffBetweweenIsAndAs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee
            //{
            //    ID = 101,
            //    name = "Mark"
            //};

            Employee emp = new PermenetEmployee
            {
                ID = 101,
                name = "Mark"
            };

            if ( emp is Employee)
            {
                Console.WriteLine(emp.name + "is employee");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(emp.name + "is not employee");

                Console.ReadKey();
            }

            if (emp is PermenetEmployee)
            {
                Console.WriteLine(emp.name + "is PermenetEmployee");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(emp.name + "is not PermenetEmployee");

                Console.ReadKey();
            }

            if (emp is ContractEmployee)
            {
                Console.WriteLine(emp.name + "is ContractEmployee");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(emp.name + "is not ContractEmployee");

                Console.ReadKey();
            }
        }

        class Employee
        {
            public int ID { get; set; }
            public string name { get; set; }
        }

        class PermenetEmployee : Employee
        {
            public int AnnualSalary { get; set; }
        }
        class ContractEmployee : Employee
        {
            public int HourlySalary { get; set; }
        }
    }
}
