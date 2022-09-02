using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface Icar
    {
        int GetPrice(string name);
    }

    class BMW : Icar
    {
        public int GetPrice(string name)
        {
            if (name == "M3")
                return 13000000;
            else if (name == "X7")
                return 9600000;
            else
                return 1000000;
        }
    }

    class Hyundai : Icar
    {
        public int GetPrice(string name)
        {
            if (name == "Creta")
                return 1300000;
            else if (name == "Verna")
                return 1100000;
            else
                return 900000;
        }
    }

}
