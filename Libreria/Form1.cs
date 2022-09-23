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
        public Articulo[]  articulos;
        public Compra[] compras;
        public Venta[] ventas;
        public Cliente[] clientes;
        public Proveedor[] proveedores;
        public Usuario[] usuarios;

        public Form1()
        {
            InitializeComponent();

            usuarios = new Usuario[2];
            usuarios[0] = new Usuario("Luis", "luis@hotmail", 0);
            usuarios[1] = new Usuario("Pepe", "ppee@hotmail", 1);
            articulos = new Articulo[10];
            articulos[0] = new Articulo(0, "Lapiz", "Lapiz Negro", 10, 50, "Sylvapen");
            compras = new Compra[10];
            //compras[0] = Compra()
            ventas = new Venta[10];
            clientes = new Cliente[10];
            clientes[0] = new Cliente("Isft 38", "cor@isf38", 0);
            proveedores = new Proveedor[10];
            proveedores[0] = new Proveedor("LK", "corr@corrre", 0);

            for (int i = 0; i < usuarios.Length; i++)
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
            if (is_valid_cantidad && is_valid_precio)
            {
                art = new Articulo(0, tbArticulo.Text, tbArtDescripcion.Text, int.Parse(tbArticuloCantidad.Text), 10, tbMarca.Text);
                for (int i = 0; i < articulos.Length; i++)
                {
                    if (articulos[i] == null)
                    {
                        articulos[i] = art;
                        break;
                    }
                }
                llenar_cbo_articulos();
                
            }
        }

        private void llenar_cbo_articulos()
        {
            cbArticulos.Items.Clear();
            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i] != null)
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
