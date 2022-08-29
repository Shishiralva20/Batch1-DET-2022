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
            Circle c = new Circle();
            Console.WriteLine("Enter Radius Value");
            double r = int.Parse(Console.ReadLine());
            c.SetRadius(r);
            double rad = c.GetRadius();
            Console.WriteLine(rad);
            double area = c.GetArea();
            Console.WriteLine(area);
            double diam = c.GetDiameter();
            Console.WriteLine(diam);
            double circ = c.GetCircum();
            Console.WriteLine(circ);
        }
    }
}