using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class IteratorDemo
    {
        public static System.Collections.Generic.IEnumerable<int> MyMethod(int firstNumber,int lastNumber)
        {
            for(int number= firstNumber; number<= lastNumber; number++)
            {
                if(number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        static void Main()
        {
            foreach(int number in MyMethod(5,18))
            {
                Console.Write(number.ToString()+" ");
            }

        }
    }
}
