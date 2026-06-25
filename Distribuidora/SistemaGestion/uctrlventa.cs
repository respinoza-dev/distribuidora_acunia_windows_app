using SistemaGestion.BLL.Services;
using SistemaGestion.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestion.UI
{
    public partial class uctrlventa : UserControl
    {
        // ── servicios ────────────────────────────────────────────────────────────
        private readonly VentaServices      _serviciosVenta      = new VentaServices();
        private readonly MetodoPagoServices _serviciosMetodoPago = new MetodoPagoServices();
        private readonly UsuarioServices    _serviciosUsuario    = new UsuarioServices();

        // ── estado de la grilla de detalle ───────────────────────────────────────
        private readonly DataTable _dtDetalle        = new DataTable();
        private          int       _rowEditandoIndex = -1;

        // ── estado de la venta en edición ────────────────────────────────────────
        private int _idVentaEditando = 0;   // 0 = nueva venta
        private int _idClienteActual = 0;
        private int _idUsuarioActual = 0;

        // ── producto seleccionado en la línea de detalle ─────────────────────────
        private int _idProductoDetalle = 0;

        // ════════════════════════════════════════════════════════════════════════
        //  CONSTRUCTOR
        // ════════════════════════════════════════════════════════════════════════
        public uctrlventa()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  CARGA DEL CONTROL
        // ════════════════════════════════════════════════════════════════════════
        private void uctrlventa_Load(object sender, EventArgs e)
        {
            CargarComboBoxs();
            ConfigurarGrillaDetalle();
            CargarUsuario();
        }

        // ── combos ───────────────────────────────────────────────────────────────
        private void CargarComboBoxs()
        {
            try
            {
                cbMetodoPago.DataSource    = _serviciosMetodoPago.ObtenerLista();
                cbMetodoPago.DisplayMember = "NombreMetodo";
                cbMetodoPago.ValueMember   = "IdMetodoPago";

                cmbTipoVenta.Items.Clear();
                cmbTipoVenta.Items.AddRange(new object[] { "Detalle", "Mayor" });
                if (cmbTipoVenta.SelectedIndex < 0)
                    cmbTipoVenta.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar combos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── usuario ──────────────────────────────────────────────────────────────
        private void CargarUsuario()
        {
            try
            {
                var usuario = _serviciosUsuario.ObtenerPrimero();
                if (usuario != null)
                {
                    txtUsuario.Text     = usuario.NombreUsuario;
                    _idUsuarioActual    = usuario.IdUsuario;
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

        // ── grilla de detalle ────────────────────────────────────────────────────
        private void ConfigurarGrillaDetalle()
        {
            _dtDetalle.Columns.Add("IdProducto",  typeof(int));
            _dtDetalle.Columns.Add("Producto",    typeof(string));
            _dtDetalle.Columns.Add("Cantidad",    typeof(int));
            _dtDetalle.Columns.Add("P. Unitario", typeof(decimal));
            _dtDetalle.Columns.Add("Descuento",   typeof(decimal));
            _dtDetalle.Columns.Add("Subtotal",    typeof(decimal));

            dgvDatos.DataSource         = _dtDetalle;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

            dgvDatos.Columns["IdProducto"].Visible = false;
            dgvDatos.Columns["Producto"].Width      = 240;
            dgvDatos.Columns["Cantidad"].Width      = 70;
            dgvDatos.Columns["P. Unitario"].Width   = 100;
            dgvDatos.Columns["Descuento"].Width     = 90;
            dgvDatos.Columns["Subtotal"].Width      = 100;

            const string fmt = "N2";
            dgvDatos.Columns["P. Unitario"].DefaultCellStyle.Format    = fmt;
            dgvDatos.Columns["Descuento"].DefaultCellStyle.Format      = fmt;
            dgvDatos.Columns["Subtotal"].DefaultCellStyle.Format       = fmt;
            dgvDatos.Columns["P. Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Descuento"].DefaultCellStyle.Alignment   = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Subtotal"].DefaultCellStyle.Alignment    = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Alignment    = DataGridViewContentAlignment.MiddleCenter;
        }

        // ════════════════════════════════════════════════════════════════════════
        //  CAMBIO DE PESTAÑA
        // ════════════════════════════════════════════════════════════════════════
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabHistorial)
            {
                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today;
                CargarVentas();
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  TAB NUEVA VENTA
        // ════════════════════════════════════════════════════════════════════════

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var frm = new frmBuscarCliente())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.ClienteSeleccionado != null)
                {
                    txtCliente.Text  = frm.ClienteSeleccionado.NombreCliente;
                    _idClienteActual = frm.ClienteSeleccionado.IdCliente;
                }
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            using (var frm = new frmBuscarProducto())
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.ProductoSeleccionado != null)
                {
                    Producto p = frm.ProductoSeleccionado;
                    txtProduct.Text        = $"{p.Nombre} - {p.Marca} ({p.Modelo})";
                    txtPrecioUnitario.Text = p.Precio.ToString("F2",
                        System.Globalization.CultureInfo.InvariantCulture);
                    _idProductoDetalle = p.Id;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposDetalle(out int cantidad, out decimal precioUnitario, out decimal descuento))
                return;

            decimal subtotal = Math.Max((cantidad * precioUnitario) - descuento, 0);

            if (_rowEditandoIndex >= 0)
            {
                DataRow row        = _dtDetalle.Rows[_rowEditandoIndex];
                row["IdProducto"]  = _idProductoDetalle;
                row["Producto"]    = txtProduct.Text.Trim();
                row["Cantidad"]    = cantidad;
                row["P. Unitario"] = precioUnitario;
                row["Descuento"]   = descuento;
                row["Subtotal"]    = subtotal;

                dgvDatos.Rows[_rowEditandoIndex].DefaultCellStyle.BackColor = Color.Empty;
                _rowEditandoIndex = -1;
                btnAgregar.Text   = "Agregar";
            }
            else
            {
                _dtDetalle.Rows.Add(_idProductoDetalle, txtProduct.Text.Trim(),
                    cantidad, precioUnitario, descuento, subtotal);
            }

            ActualizarSubtotal();
            LimpiarCamposDetalle();
        }

        private bool ValidarCamposDetalle(out int cantidad, out decimal precioUnitario, out decimal descuento)
        {
            cantidad       = 0;
            precioUnitario = 0;
            descuento      = 0;

            if (string.IsNullOrWhiteSpace(txtProduct.Text) || _idProductoDetalle == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Distribuidora Acuña",
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
                MessageBox.Show("El precio unitario no es válido.", "Distribuidora Acuña",
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
                    MessageBox.Show("El descuento debe ser un número mayor o igual a cero.", "Distribuidora Acuña",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescuento.Focus();
                    return false;
                }

                if (descuento >= cantidad * precioUnitario)
                {
                    MessageBox.Show("El descuento no puede ser mayor o igual al total del ítem.", "Distribuidora Acuña",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescuento.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow == null || dgvDatos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un registro para editar.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_rowEditandoIndex >= 0)
            {
                MessageBox.Show("Termine la edición actual antes de editar otro registro.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int     index = dgvDatos.CurrentRow.Index;
            DataRow row   = _dtDetalle.Rows[index];

            _idProductoDetalle     = Convert.ToInt32(row["IdProducto"]);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_rowEditandoIndex >= 0)
            {
                MessageBox.Show("Cancele la edición actual antes de eliminar un registro.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvDatos.CurrentRow == null || dgvDatos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string producto = dgvDatos.CurrentRow.Cells["Producto"].Value?.ToString() ?? "el registro";
            if (MessageBox.Show($"¿Desea eliminar '{producto}' de la lista?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _dtDetalle.Rows.RemoveAt(dgvDatos.CurrentRow.Index);
                ActualizarSubtotal();
            }
        }

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCabeceraVenta()) return;

            if (_dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto al detalle.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Venta venta = new Venta
                {
                    IdVenta       = _idVentaEditando,
                    IdCliente     = _idClienteActual,
                    IdUsuario     = _idUsuarioActual,
                    IdMetodoPago  = (int)cbMetodoPago.SelectedValue!,
                    TipoVenta     = cmbTipoVenta.SelectedItem?.ToString() ?? "Detalle",
                    EstadoVenta   = "Activo",
                    FechaVenta    = DateTime.Now,
                    Observaciones = txtObservacion.Text.Trim()
                };

                List<DetalleVenta> detalles = ObtenerDetallesDeGrilla();

                if (_idVentaEditando == 0)
                {
                    _serviciosVenta.GuardarVenta(venta, detalles);
                    MessageBox.Show("Venta registrada correctamente.", "Distribuidora Acuña",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _serviciosVenta.ActualizarVenta(venta, detalles);
                    MessageBox.Show("Venta actualizada correctamente.", "Distribuidora Acuña",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar venta: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  TAB HISTORIAL
        // ════════════════════════════════════════════════════════════════════════

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            try
            {
                var lista = _serviciosVenta.ObtenerPorFecha(dtpDesde.Value, dtpHasta.Value);
                dgvVentas.DataSource = null;
                dgvVentas.DataSource = lista;
                ConfigurarColumnasVentas();
                dgvDetalleVenta.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasVentas()
        {
            if (dgvVentas.Columns.Count == 0) return;

            foreach (DataGridViewColumn col in dgvVentas.Columns)
                col.Visible = false;

            string[] visibles = { "IdVenta", "NombreCliente", "NombreUsuario",
                                   "NombreMetodoPago", "TipoVenta", "EstadoVenta",
                                   "FechaVenta", "Total" };
            string[] headers  = { "ID", "Cliente", "Usuario",
                                   "Método Pago", "Tipo", "Estado",
                                   "Fecha", "Total" };
            int[]    widths   = { 50, 180, 120, 120, 80, 80, 130, 90 };

            for (int i = 0; i < visibles.Length; i++)
            {
                if (dgvVentas.Columns[visibles[i]] != null)
                {
                    dgvVentas.Columns[visibles[i]].Visible    = true;
                    dgvVentas.Columns[visibles[i]].HeaderText = headers[i];
                    dgvVentas.Columns[visibles[i]].Width      = widths[i];
                }
            }

            if (dgvVentas.Columns["Total"] != null)
                dgvVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
            if (dgvVentas.Columns["FechaVenta"] != null)
                dgvVentas.Columns["FechaVenta"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null) return;

            var venta = dgvVentas.CurrentRow.DataBoundItem as Venta;
            if (venta == null) return;

            try
            {
                var detalles = _serviciosVenta.ObtenerDetallesPorVenta(venta.IdVenta);
                dgvDetalleVenta.DataSource = null;
                dgvDetalleVenta.DataSource = detalles;
                ConfigurarColumnasDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalle: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasDetalle()
        {
            if (dgvDetalleVenta.Columns.Count == 0) return;

            foreach (DataGridViewColumn col in dgvDetalleVenta.Columns)
                col.Visible = false;

            string[] visibles = { "NombreProducto", "CantidadVendida",
                                   "PrecioUnitario", "Descuento", "Subtotal" };
            string[] headers  = { "Producto", "Cantidad",
                                   "P. Unitario", "Descuento", "Subtotal" };
            int[]    widths   = { 260, 80, 110, 90, 110 };
            string[] formats  = { "", "", "N2", "N2", "N2" };

            for (int i = 0; i < visibles.Length; i++)
            {
                if (dgvDetalleVenta.Columns[visibles[i]] != null)
                {
                    dgvDetalleVenta.Columns[visibles[i]].Visible    = true;
                    dgvDetalleVenta.Columns[visibles[i]].HeaderText = headers[i];
                    dgvDetalleVenta.Columns[visibles[i]].Width      = widths[i];
                    if (!string.IsNullOrEmpty(formats[i]))
                        dgvDetalleVenta.Columns[visibles[i]].DefaultCellStyle.Format = formats[i];
                }
            }
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para editar.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = dgvVentas.CurrentRow.DataBoundItem as Venta;
            if (venta == null) return;

            CargarVentaParaEditar(venta.IdVenta);
            tabControl.SelectedTab = tabNuevaVenta;
        }

        private void CargarVentaParaEditar(int idVenta)
        {
            try
            {
                Venta? v = _serviciosVenta.ObtenerPorId(idVenta);
                if (v == null)
                {
                    MessageBox.Show("No se encontró la venta.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LimpiarFormulario();
                _idVentaEditando = idVenta;
                _idClienteActual = v.IdCliente;
                txtCliente.Text     = v.NombreCliente;
                txtObservacion.Text = v.Observaciones;

                // Seleccionar método de pago
                foreach (var item in cbMetodoPago.Items)
                {
                    if (item is MetodoPago mp && mp.IdMetodoPago == v.IdMetodoPago)
                    {
                        cbMetodoPago.SelectedItem = item;
                        break;
                    }
                }

                // Seleccionar tipo de venta
                int idx = cmbTipoVenta.Items.IndexOf(v.TipoVenta);
                if (idx >= 0) cmbTipoVenta.SelectedIndex = idx;

                // Cargar líneas de detalle
                var detalles = _serviciosVenta.ObtenerDetallesPorVenta(idVenta);
                foreach (var d in detalles)
                    _dtDetalle.Rows.Add(d.IdProducto, d.NombreProducto,
                        d.CantidadVendida, d.PrecioUnitario, d.Descuento, d.Subtotal);

                ActualizarSubtotal();
                btnRegistrar.Text = "Actualizar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar venta: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para eliminar.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = dgvVentas.CurrentRow.DataBoundItem as Venta;
            if (venta == null) return;

            if (MessageBox.Show(
                    $"¿Eliminar la venta #{venta.IdVenta} de {venta.NombreCliente}?\n" +
                    "Se restaurará el stock de los productos.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                _serviciosVenta.EliminarVenta(venta.IdVenta);
                MessageBox.Show("Venta eliminada y stock restaurado.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar venta: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  HELPERS
        // ════════════════════════════════════════════════════════════════════════

        private bool ValidarCabeceraVenta()
        {
            if (_idClienteActual == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_idUsuarioActual == 0)
            {
                MessageBox.Show("No se pudo obtener el usuario actual.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbMetodoPago.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTipoVenta.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar el tipo de venta.", "Distribuidora Acuña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private List<DetalleVenta> ObtenerDetallesDeGrilla()
        {
            var lista = new List<DetalleVenta>();
            foreach (DataRow row in _dtDetalle.Rows)
            {
                lista.Add(new DetalleVenta
                {
                    IdProducto      = Convert.ToInt32(row["IdProducto"]),
                    CantidadVendida = Convert.ToInt32(row["Cantidad"]),
                    PrecioUnitario  = Convert.ToDecimal(row["P. Unitario"]),
                    Descuento       = Convert.ToDecimal(row["Descuento"]),
                    Subtotal        = Convert.ToDecimal(row["Subtotal"])
                });
            }
            return lista;
        }

        private void ActualizarSubtotal()
        {
            decimal total = 0;
            foreach (DataRow row in _dtDetalle.Rows)
                total += row.Field<decimal>("Subtotal");

            lblSubtotal.Text = $"Total:  $ {total:N2}";
        }

        private void LimpiarCamposDetalle()
        {
            txtProduct.Text        = string.Empty;
            txtCantidad.Text       = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            txtDescuento.Text      = string.Empty;
            _idProductoDetalle     = 0;
        }

        private void LimpiarFormulario()
        {
            txtCliente.Text     = string.Empty;
            txtObservacion.Text = string.Empty;
            _idClienteActual    = 0;
            _idVentaEditando    = 0;

            _dtDetalle.Rows.Clear();
            ActualizarSubtotal();
            LimpiarCamposDetalle();

            if (_rowEditandoIndex >= 0)
            {
                _rowEditandoIndex = -1;
                btnAgregar.Text   = "Agregar";
            }

            btnRegistrar.Text = "Registrar";
            CargarComboBoxs();
        }

        // ── stub requerido por el diseñador ──────────────────────────────────────
        private void lblProduct_Click(object sender, EventArgs e) { }
    }
}
