using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class list
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        public void creaLista()
        { 
            list1.Add(4);
            list1.Add(6);
            list1.Add(20);
            list1.Add(1);
            list1.Add(11);
            list1.Add(25);
        }

        public void Lista()
        {
            Fibonacci Fib = new Fibonacci();
            foreach (int element in list1)
            {
                list2.Add(Fib.Calcular(element));
            }
        }

        public void imprime()
        {
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
        }

    }
    
}
