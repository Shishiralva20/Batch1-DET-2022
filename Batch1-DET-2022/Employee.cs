using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Employee
    {
        int rollno;
        string name;
        string address;
        int pincode;
        long phoneno;
        int grosssal;
        int pf;

        public Employee(int rollno, string name, string address, int pincode, long phoneno, int grosssal)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.pincode = pincode;
            this.phoneno = phoneno;
            this.grosssal = grosssal;

        }

        public int GetEmpNetSalary()
        {
            pf = 12 * grosssal / 100;
            int netsalary = grosssal - pf;
            return netsalary;
        }

        public char GetEmpGrade()
        {

            //int netsalary = grosssal - pf;
            if (GetEmpNetSalary() > 10000)
            {
                return 'A';
            }
            else if (GetEmpNetSalary() > 5000)
            {
                return 'B';
            }
            else
                return 'C';

        }
    }
}