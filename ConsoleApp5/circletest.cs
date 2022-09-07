using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class circletest
    {
        public static void Main()
        {
            circle ob = new circle(53);
            double result = ob.areaofcircle();
            Console.WriteLine(result);
        }
    }
}
