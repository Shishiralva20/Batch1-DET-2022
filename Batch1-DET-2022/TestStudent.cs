using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class TestStudent
    {
        public static void Main()
        {
            Console.WriteLine("Choose Stream");
            Console.WriteLine("1: Science");
            Console.WriteLine("2: Economics");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("Enter Reg. No");
                int R = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string N = Console.ReadLine();
                Console.WriteLine("Enter Physics Marks");
                int P = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Chemistry Marks");
                int C = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Biology Marks");
                int B = int.Parse(Console.ReadLine());

                Science.ScienceStudent s = new Science.ScienceStudent();
                s.RegNo = R;
                s.Name = N;
                s.Physics = P;
                s.Chemistry = C;
                s.Biology = B;
                double avg = s.GetAvgMarks();
                Console.WriteLine($"Average Marks is = {avg}");

            }
            else
            {
                Console.WriteLine("Enter Reg. No");
                int R = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string N = Console.ReadLine();
                Console.WriteLine("Enter Economics Marks");
                int E = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Banking Marks");
                int B = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Accounts Marks");
                int A = int.Parse(Console.ReadLine());

                Commerce.CommerceStudent s = new Commerce.CommerceStudent();
                s.RegNo = R;
                s.Name = N;
                s.Economics = E;
                s.Banking = B;
                s.Accounts = A;
                double avg = s.GetAvgMarks();
                Console.WriteLine($"Average Marks is = {avg}");
            }

        }
    }
}