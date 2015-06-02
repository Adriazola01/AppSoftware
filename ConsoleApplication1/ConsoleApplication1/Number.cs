using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Number
    {
        public void fiboArreglo(array ar)
        {
            Fibonacci Fib = new Fibonacci();
            ArrayList arrayL = new ArrayList();
            foreach (int element in ar)
            {
                arrayL.Add(Fib.Calcular(element));
            }

            foreach (int i in arrayL)
            {
                Console.WriteLine(i);
            }
        }
    }
}
