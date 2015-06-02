using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


    public class Number
    {
        public void fiboArreglo(IEnumerable ar)
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

