using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            int numero = 1;
            try
            {
                while (true)
                {
                    fibo.Calcular(numero);
                    numero++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(numero);
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
           
        }
    }
}
