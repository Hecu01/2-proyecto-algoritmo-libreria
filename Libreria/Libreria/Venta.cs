using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Libreria
{
    public class Venta
    {
        int id;
        Usuario usuario;
        Cliente cliente;
        List<Articulo> articulos;
        double precio_total;
        DateTime fechaVenta;
        DateTime fechaEntrega;

        public Venta(int id, Usuario user, Cliente cliente, List<Articulo> artics, double precio)
        {
            this.id = id;
            this.usuario = user;
            this.cliente = cliente;
            this.articulos = artics;
            this.precio_total = precio;
            this.fechaVenta = new DateTime();
            this.fechaEntrega = new DateTime();
        }
    }
}
