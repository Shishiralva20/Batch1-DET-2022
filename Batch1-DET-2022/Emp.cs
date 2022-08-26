using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Emp
        {
            //data declared inside class are known as "fields"
            int id;
            string name;
            string dept;
            double sal;
            DateOnly doj;

            //constructor - is a function used to init object data
            //has the same name as classname, no ret type
            public Emp(int id, string name, DateOnly doj)
            {
                this.id = id; this.name = name; this.doj = doj;
            }

            //function written inside a class is known as method
            public int GetYearsofExp()
            {
                return DateTime.Now.Year - doj.Year;
            }
        }

}
