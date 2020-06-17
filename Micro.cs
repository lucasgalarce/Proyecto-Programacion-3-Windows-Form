using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_programacion_3
{
    class Micro
    {
        public string nombre;
        public string descripcion;
        public double precio;
        public int stock;
        public Micro(string nombre, double precio, string descripcion, int stock)
        {

            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.stock = stock;

        }
    }
}

