using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class TestAge
    {
        public static void Main()
        {
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());

                Age a = new Age(age);
                int B = a.PrintAge();

                if (age < 1 || age > 100)
                {
                    throw new InvalidAgeException("ENTER VALID AGE");
                }
                Console.WriteLine(B);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}