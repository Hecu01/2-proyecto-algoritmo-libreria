using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Libreria;

namespace Libreria
{
    public partial class Form1 : Form
    {
        public List<Articulo>  articulos;
        public List<Compra> compras;
        public List<Venta> ventas;
        public List<Cliente> clientes;
        public List<Proveedor> proveedores;
        public List<Usuario> usuarios;

        public Form1()
        {
            InitializeComponent();

            usuarios = new List<Usuario>();
            usuarios.Add(new Usuario("Luis", "luis@hotmail", 0));
            usuarios.Add(new Usuario("Pepe", "ppee@hotmail", 1));
            articulos = new List<Articulo>();
            articulos.Add(new Articulo(0, "Lapiz", "Lapiz Negro", 10, 50, "Sylvapen"));
            compras = new List<Compra>();
            //compras[0] = Compra()
            ventas = new List<Venta>();
            clientes = new List<Cliente>();
            clientes.Add(new Cliente("Isft 38", "cor@isf38", 0));
            proveedores = new List<Proveedor>();
            proveedores.Add(new Proveedor("LK", "corr@corrre", 0));

            for (int i = 0; i < usuarios.Count; i++)
            {
                cbUsuario.Items.Insert(i, usuarios[i].nombre);         
            }
            cbUsuario.SelectedIndex = 0;

            this.llenar_cbo_articulos();
        }

        private void btArticulo_Click(object sender, EventArgs e)
        {
            Articulo art;
            bool is_valid_cantidad,is_valid_precio;
            int cantidad = 0;
            double precio = 0;
            is_valid_cantidad = int.TryParse(tbArticuloCantidad.Text, out cantidad);
            is_valid_precio = double.TryParse(tbPrecio.Text, out precio);
            if (is_valid_cantidad && is_valid_precio && precio > 0 && cantidad >= 0)
            {
                art = new Articulo(articulos.Count + 1,
                    tbArticulo.Text, 
                    tbArtDescripcion.Text, cantidad, 
                    precio, tbMarca.Text);
                articulos.Add(art);
                llenar_cbo_articulos();
            }
        }

        private void llenar_cbo_articulos()
        {
            
            cbArticulos.Items.Clear();
            for (int i = 0; i < articulos.Count; i++)
            {
                cbArticulos.Items.Insert(i, articulos[i].nombre + "-" + articulos[i].Marca);
            }
            cbArticulos.SelectedIndex = 0;
        
        }

        private void llenar_informacion_articulo(int indice)
        {
            if (this.articulos[indice] != null)
            {
                this.tbArticulo.Text = articulos[indice].nombre;
                this.tbArtDescripcion.Text = articulos[indice].descripcion;
                this.tbArticuloCantidad.Text = articulos[indice].cantidad.ToString();
                this.tbPrecio.Text = articulos[indice].precio_x_unidad.ToString();
                this.tbMarca.Text = articulos[indice].Marca;
            }
            else
            { 
                //Mensajes Error
            }
        }

        private void cbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_informacion_articulo(cbArticulos.SelectedIndex);
        }



    }
}
