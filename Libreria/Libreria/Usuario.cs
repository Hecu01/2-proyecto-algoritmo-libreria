using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Libreria
{
    public class Usuario
    {
        int id; //identificador general
        public string nombre { get; set; }

        string email = "@correr.com";
        public Usuario(string name, string correo, int id)
        {
            this.nombre = name;
            this.email = correo;
            this.id = id;
        }

       

    }
}
