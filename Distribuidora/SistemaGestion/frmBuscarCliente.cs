using SistemaGestion.BLL.Services;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.UI
{
    public partial class frmBuscarCliente : Form
    {
        private readonly ClienteServices _serviciosCliente = new ClienteServices();

        public Cliente? ClienteSeleccionado { get; private set; }

        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes(string.Empty);
        }

        private void CargarClientes(string filtro)
        {
            try
            {
                var lista = _serviciosCliente.BuscarPorNombre(filtro);
                dgvClientes.DataSource = lista;
                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            if (dgvClientes.Columns.Count == 0) return;

            dgvClientes.Columns["IdCliente"].HeaderText     = "ID";
            dgvClientes.Columns["IdCliente"].Width          = 45;
            dgvClientes.Columns["NombreCliente"].HeaderText = "Nombre";
            dgvClientes.Columns["NombreCliente"].Width      = 180;
            dgvClientes.Columns["Telefono"].HeaderText      = "Teléfono";
            dgvClientes.Columns["Telefono"].Width           = 100;
            dgvClientes.Columns["Email"].HeaderText         = "Email";
            dgvClientes.Columns["Email"].Width              = 160;
            dgvClientes.Columns["Direccion"].HeaderText     = "Dirección";
            dgvClientes.Columns["Direccion"].Width          = 160;
            dgvClientes.Columns["Activo"].Visible           = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarClientes(txtBuscar.Text.Trim());
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CargarClientes(txtBuscar.Text.Trim());
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ClienteSeleccionado = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
