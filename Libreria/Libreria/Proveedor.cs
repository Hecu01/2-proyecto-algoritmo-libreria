using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Libreria
{
    public class Proveedor
    {
        public int id; //identificador general
        public string nombre = "";
        public string email = "@correr.com";
        public Proveedor(string name, string correo, int id)
        {
            this.nombre = name;
            this.email = correo;
            this.id = id;
        }
    }
}
