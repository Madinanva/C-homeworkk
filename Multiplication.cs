using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    sealed class Multiplication : Calculation
    {
       public sealed override int Operate(int n1, int n2)
        {
            return n1 * n2; 
        }
    }
}
