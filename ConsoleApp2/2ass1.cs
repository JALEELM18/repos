using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class _2ass1

    {
        public static int Multi(int a, int b, int c)
        {
            int result;
            result= a * b * c;
            return result; 
        }
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your answer is",a,b,c,Multi(a,b,c));
        }

    }
}