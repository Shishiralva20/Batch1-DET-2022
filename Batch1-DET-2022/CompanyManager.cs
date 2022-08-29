using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CompanyManager
    {
        public static int Incentives = 25000; //at the class level
        public string Name { get; set; } //at the object level
        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Print()
        {
            return $"Name={Name}, Surname={Surname}, Phone={Phone}";    
        }
    }
}
