using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CompanyTest
    {
        public static void Main()
        {
            Company company = new Company();
            string n, a, p, f, em, m;

            Console.WriteLine("Enter Company Name");
            n = Console.ReadLine();
            Console.WriteLine("Enter Company Address");
            a = Console.ReadLine();
            Console.WriteLine("Enter Company Phone");
            p = Console.ReadLine();
            Console.WriteLine("Enter Company Fax");
            f = Console.ReadLine();
            Console.WriteLine("Enter Company Email");
            em = Console.ReadLine();
            Console.WriteLine("Enter Company Manager");
            m = Console.ReadLine();

            company.SetInfo(n, a, p, f, em, m);
            string info = company.PrintCompanyInfo();
            Console.WriteLine(info);
        }
    }
}