using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class AnimalTest
    {
        public static void Main()
        {

            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Cat());
            Animals.Add(new Dog());
            Animals.Add(new Frogs());

            foreach (Animal a in Animals)
                Console.WriteLine(a.ToString());
        }

    }
}