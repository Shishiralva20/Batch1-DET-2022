using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action=(string name) => { Console.WriteLine($"Hai {name}"); };
            //action().Invoke("Mary");

            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai {s1}," + $"you said {s2}"); };

            action.Invoke("Shishir");
            action1.Invoke("Shishir", "am in Blr");

            Action<int, string ,string> printEmp = (int id, string name, string email) =>
                {
                    Console.WriteLine($"id={id}, name={name},email={email}"); 
                };

                printEmp(22861, "Shishir", "shishiralva.s");

            Func<int, int, long> multiply = (x, y) =>
            {
                return x * y;
            };
            long result = multiply(100, 100);
            Console.WriteLine(result);
        

        /*static void Hi(string name)
        {
            Console.WriteLine("Hai" + name);
        }*/


        HashSet<int> ids = new HashSet<int>();
        ids.Add(25346);
        ids.Add(25347);
        ids.Add(25348);
        ids.Add(25349);
        ids.Add(25350);

            foreach(int id in ids)
            Console.WriteLine(id);
        }
    }
}
