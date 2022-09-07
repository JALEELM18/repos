using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class employees
    {
        int rollno;
        string name;
        string address;
        int pincode;
        int phoneNumber;
        int grossSalary;
        int pf;

        public employees(int rollno, string name, string address, int pincode, int phoneNumber, int grossSalary, int pf)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.pincode = pincode;
            this.phoneNumber = phoneNumber;
            this.grossSalary = grossSalary;
            this.pf = pf;
        }
    }

}
