using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaDeAplicacion;

namespace AplicacionPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            BuscarIdenficacion BuscarId = new BuscarIdenficacion();
            CarritoDeCompras carrito = new CarritoDeCompras();
            carrito.AgregarCarrito(new Producto("iPod Touch 64GB", "10199", "2015-06-06"));
            carrito.AgregarCarrito(new Producto("ChromeCast", "13100", "2015-03-06"));
            carrito.AgregarCarrito(new Producto("Laptop HB 256GB", "10299", "2015-07-06"));
        

            foreach (Producto i in carrito.CCompras)
            {
                Console.WriteLine("Producto: " + i.Nombre);
                Console.WriteLine("ID: " + i.Identificador);
                Console.WriteLine("Fecha de Registro: " + i.Fecha);
                Console.WriteLine("--------------------------------------");

            }
            //Producto identificado = BuscarId.BuscarPorIdentificacion("10199");
            //Console.WriteLine("Producto: " + identificado.Nombre);
            //Console.WriteLine("ID: " + identificado.Identificador);
            //Console.WriteLine("Fecha de Registro: " + identificado.Fecha);
            //Console.WriteLine("--------------------------------------");
            Console.ReadKey();
            }
        }
    }

