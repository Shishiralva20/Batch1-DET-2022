using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{ 
    internal class TestEmployee
    {
        public static void Main()
        {
            Employee emp = new Employee(22825, "Shishir", "Bangalore", 560098, 8105893428, 30000);
            Console.WriteLine($"Employee's net salary {emp.GetEmpNetSalary()}");
            Console.WriteLine($"Employee's grade is {emp.GetEmpGrade()}");
        }
    }
}

