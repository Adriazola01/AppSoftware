using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeAplicacion
{
    public class BuscarIdenficacion
    {
        Producto ProductoIdentificado;

        public Producto BuscarPorIdentificacion(String Id)
        {
            CarritoDeCompras carrito = new CarritoDeCompras();
            foreach (Producto i in carrito.CCompras)
            {
                Console.WriteLine(i.Identificador);
                if (Id == i.Identificador)
                {
                    Console.WriteLine(i.Identificador);
                    ProductoIdentificado = i;
                    
                }
            }
            Console.WriteLine("test");
            return ProductoIdentificado;
        }
    }
}
