namespace SistemaGestion
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbDatosProductos = new GroupBox();
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
            btnAgregar = new Button();
            dgvDatos = new DataGridView();
            btnRegistrar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnVisualizar = new Button();
            label7 = new Label();
            txtPrecioCosto = new TextBox();
            txtStockMinimo = new TextBox();
            label8 = new Label();
            grbDatosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // grbDatosProductos
            // 
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
            grbDatosProductos.Location = new Point(28, 25);
            grbDatosProductos.Name = "grbDatosProductos";
            grbDatosProductos.Size = new Size(776, 232);
            grbDatosProductos.TabIndex = 0;
            grbDatosProductos.TabStop = false;
            grbDatosProductos.Text = "Datos del Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 107);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 6;
            label5.Text = "Precio Unitario";
            // 
            // txtPrecioDetalle
            // 
            txtPrecioDetalle.Location = new Point(416, 132);
            txtPrecioDetalle.Name = "txtPrecioDetalle";
            txtPrecioDetalle.Size = new Size(123, 27);
            txtPrecioDetalle.TabIndex = 5;
            txtPrecioDetalle.TextChanged += txtPrecio_TextChanged;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "S26", "S26 Ultra", "Pro Max 15", "Redmi A18" });
            cbCategoria.Location = new Point(20, 132);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(178, 28);
            cbCategoria.TabIndex = 10;
            cbCategoria.SelectedIndexChanged += cbModelo_SelectedIndexChanged;
            // 
            // txtStockDisponible
            // 
            txtStockDisponible.Location = new Point(580, 132);
            txtStockDisponible.Name = "txtStockDisponible";
            txtStockDisponible.Size = new Size(129, 27);
            txtStockDisponible.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(580, 107);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 8;
            label6.Text = "Stock Disponible";
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { "Samsumg", "IPhone", "Xiaomi", "DELL", "HP", "Asus" });
            cbMarca.Location = new Point(511, 59);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(198, 28);
            cbMarca.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(20, 60);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(178, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 8;
            label3.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(249, 60);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(187, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 36);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 35);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 278);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 36);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar a la lista";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(28, 332);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(786, 237);
            dgvDatos.TabIndex = 2;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(27, 575);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 33);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(514, 278);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 36);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(357, 278);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(677, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 36);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(708, 575);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(105, 33);
            btnVisualizar.TabIndex = 7;
            btnVisualizar.Text = "Ver Registros";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 108);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 12;
            label7.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(228, 133);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(123, 27);
            txtPrecioCosto.TabIndex = 11;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(349, 188);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(129, 27);
            txtStockMinimo.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 163);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 14;
            label8.Text = "Stock Minimo";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 620);
            Controls.Add(btnVisualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvDatos);
            Controls.Add(btnAgregar);
            Controls.Add(grbDatosProductos);
            Name = "frmProducto";
            Text = "Catalogo de Productos";
            Load += frmProducto_Load;
            grbDatosProductos.ResumeLayout(false);
            grbDatosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDatosProductos;
        private TextBox txtNombreProducto;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private Label label4;
        private ComboBox cbMarca;
        private ComboBox cbCategoria;
        private Label label5;
        private TextBox txtPrecioDetalle;
        private TextBox txtStockDisponible;
        private Label label6;
        private Button btnAgregar;
        private DataGridView dgvDatos;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnVisualizar;
        private Label label7;
        private TextBox txtPrecioCosto;
        private TextBox txtStockMinimo;
        private Label label8;
    }
}