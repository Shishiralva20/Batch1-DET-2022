using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Circle
    {
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public Double AreaOfCircle()
        {
            return Math.PI * radius * radius;
        }
    }
}