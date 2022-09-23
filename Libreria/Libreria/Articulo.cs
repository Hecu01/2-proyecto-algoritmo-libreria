using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Libreria
{
    public class Articulo
    {
        int id;
        public string nombre {set; get;}
        public string descripcion { set; get; }
        public int cantidad { set; get; }
        public double precio_x_unidad {set; get;}
        public string Marca {set; get;}

        

        public Articulo(int id, string name, string desc, int cant, double precio, string marc)
        { 
            this.id= id;
            this.nombre =name;
            this.descripcion = desc;
            this.cantidad = cant;
            this.precio_x_unidad = precio;
            this.Marca = marc;
        }

    }
}
