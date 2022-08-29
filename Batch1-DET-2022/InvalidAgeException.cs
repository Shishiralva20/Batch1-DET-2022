using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string msg) : base(msg)
        {

        }
    }
}