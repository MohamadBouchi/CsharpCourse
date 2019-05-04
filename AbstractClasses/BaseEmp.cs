using System;

namespace AbstractClasses
{
    public abstract class BaseEmp
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        //public virtual int GetMonthlySalary()
        //{
        //    throw new NotImplementedException();
        //}

        public abstract int GetMonthlySalary();
    }
}
