using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class TestEmp
    {
        public static void Main()
        {
            Emp e = new Emp(5050, "Jaleel", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Years of experience{e.GetYearsofExp()}");
        }
    }
}
