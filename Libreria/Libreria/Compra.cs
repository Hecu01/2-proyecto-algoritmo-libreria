using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Libreria
{
    public class Compra
    {
        int id;
        Usuario usuario;
        Proveedor proveedor;
        Articulo[] articulos;
        double precio_total;
        DateTime fechaCompra;
        DateTime fechaEntrega;

        public Compra(int id, Usuario user, Proveedor prov, Articulo[] artics, double precio)
        {
            this.id = id;
            this.usuario = user;
            this.proveedor = prov;
            this.articulos = artics;
            this.precio_total = precio;
            this.fechaCompra = new DateTime();
            this.fechaEntrega = new DateTime();
        }
        
    }
}
