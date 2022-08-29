using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Company
    {
        string Name;
        string Address;
        string Phone;
        string Fax;
        string Website;
        string Manager;

        public void SetInfo(string Name, string Address, string Phone, string Fax, string Website, string Manager)
        {
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Fax = Fax;
            this.Website = Website;
            this.Manager = Manager;
        }

        public string PrintCompanyInfo()
        {
            return $"{Name}, {Address}, {Manager}";
        }
    }
}