namespace SistemaGestion.UI
{
    partial class uctrlventa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Codigo generado por el Disenador de componentes

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlventa));
            tabControl = new TabControl();
            tabNuevaVenta = new TabPage();
            grbEncabezado = new GroupBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            cbMetodoPago = new ComboBox();
            label6 = new Label();
            cmbTipoVenta = new ComboBox();
            label1 = new Label();
            txtCliente = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            txtObservacion = new TextBox();
            grbDetalle = new GroupBox();
            lblProduct = new Label();
            txtProduct = new TextBox();
            btnSearchProduct = new Button();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblPrecioUnitario = new Label();
            txtPrecioUnitario = new TextBox();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            dgvDatos = new DataGridView();
            lblSubtotal = new Label();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            tabHistorial = new TabPage();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            btnFiltrar = new Button();
            dgvVentas = new DataGridView();
            lblDetalleVenta = new Label();
            dgvDetalleVenta = new DataGridView();
            btnEditarVenta = new Button();
            btnEliminarVenta = new Button();
            tabControl.SuspendLayout();
            tabNuevaVenta.SuspendLayout();
            grbEncabezado.SuspendLayout();
            grbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabNuevaVenta);
            tabControl.Controls.Add(tabHistorial);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(915, 620);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabNuevaVenta
            // 
            tabNuevaVenta.Controls.Add(grbEncabezado);
            tabNuevaVenta.Controls.Add(grbDetalle);
            tabNuevaVenta.Controls.Add(btnAgregar);
            tabNuevaVenta.Controls.Add(btnEditar);
            tabNuevaVenta.Controls.Add(btnCancelar);
            tabNuevaVenta.Controls.Add(btnEliminar);
            tabNuevaVenta.Controls.Add(dgvDatos);
            tabNuevaVenta.Controls.Add(lblSubtotal);
            tabNuevaVenta.Controls.Add(btnNuevo);
            tabNuevaVenta.Controls.Add(btnRegistrar);
            tabNuevaVenta.Location = new Point(4, 24);
            tabNuevaVenta.Name = "tabNuevaVenta";
            tabNuevaVenta.Padding = new Padding(3);
            tabNuevaVenta.Size = new Size(907, 592);
            tabNuevaVenta.TabIndex = 0;
            tabNuevaVenta.Text = "Nueva Venta";
            tabNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // grbEncabezado
            // 
            grbEncabezado.Controls.Add(label3);
            grbEncabezado.Controls.Add(txtUsuario);
            grbEncabezado.Controls.Add(label4);
            grbEncabezado.Controls.Add(cbMetodoPago);
            grbEncabezado.Controls.Add(label6);
            grbEncabezado.Controls.Add(cmbTipoVenta);
            grbEncabezado.Controls.Add(label1);
            grbEncabezado.Controls.Add(txtCliente);
            grbEncabezado.Controls.Add(btnSearch);
            grbEncabezado.Controls.Add(label2);
            grbEncabezado.Controls.Add(txtObservacion);
            grbEncabezado.Location = new Point(6, 6);
            grbEncabezado.Name = "grbEncabezado";
            grbEncabezado.Size = new Size(893, 165);
            grbEncabezado.TabIndex = 0;
            grbEncabezado.TabStop = false;
            grbEncabezado.Text = "Datos de la Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(60, 20);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(165, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 23);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Metodo de Pago";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(340, 20);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(195, 23);
            cbMetodoPago.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 23);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 4;
            label6.Text = "Tipo Venta";
            // 
            // cmbTipoVenta
            // 
            cmbTipoVenta.FormattingEnabled = true;
            cmbTipoVenta.Location = new Point(620, 20);
            cmbTipoVenta.Name = "cmbTipoVenta";
            cmbTipoVenta.Size = new Size(160, 23);
            cmbTipoVenta.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(60, 54);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Buscar cliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(305, 23);
            txtCliente.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(369, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(28, 31);
            btnSearch.TabIndex = 8;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 9;
            label2.Text = "Observaciones";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(6, 110);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.PlaceholderText = "Inserte su observacion";
            txtObservacion.Size = new Size(878, 45);
            txtObservacion.TabIndex = 10;
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(lblProduct);
            grbDetalle.Controls.Add(txtProduct);
            grbDetalle.Controls.Add(btnSearchProduct);
            grbDetalle.Controls.Add(lblCantidad);
            grbDetalle.Controls.Add(txtCantidad);
            grbDetalle.Controls.Add(lblPrecioUnitario);
            grbDetalle.Controls.Add(txtPrecioUnitario);
            grbDetalle.Controls.Add(lblDescuento);
            grbDetalle.Controls.Add(txtDescuento);
            grbDetalle.Location = new Point(6, 178);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(893, 95);
            grbDetalle.TabIndex = 11;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Agregar Producto";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(6, 25);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(56, 15);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Producto";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(65, 22);
            txtProduct.Name = "txtProduct";
            txtProduct.PlaceholderText = "Buscar producto";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(305, 23);
            txtProduct.TabIndex = 1;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Image = (Image)resources.GetObject("btnSearchProduct.Image");
            btnSearchProduct.Location = new Point(374, 19);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(32, 31);
            btnSearchProduct.TabIndex = 2;
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(425, 25);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(485, 22);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "0";
            txtCantidad.Size = new Size(80, 23);
            txtCantidad.TabIndex = 4;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(580, 25);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 5;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(670, 22);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.PlaceholderText = "0.00";
            txtPrecioUnitario.ReadOnly = true;
            txtPrecioUnitario.Size = new Size(90, 23);
            txtPrecioUnitario.TabIndex = 6;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(6, 62);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(75, 59);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PlaceholderText = "0.00";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(6, 280);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 34);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(510, 280);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 34);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(627, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 34);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(744, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 34);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(6, 321);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(893, 140);
            dgvDatos.TabIndex = 16;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotal.Location = new Point(6, 470);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(117, 19);
            lblSubtotal.TabIndex = 17;
            lblSubtotal.Text = "Subtotal:  $ 0.00";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(690, 465);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 33);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(797, 465);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(110, 33);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tabHistorial
            // 
            tabHistorial.Controls.Add(lblDesde);
            tabHistorial.Controls.Add(dtpDesde);
            tabHistorial.Controls.Add(lblHasta);
            tabHistorial.Controls.Add(dtpHasta);
            tabHistorial.Controls.Add(btnFiltrar);
            tabHistorial.Controls.Add(dgvVentas);
            tabHistorial.Controls.Add(lblDetalleVenta);
            tabHistorial.Controls.Add(dgvDetalleVenta);
            tabHistorial.Controls.Add(btnEditarVenta);
            tabHistorial.Controls.Add(btnEliminarVenta);
            tabHistorial.Location = new Point(4, 24);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3);
            tabHistorial.Size = new Size(907, 592);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "Historial de Ventas";
            tabHistorial.UseVisualStyleBackColor = true;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(6, 15);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(60, 10);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(130, 23);
            dtpDesde.TabIndex = 1;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(205, 15);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(255, 10);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(130, 23);
            dtpHasta.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(400, 8);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(85, 28);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(6, 45);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(893, 205);
            dgvVentas.TabIndex = 5;
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDetalleVenta.Location = new Point(6, 258);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(187, 15);
            lblDetalleVenta.TabIndex = 6;
            lblDetalleVenta.Text = "Detalle de la venta seleccionada:";
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(6, 277);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(893, 150);
            dgvDetalleVenta.TabIndex = 6;
            // 
            // btnEditarVenta
            // 
            btnEditarVenta.Location = new Point(672, 435);
            btnEditarVenta.Name = "btnEditarVenta";
            btnEditarVenta.Size = new Size(110, 33);
            btnEditarVenta.TabIndex = 7;
            btnEditarVenta.Text = "Editar Venta";
            btnEditarVenta.UseVisualStyleBackColor = true;
            btnEditarVenta.Click += btnEditarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(789, 435);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(110, 33);
            btnEliminarVenta.TabIndex = 8;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // uctrlventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(tabControl);
            Name = "uctrlventa";
            Size = new Size(915, 620);
            Load += uctrlventa_Load;
            tabControl.ResumeLayout(false);
            tabNuevaVenta.ResumeLayout(false);
            tabNuevaVenta.PerformLayout();
            grbEncabezado.ResumeLayout(false);
            grbEncabezado.PerformLayout();
            grbDetalle.ResumeLayout(false);
            grbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tabHistorial.ResumeLayout(false);
            tabHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNuevaVenta;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.GroupBox grbEncabezado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.GroupBox grbDetalle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnEditarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
    }
}
