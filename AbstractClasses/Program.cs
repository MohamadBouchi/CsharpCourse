using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            CorporateCustomer CC = new CorporateCustomer();
            Console.WriteLine(CC.ID);

            SavingCustomer SC = new SavingCustomer();
            Console.WriteLine(SC.ID);

            Console.ReadKey();

            //FullTimeEmp fte = new FullTimeEmp()
            //{
            //    ID = 1,
            //    FirstName = "emp1",
            //    LastName = "lemp1",
            //    AnnualSalary = 50000
            //};

            //Console.WriteLine(fte.GetFullName());
            //Console.WriteLine(fte.GetMonthlySalary());

            //Console.WriteLine("-------");

            //ContractEmp cte = new ContractEmp()
            //{
            //    ID = 1,
            //    FirstName = "emp2",
            //    LastName = "lemp2",
            //    HourlyPay = 20,
            //    TotalHours = 40
            //};

            //Console.WriteLine(cte.GetFullName());
            //Console.WriteLine(cte.GetMonthlySalary());
        }

        public abstract class Customer
        {
            protected Customer()
            {
                this._id = Guid.NewGuid();
            }

            private Guid _id;

            public Guid ID
            {
                get
                {
                    return this._id;
                }
            }
        }

        public class CorporateCustomer : Customer
        {
            public CorporateCustomer()
            {

            }
        }

        public class SavingCustomer : Customer
        {
            public SavingCustomer()
            {

            }
        }
    }
}
