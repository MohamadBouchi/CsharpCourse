using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hello();
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static void Hello()
        {
            try
            {
                throw new Exception("Try Exception");
            }
            //catch
            //{

            //}
            finally
            {
                throw new Exception("Finally Exception");
                //Console.WriteLine("this line will be executed");
                //int result = Convert.ToInt32("TEN");
                //Console.WriteLine("this line will not be executed");
            }
        }
    }
}
