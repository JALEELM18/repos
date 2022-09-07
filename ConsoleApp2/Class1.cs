using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class class1

    {
            public static int mul_res(int a, int b, int c)
            {
                int mul;
            mul = a * b * c;
            return mul;
        }
        public static void Main()
        {
            Console.WriteLine("enter number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("multiplication of {0} and {1} and {2} is:{3}", a, b, c, mul_res( a,  b,  c));
        }

    }
}
