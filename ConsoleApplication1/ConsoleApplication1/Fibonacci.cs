using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibonacci
    {
        public int Calcular(int f)
        {
            if (f == 1)
            {
                return f;
            }
            else if(f==2)
            {
                return f-1;
            }
            else
            {
                int Fibo = Calcular(f-1) + Calcular(f-2);
                return Fibo;
            }
        }
    }
}
