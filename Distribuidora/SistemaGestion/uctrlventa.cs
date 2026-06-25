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
    public partial class uctrlventa : UserControl
    {
        private readonly MetodoPagoServices _serviciosMetodoPago = new MetodoPagoServices();
        private readonly ClienteServices    _serviciosCliente    = new ClienteServices();
        private readonly UsuarioServices    _serviciosUsuario    = new UsuarioServices();

        private readonly DataTable _dtDetalle       = new DataTable();
        private          int       _rowEditandoIndex = -1;

        public uctrlventa()
        {
            InitializeComponent();
        }

        private void uctrlventa_Load(object sender, EventArgs e)
        {
            CargarComboBoxs();
            ConfigurarGrilla();
            CargarUsuario();
        }

        // ── Carga inicial ────────────────────────────────────────────────────

        private void CargarComboBoxs()
        {
            try
            {
                cbMetodoPago.DataSource    = _serviciosMetodoPago.ObtenerLista();
                cbMetodoPago.DisplayMember = "NombreMetodo";
                cbMetodoPago.ValueMember   = "IdMetodoPago";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar método de pago: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuario()
        {
            try
            {
                var usuario = _serviciosUsuario.ObtenerPrimero();
                if (usuario != null)
                {
                    txtUsuario.Text     = usuario.NombreUsuario;
                    txtUsuario.ReadOnly = true;
                }
                else
                {
                    txtUsuario.Text     = "Sin usuario";
                    txtUsuario.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrilla()
        {
            _dtDetalle.Columns.Add("Producto",      typeof(string));
            _dtDetalle.Columns.Add("Cantidad",      typeof(int));
            _dtDetalle.Columns.Add("P. Unitario",   typeof(decimal));
            _dtDetalle.Columns.Add("Descuento",     typeof(decimal));
            _dtDetalle.Columns.Add("Subtotal",      typeof(decimal));

            dgvDatos.DataSource          = _dtDetalle;
            dgvDatos.AllowUserToAddRows  = false;
            dgvDatos.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;

            dgvDatos.Columns["Producto"].Width    = 240;
            dgvDatos.Columns["Cantidad"].Width    = 70;
            dgvDatos.Columns["P. Unitario"].Width = 100;
            dgvDatos.Columns["Descuento"].Width   = 90;
            dgvDatos.Columns["Subtotal"].Width    = 100;

            string fmt = "N2";
            dgvDatos.Columns["P. Unitario"].DefaultCellStyle.Format  = fmt;
            dgvDatos.Columns["Descuento"].DefaultCellStyle.Format    = fmt;
            dgvDatos.Columns["Subtotal"].DefaultCellStyle.Format     = fmt;

            dgvDatos.Columns["P. Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Descuento"].DefaultCellStyle.Alignment   = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Subtotal"].DefaultCellStyle.Alignment    = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Alignment    = DataGridViewContentAlignment.MiddleCenter;
        }

        // ── Botón Agregar ────────────────────────────────────────────────────

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposDetalle(out int cantidad, out decimal precioUnitario, out decimal descuento))
                return;

            decimal subtotal = Math.Max((cantidad * precioUnitario) - descuento, 0);

            if (_rowEditandoIndex >= 0)
            {
                // ── Modo edición: actualiza la fila existente ──────────────
                DataRow row         = _dtDetalle.Rows[_rowEditandoIndex];
                row["Producto"]     = txtProduct.Text.Trim();
                row["Cantidad"]     = cantidad;
                row["P. Unitario"]  = precioUnitario;
                row["Descuento"]    = descuento;
                row["Subtotal"]     = subtotal;

                dgvDatos.Rows[_rowEditandoIndex].DefaultCellStyle.BackColor = Color.Empty;
                _rowEditandoIndex = -1;
                btnAgregar.Text   = "Agregar";
            }
            else
            {
                _dtDetalle.Rows.Add(txtProduct.Text.Trim(), cantidad, precioUnitario, descuento, subtotal);
            }

            ActualizarSubtotal();
            LimpiarCamposDetalle();
        }

        private bool ValidarCamposDetalle(out int cantidad, out decimal precioUnitario, out decimal descuento)
        {
            cantidad       = 0;
            precioUnitario = 0;
            descuento      = 0;

            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("Debe seleccionar un producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Clear();
                txtCantidad.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text.Trim(),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out precioUnitario) || precioUnitario <= 0)
            {
                MessageBox.Show("El precio unitario no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                if (!decimal.TryParse(txtDescuento.Text.Trim(),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out descuento) || descuento < 0)
                {
                    MessageBox.Show("El descuento debe ser un número mayor o igual a cero.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescuento.Focus();
                    return false;
                }

                if (descuento >= cantidad * precioUnitario)
                {
                    MessageBox.Show("El descuento no puede ser mayor o igual al total del ítem.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescuento.Focus();
                    return false;
                }
            }

            return true;
        }

        // ── Botón Editar ─────────────────────────────────────────────────────

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow == null || dgvDatos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un registro para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_rowEditandoIndex >= 0)
            {
                MessageBox.Show("Termine la edición actual antes de editar otro registro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int     index = dgvDatos.CurrentRow.Index;
            DataRow row   = _dtDetalle.Rows[index];

            txtProduct.Text        = row["Producto"].ToString()!;
            txtCantidad.Text       = row["Cantidad"].ToString()!;
            txtPrecioUnitario.Text = Convert.ToDecimal(row["P. Unitario"])
                                        .ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            decimal desc           = Convert.ToDecimal(row["Descuento"]);
            txtDescuento.Text      = desc > 0
                                        ? desc.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                                        : string.Empty;

            _rowEditandoIndex = index;
            dgvDatos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;

            btnAgregar.Text = "Actualizar";
            txtCantidad.Focus();
        }

        // ── Botón Eliminar ───────────────────────────────────────────────────

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_rowEditandoIndex >= 0)
            {
                MessageBox.Show("Cancele la edición actual antes de eliminar un registro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvDatos.CurrentRow == null || dgvDatos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string producto = dgvDatos.CurrentRow.Cells["Producto"].Value?.ToString() ?? "el registro";
            var confirm = MessageBox.Show(
                $"¿Desea eliminar '{producto}' de la lista?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _dtDetalle.Rows.RemoveAt(dgvDatos.CurrentRow.Index);
                ActualizarSubtotal();
            }
        }

        // ── Botón Cancelar ───────────────────────────────────────────────────

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_rowEditandoIndex >= 0)
            {
                dgvDatos.Rows[_rowEditandoIndex].DefaultCellStyle.BackColor = Color.Empty;
                _rowEditandoIndex = -1;
                btnAgregar.Text   = "Agregar";
            }

            LimpiarCamposDetalle();
        }

        // ── Subtotal footer ──────────────────────────────────────────────────

        private void ActualizarSubtotal()
        {
            decimal total = 0;
            foreach (DataRow row in _dtDetalle.Rows)
                total += row.Field<decimal>("Subtotal");

            lblSubtotal.Text = $"Subtotal:  $ {total:N2}";
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        private void LimpiarCamposDetalle()
        {
            txtProduct.Text        = string.Empty;
            txtCantidad.Text       = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            txtDescuento.Text      = string.Empty;
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e) { }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            using (var frm = new frmBuscarProducto())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.ProductoSeleccionado != null)
                {
                    Producto p = frm.ProductoSeleccionado;
                    txtProduct.Text        = $"{p.Nombre} - {p.Marca} ({p.Modelo})";
                    txtPrecioUnitario.Text = p.Precio.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var frm = new frmBuscarCliente())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.ClienteSeleccionado != null)
                {
                    txtCliente.Text = frm.ClienteSeleccionado.NombreCliente;
                }
            }
        }

        private void lblProduct_Click(object sender, EventArgs e) { }
    }
}

