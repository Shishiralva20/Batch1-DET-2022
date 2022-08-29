using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public abstract class Student
    {
        public int RegNo { get; set; }
        public string Name { get; set; }

        public abstract double GetAvgMarks();

    }

    public class Science
    {
        public class ScienceStudent : Student
        {
            public int Physics;
            public int Chemistry;
            public int Biology;
            public override double GetAvgMarks()
            {
                return (Physics + Chemistry + Biology) / 3;
            }
        }
    }

    public class Commerce
    {
        public class CommerceStudent : Student
        {
            public int Economics;
            public int Banking;
            public int Accounts;
            public override double GetAvgMarks()
            {
                return (Economics + Banking + Accounts) / 3;
            }
        }
    }

}