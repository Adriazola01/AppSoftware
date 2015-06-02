using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hola");
            Console.WriteLine("Mas texto...!");
            //Fibonacci Fib = new Fibonacci();
            //Console.WriteLine(Fib.Calcular(1));
            //Console.WriteLine(Fib.Calcular(2));
            //Console.WriteLine(Fib.Calcular(3));
            //Console.WriteLine(Fib.Calcular(6));
            //list ar = new list();
            //ar.creaLista();
            //ar.Lista();
            //ar.imprime();

            ArrayList myArray = new ArrayList();
            myArray.Add(4);
            myArray.Add(6);
            myArray.Add(20);
            myArray.Add(1);
            myArray.Add(11);
            myArray.Add(25);
            Number num = new Number();
            //int[] array = myArray.ToArray(typeof(int)) as int[];
            num.fiboArreglo(myArray);

            List<int> list1 = new List<int>();
            list1.Add(4);
            list1.Add(6);
            list1.Add(20);
            list1.Add(1);
            list1.Add(11);
            list1.Add(25);
            //int[] array2 = myArray.ToArray(typeof(int)) as int[];
            num.fiboArreglo(list1);

            Console.ReadKey();
        }
    }
}
