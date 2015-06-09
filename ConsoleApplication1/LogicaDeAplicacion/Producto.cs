using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeAplicacion
{
    public class Producto
    {
        private String _Identificador;
        private String _Nombre;
        private String _Fecha;

        public Producto(String Name, String ID, String Date)
        {
            _Nombre = Name;
            _Identificador = ID;
            _Fecha = Date;
        }


        public string Nombre
        {
            set { this._Nombre = value; }
            get { return this._Nombre; }
        }

        public string Identificador
        {
            set { this._Identificador = value; }
            get { return this._Identificador; }
        }

        public string Fecha
        {
            set { this._Fecha = value; }
            get { return this._Fecha; }
        }
    }
}
