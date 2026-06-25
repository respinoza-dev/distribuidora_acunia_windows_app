using SistemaGestion.DAL.Entities;
using SistemaGestion.UI;

namespace SistemaGestion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            //Maximixar el pnControlContainer
            pnControlContainer.Dock = DockStyle.Fill;
        }

        //private void tsmiProductos_Click(object sender, EventArgs e)
        //{
        //    //Crea una instancia del frmProducto del proyecto
        //    frmProducto frmCatalogoProducto = new frmProducto();
        //    frmCatalogoProducto.MdiParent = this;
        //    frmCatalogoProducto.Show();

        //    tsmiProductos.Enabled = false;
        //}

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void tsmiCategorias_Click(object sender, EventArgs e)
        {
            //Llamar al UserControl Categorias
            pnControlContainer.Controls.Clear();

            uctrlCategorias Categorias = new uctrlCategorias();
            Categorias.Dock = DockStyle.Fill;
            pnControlContainer.Controls.Add(Categorias);
            Categorias.BringToFront();
        }

        private void tmsiProveedores_Click(object sender, EventArgs e)
        {
            //Llamar al UserControl Categorias
            pnControlContainer.Controls.Clear();

            uctrlProveedores proveedores = new uctrlProveedores();
            proveedores.Dock = DockStyle.Fill;
            pnControlContainer.Controls.Add(proveedores);
            proveedores.BringToFront();

        }

        private void tmsiMarca_Click(object sender, EventArgs e)
        {
            //Llamar al UserControl Categorias
            pnControlContainer.Controls.Clear();

            uctrlMarca Marca = new uctrlMarca();
            Marca.Dock = DockStyle.Fill;
            pnControlContainer.Controls.Add(Marca);
            Marca.BringToFront();

        }

        private void tmsiProducto_Click(object sender, EventArgs e)
        {
            //Llamar al UserControl Productos
            pnControlContainer.Controls.Clear();

            uctrlProductos productos = new uctrlProductos();
            productos.Dock = DockStyle.Fill;
            pnControlContainer.Controls.Add(productos);
            productos.BringToFront();
        }

        private void tsmiVentas_Click(object sender, EventArgs e)
        {

            //Llamar al UserControl Productos
            pnControlContainer.Controls.Clear();

            uctrlventa venta = new uctrlventa();
            venta.Dock = DockStyle.Fill;
            pnControlContainer.Controls.Add(venta);
            venta.BringToFront();
        }
    }
}
