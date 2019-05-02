using System;
using System.Collections;

namespace CsharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //object[] array = new object[3];
            //array[0] = 1;
            //array[1] = "item2";

            Customer c = new Customer();
            c.ID = 99;
            c.Name = "customer1";

            //array[2] = c;

            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("item2");
            array.Add(c);

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
