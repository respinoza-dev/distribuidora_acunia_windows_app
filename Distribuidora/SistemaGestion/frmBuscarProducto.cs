using SistemaGestion.BLL.Services;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.UI
{
    public partial class frmBuscarProducto : Form
    {
        private readonly ProductoServices _serviciosProductos = new ProductoServices();

        public Producto? ProductoSeleccionado { get; private set; }

        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            CargarProductos(string.Empty);
        }

        private void CargarProductos(string filtro)
        {
            try
            {
                var lista = _serviciosProductos.BuscarPorNombre(filtro);
                dgvProductos.DataSource = lista;
                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            if (dgvProductos.Columns.Count == 0) return;

            dgvProductos.Columns["Id"].HeaderText = "ID";
            dgvProductos.Columns["Id"].Width = 50;
            dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
            dgvProductos.Columns["Nombre"].Width = 160;
            dgvProductos.Columns["Marca"].HeaderText = "Marca";
            dgvProductos.Columns["Marca"].Width = 100;
            dgvProductos.Columns["Modelo"].HeaderText = "Modelo";
            dgvProductos.Columns["Modelo"].Width = 100;
            dgvProductos.Columns["Precio"].HeaderText = "Precio";
            dgvProductos.Columns["Precio"].Width = 80;
            dgvProductos.Columns["StockDisponible"].HeaderText = "Stock";
            dgvProductos.Columns["StockDisponible"].Width = 60;
            dgvProductos.Columns["Descripcion"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CargarProductos(txtBuscar.Text.Trim());
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ProductoSeleccionado = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
