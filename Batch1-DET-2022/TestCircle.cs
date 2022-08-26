using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            Circle e = new Circle(20);
            Console.WriteLine($"The area of Circle = {e.AreaOfCircle()}");
        }
    }
}
