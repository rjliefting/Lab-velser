using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LabØvelse3
{
    public class MatteKlasse
    {
        public int Add(int int1, int int2)
        {
            return int1 + int2;
        }

        public int Subtract(int int1, int int2)
        {
            return int1 - int2;
        }

        public int Multiply(int int1, int int2)
        {
            return int1 * int2;
        }

        public int Divide(int int1, int int2)
        {
            return int1 / int2;
        }
    }
}
