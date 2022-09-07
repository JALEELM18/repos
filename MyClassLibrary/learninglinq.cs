using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    internal class learninglinq
    {
        private static void Main()
        {
            //the three parts of a LINQ Query : deffered execution
            // 1.Data Source
            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);


            // 2.Query creation .sql type
            var numQuery = from num in numbers    //select num from numbers
                           select num;

            // 3.Query execution

            foreach (int num in numbers)
            {
                Console.Write("{0}", num);

            }

        }

    }
}
