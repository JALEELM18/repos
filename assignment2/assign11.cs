using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class assign11
    {
        public static void getsmaller(int a, int b, out int res)
        {
            if (a < b)
            {
                res = a;
                //return a;
            }
            else
            {
                res = b;
                // return b;
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            getsmaller(a, b, out int res);
            Console.WriteLine($"{res} is samllest");
        }
    }
}
