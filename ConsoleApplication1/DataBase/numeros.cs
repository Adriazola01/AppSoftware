using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Numeros
    {
        private List<int> list = new List<int>();

        public void Agregar(int numero)
        {
            list.Add(numero);
        }

        public int ObtenerCantidad()
        {
            int cantidad = list.Count;
            //foreach (int i in list)
            //{
            //    num++;
            //}
            return cantidad;
        }
    }
}
