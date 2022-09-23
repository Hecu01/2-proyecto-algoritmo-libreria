using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Archivos
{
    public interface IManejoArchivos
    {
        bool Grabar_Clientes(List<string> clientes);
        bool Grabar_Proveedores(List<string> proveedores);
        bool Grabar_Articulos(List<string> articulos);

        List<string> Leer_Clientes();
        List<string> Leer_Proveedores();
        List<string> Leer_Articulos();




    }
}
