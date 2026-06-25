using SistemaGestion.BLL.Services;
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

namespace SistemaGestion.UI
{
    public partial class uctrlProductos : UserControl
    {
        // creamos las instancias de los servicios
        CategoryServices _serviciosCategorias = new CategoryServices();
        SupplierServices _serviciosProveedor = new SupplierServices();

        // creando una lista de tipo producto para almacenar los productos que se van a agregar
        List<Producto> ListaProductosTemp = new List<Producto>();

        // para cuando registremos (lista oficial)
        List<Producto> ListaProductos = new List<Producto>();

        // crear instancia de productservices
        ProductService _serviciosProductos = new ProductService();
        public uctrlProductos()
        {
            InitializeComponent();
        }

        private void uctrlProductos_Load(object sender, EventArgs e)
        {
            CargarComboBoxs();
        }

        private void CargarComboBoxs()
        {
            // cargar el cbCategoria
            cbCategoria.DataSource = _serviciosCategorias.ObtenerCategoriasActivas();
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.ValueMember = "IdCategoria";

            // cargar el cbProveedor
            //cbProveedor.DataSource = _serviciosProveedor.ObtenerProveedoresActivos();
            //cbProveedor.DisplayMember = "NombreCompania";
            //cbProveedor.ValueMember = "IdProveedor";
        }

        private void grbDatosProductos_Enter(object sender, EventArgs e)
        {

        }
    }
}
