namespace SistemaGestion.UI
{
    partial class uctrlventa
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlventa));
            pnContenedor = new Panel();
            grbDatosProductos = new GroupBox();
            textBox1 = new TextBox();
            lblProduct = new Label();
            btnSearchProduct = new Button();
            txtProduct = new TextBox();
            btnSearch = new Button();
            txtUsuario = new TextBox();
            label9 = new Label();
            cbUnidad = new ComboBox();
            txtObservacion = new TextBox();
            label1 = new Label();
            label6 = new Label();
            cbMetodoPago = new ComboBox();
            txtCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnVisualizar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnRegistrar = new Button();
            dgvDatos = new DataGridView();
            btnAgregar = new Button();
            pnContenedor.SuspendLayout();
            grbDatosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // pnContenedor
            // 
            pnContenedor.Anchor = AnchorStyles.None;
            pnContenedor.BackColor = SystemColors.Control;
            pnContenedor.Controls.Add(grbDatosProductos);
            pnContenedor.Controls.Add(btnVisualizar);
            pnContenedor.Controls.Add(btnEliminar);
            pnContenedor.Controls.Add(btnCancelar);
            pnContenedor.Controls.Add(btnEditar);
            pnContenedor.Controls.Add(btnRegistrar);
            pnContenedor.Controls.Add(dgvDatos);
            pnContenedor.Controls.Add(btnAgregar);
            pnContenedor.Location = new Point(29, 21);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(786, 517);
            pnContenedor.TabIndex = 2;
            // 
            // grbDatosProductos
            // 
            grbDatosProductos.Controls.Add(textBox1);
            grbDatosProductos.Controls.Add(lblProduct);
            grbDatosProductos.Controls.Add(btnSearchProduct);
            grbDatosProductos.Controls.Add(txtProduct);
            grbDatosProductos.Controls.Add(btnSearch);
            grbDatosProductos.Controls.Add(txtUsuario);
            grbDatosProductos.Controls.Add(label9);
            grbDatosProductos.Controls.Add(cbUnidad);
            grbDatosProductos.Controls.Add(txtObservacion);
            grbDatosProductos.Controls.Add(label1);
            grbDatosProductos.Controls.Add(label6);
            grbDatosProductos.Controls.Add(cbMetodoPago);
            grbDatosProductos.Controls.Add(txtCliente);
            grbDatosProductos.Controls.Add(label3);
            grbDatosProductos.Controls.Add(label4);
            grbDatosProductos.Controls.Add(label2);
            grbDatosProductos.Location = new Point(35, 12);
            grbDatosProductos.Margin = new Padding(3, 2, 3, 2);
            grbDatosProductos.Name = "grbDatosProductos";
            grbDatosProductos.Padding = new Padding(3, 2, 3, 2);
            grbDatosProductos.Size = new Size(720, 296);
            grbDatosProductos.TabIndex = 16;
            grbDatosProductos.TabStop = false;
            grbDatosProductos.Text = "Datos del Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 23;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(6, 139);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(56, 15);
            lblProduct.TabIndex = 22;
            lblProduct.Text = "Producto";
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Image = (Image)resources.GetObject("btnSearchProduct.Image");
            btnSearchProduct.Location = new Point(671, 151);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(32, 31);
            btnSearchProduct.TabIndex = 21;
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(6, 156);
            txtProduct.Margin = new Padding(3, 2, 3, 2);
            txtProduct.Name = "txtProduct";
            txtProduct.PlaceholderText = "Buscar producto";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(659, 23);
            txtProduct.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(191, 91);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(28, 31);
            btnSearch.TabIndex = 19;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(6, 43);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(198, 23);
            txtUsuario.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(228, 81);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 16;
            label9.Text = "Unidad de medida";
            // 
            // cbUnidad
            // 
            cbUnidad.FormattingEnabled = true;
            cbUnidad.Items.AddRange(new object[] { "S26", "S26 Ultra", "Pro Max 15", "Redmi A18" });
            cbUnidad.Location = new Point(225, 99);
            cbUnidad.Margin = new Padding(3, 2, 3, 2);
            cbUnidad.Name = "cbUnidad";
            cbUnidad.Size = new Size(245, 23);
            cbUnidad.TabIndex = 15;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(6, 202);
            txtObservacion.Margin = new Padding(3, 2, 3, 2);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.PlaceholderText = "Inserte su observación";
            txtObservacion.Size = new Size(708, 56);
            txtObservacion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(497, 25);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 8;
            label6.Text = "Tipo Venta";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(224, 43);
            cbMetodoPago.Margin = new Padding(3, 2, 3, 2);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(246, 23);
            cbMetodoPago.TabIndex = 9;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(6, 95);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(180, 23);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtNombreProducto_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 27);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 6;
            label4.Text = "Metodo de pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 185);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "observaciones";
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(650, 476);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(105, 33);
            btnVisualizar.TabIndex = 15;
            btnVisualizar.Text = "Ver Registros";
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(628, 337);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(361, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 36);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(494, 337);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 36);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(35, 476);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 33);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(35, 379);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(720, 91);
            dgvDatos.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(35, 337);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 36);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar a la lista";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // uctrlventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnContenedor);
            Name = "uctrlventa";
            Size = new Size(915, 541);
            Load += uctrlventa_Load;
            pnContenedor.ResumeLayout(false);
            grbDatosProductos.ResumeLayout(false);
            grbDatosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnContenedor;
        private GroupBox grbDatosProductos;
        private Label label9;
        private ComboBox cbUnidad;
        private Label label1;
        private Label label6;
        private ComboBox cbMetodoPago;
        private TextBox txtCliente;
        private Label label3;
        private TextBox txtObservacion;
        private Label label4;
        private Label label2;
        private Button btnVisualizar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnRegistrar;
        private DataGridView dgvDatos;
        private Button btnAgregar;
        private TextBox txtUsuario;
        private Button btnSearch;
        private Label lblProduct;
        private Button btnSearchProduct;
        private TextBox txtProduct;
        private TextBox textBox1;
    }
}
