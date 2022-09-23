using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Libreria_Archivos
{
    public class ManejoArchivos
    {

        private string txtarchivoArticulos = "C:\\Articulos.txt";
        private string txtarchivoClientes = "C:\\Clientes.txt";
        private string txtarchivoProveedores = "C:\\Proveedores.txt";
        private string txtarchivoCompras = "C:\\Compras.txt";
        private string txtarchivoVentas = "C:\\Ventas.txt";

        private StreamReader readerArticulos;
        private StreamReader readerClientes;
        private StreamReader readerProveedores;
        private StreamReader readerCompras;
        private StreamReader readerVentas;

        private StreamWriter writerArticulos;
        private StreamWriter writerClientes;
        private StreamWriter writerProveedores;
        private StreamWriter writerCompras;
        private StreamWriter writerVentas;

        public ManejoArchivos(string Articulos, string Clientes, string Proveedores, string Compras, string Ventas) {
            this.txtarchivoArticulos = Articulos;
            this.txtarchivoClientes = Clientes;
            this.txtarchivoProveedores = Proveedores;
            this.txtarchivoCompras = Compras;
            this.txtarchivoVentas = Ventas;


            writerArticulos = new StreamWriter(this.txtarchivoArticulos);
            writerArticulos.Close();

            writerClientes = new StreamWriter(this.txtarchivoClientes);
            writerClientes.Close();

            writerProveedores = new StreamWriter(this.txtarchivoProveedores);
            writerProveedores.Close();

            writerCompras = new StreamWriter(this.txtarchivoCompras);
            writerCompras.Close();

            writerVentas = new StreamWriter(this.txtarchivoVentas);
            writerVentas.Close();
        }


        public bool Grabar_Clientes(List<string> listaClientes)
        {
            writerClientes = new StreamWriter(this.txtarchivoClientes);
            for (int i = 0; i < listaClientes.Count; i++)
            {
                writerClientes.WriteLine(listaClientes[i]);
            }
            writerClientes.Close();
            return true;
        }

        public bool Grabar_Proveedores(List<string> listaProveedores)
        {
            writerProveedores = new StreamWriter(this.txtarchivoProveedores);
            for (int i = 0; i < listaProveedores.Count; i++)
            {
                writerArticulos.WriteLine(listaProveedores[i]);
            }
            writerProveedores.Close();
            return true;
        }

        public bool Grabar_Articulos(List<string> listaArticulos)
        {
            writerArticulos = new StreamWriter(this.txtarchivoArticulos);
            for (int i = 0; i < listaArticulos.Count; i++)
            {
                writerArticulos.WriteLine(listaArticulos[i]);
            }
            writerArticulos.Close();
            return true;        
        }

        public List<string> Leer_Clientes(){

            List<string> listaClientes = new List<string>();
            string texto;
            readerClientes = new StreamReader(this.txtarchivoClientes);
            texto = readerClientes.ReadLine();
            while (texto != null)
            {
                listaClientes.Add(texto);
                texto = readerClientes.ReadLine();
            }
            readerClientes.Close();
            return listaClientes;        
        }

        public List<string> Leer_Proveedores()
        {
            List<string> listaProveedores = new List<string>();
            string texto;
            readerProveedores = new StreamReader(this.txtarchivoProveedores);
            texto = readerProveedores.ReadLine();
            while (texto != null)
            {
                listaProveedores.Add(texto);
                texto = readerProveedores.ReadLine();
            }
            readerProveedores.Close();
            return listaProveedores;        
        }

        public List<string> Leer_Articulos()
        {
            List<string> listaArticulos = new List<string>();
            string texto;
            readerArticulos = new StreamReader(this.txtarchivoArticulos);
            texto = readerArticulos.ReadLine();
            while (texto != null)
            {
                listaArticulos.Add(texto);
                texto = readerArticulos.ReadLine();
            }
            readerArticulos.Close();
            return listaArticulos;        
        }
    }
}
