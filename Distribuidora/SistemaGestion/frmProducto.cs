using SistemaGestion.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaGestion
{
    public partial class frmProducto : Form
    {

        //Definir una Lista de tipo clase Producto
        List<Producto> listaProductos = new List<Producto>();


        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Instancia de la clase Producto
            Producto producto = new Producto();

            producto.Nombre = txtNombreProducto.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Marca = cbMarca.Text.ToString();
            producto.Modelo = cbCategoria.Text.ToString();
            producto.Precio = Convert.ToDouble(txtPrecioDetalle.Text);
            producto.StockDisponible = Convert.ToInt32(txtStockDisponible.Text);

            //Agregar el producto a la ListaProductos
            listaProductos.Add(producto);

            //Agregar el nuevo Producto a la DataGridView

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaProductos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}

