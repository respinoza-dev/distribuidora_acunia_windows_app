namespace SistemaGestion.UI
{
    partial class uctrlProductos
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
            pnContenedor = new Panel();
            grbDatosProductos = new GroupBox();
            txtStockMinimo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtPrecioCosto = new TextBox();
            label5 = new Label();
            txtPrecioDetalle = new TextBox();
            cbCategoria = new ComboBox();
            txtStockDisponible = new TextBox();
            label1 = new Label();
            label6 = new Label();
            cbMarca = new ComboBox();
            txtNombreProducto = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnVisualizar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnRegistrar = new Button();
            dgvDatos = new DataGridView();
            btnAgregar = new Button();
            cbUnidad = new ComboBox();
            label9 = new Label();
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
            pnContenedor.Location = new Point(51, 21);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(786, 517);
            pnContenedor.TabIndex = 1;
            // 
            // grbDatosProductos
            // 
            grbDatosProductos.Controls.Add(label9);
            grbDatosProductos.Controls.Add(cbUnidad);
            grbDatosProductos.Controls.Add(txtStockMinimo);
            grbDatosProductos.Controls.Add(label8);
            grbDatosProductos.Controls.Add(label7);
            grbDatosProductos.Controls.Add(txtPrecioCosto);
            grbDatosProductos.Controls.Add(label5);
            grbDatosProductos.Controls.Add(txtPrecioDetalle);
            grbDatosProductos.Controls.Add(cbCategoria);
            grbDatosProductos.Controls.Add(txtStockDisponible);
            grbDatosProductos.Controls.Add(label1);
            grbDatosProductos.Controls.Add(label6);
            grbDatosProductos.Controls.Add(cbMarca);
            grbDatosProductos.Controls.Add(txtNombreProducto);
            grbDatosProductos.Controls.Add(label3);
            grbDatosProductos.Controls.Add(txtDescripcion);
            grbDatosProductos.Controls.Add(label4);
            grbDatosProductos.Controls.Add(label2);
            grbDatosProductos.Location = new Point(35, 12);
            grbDatosProductos.Margin = new Padding(3, 2, 3, 2);
            grbDatosProductos.Name = "grbDatosProductos";
            grbDatosProductos.Padding = new Padding(3, 2, 3, 2);
            grbDatosProductos.Size = new Size(720, 174);
            grbDatosProductos.TabIndex = 16;
            grbDatosProductos.TabStop = false;
            grbDatosProductos.Text = "Datos del Producto";
            grbDatosProductos.Enter += grbDatosProductos_Enter;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(153, 147);
            txtStockMinimo.Margin = new Padding(3, 2, 3, 2);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(113, 23);
            txtStockMinimo.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 128);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 14;
            label8.Text = "Stock Minimo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(300, 128);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 12;
            label7.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(300, 147);
            txtPrecioCosto.Margin = new Padding(3, 2, 3, 2);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(108, 23);
            txtPrecioCosto.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 130);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 6;
            label5.Text = "Precio Unitario";
            // 
            // txtPrecioDetalle
            // 
            txtPrecioDetalle.Location = new Point(459, 147);
            txtPrecioDetalle.Margin = new Padding(3, 2, 3, 2);
            txtPrecioDetalle.Name = "txtPrecioDetalle";
            txtPrecioDetalle.Size = new Size(108, 23);
            txtPrecioDetalle.TabIndex = 5;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "S26", "S26 Ultra", "Pro Max 15", "Redmi A18" });
            cbCategoria.Location = new Point(18, 99);
            cbCategoria.Margin = new Padding(3, 2, 3, 2);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(156, 23);
            cbCategoria.TabIndex = 10;
            // 
            // txtStockDisponible
            // 
            txtStockDisponible.Location = new Point(454, 99);
            txtStockDisponible.Margin = new Padding(3, 2, 3, 2);
            txtStockDisponible.Name = "txtStockDisponible";
            txtStockDisponible.Size = new Size(113, 23);
            txtStockDisponible.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 82);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 8;
            label6.Text = "Stock Disponible";
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Samsumg", "IPhone", "Xiaomi", "DELL", "HP", "Asus" });
            cbMarca.Location = new Point(441, 45);
            cbMarca.Margin = new Padding(3, 2, 3, 2);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(174, 23);
            cbMarca.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(18, 45);
            txtNombreProducto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(156, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 81);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(233, 45);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(164, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 28);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 25);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
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
            btnEliminar.Location = new Point(628, 191);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(361, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 36);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(494, 191);
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
            dgvDatos.Location = new Point(35, 233);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(720, 237);
            dgvDatos.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(35, 191);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 36);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar a la lista";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbUnidad
            // 
            cbUnidad.FormattingEnabled = true;
            cbUnidad.Items.AddRange(new object[] { "S26", "S26 Ultra", "Pro Max 15", "Redmi A18" });
            cbUnidad.Location = new Point(241, 99);
            cbUnidad.Margin = new Padding(3, 2, 3, 2);
            cbUnidad.Name = "cbUnidad";
            cbUnidad.Size = new Size(156, 23);
            cbUnidad.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(244, 82);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 16;
            label9.Text = "Unidad de medida";
            // 
            // uctrlProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(pnContenedor);
            Name = "uctrlProductos";
            Size = new Size(930, 569);
            Load += uctrlProductos_Load;
            pnContenedor.ResumeLayout(false);
            grbDatosProductos.ResumeLayout(false);
            grbDatosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnContenedor;
        private Button btnVisualizar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnRegistrar;
        private DataGridView dgvDatos;
        private Button btnAgregar;
        private GroupBox grbDatosProductos;
        private TextBox txtStockMinimo;
        private Label label8;
        private Label label7;
        private TextBox txtPrecioCosto;
        private Label label5;
        private TextBox txtPrecioDetalle;
        private ComboBox cbCategoria;
        private TextBox txtStockDisponible;
        private Label label1;
        private Label label6;
        private ComboBox cbMarca;
        private TextBox txtNombreProducto;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label4;
        private Label label2;
        private ComboBox cbUnidad;
        private Label label9;
    }
}
