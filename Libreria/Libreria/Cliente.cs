using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Libreria
{
    public class Cliente
    {
        int id; //identificador general
        string nombre = "";
        string email = "@correr.com";
        public Cliente(string name, string correo, int id)
        {
            this.nombre = name;
            this.email = correo;
            this.id = id;
        }
    }
}
