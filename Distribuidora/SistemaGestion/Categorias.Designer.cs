namespace SistemaGestion.UI
{
    partial class uctrlCategorias
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
            btnVisualizar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnRegistrar = new Button();
            dgvDatos = new DataGridView();
            btnAgregar = new Button();
            grbDatosCategorias = new GroupBox();
            cbEstado = new ComboBox();
            label1 = new Label();
            txtNombreCategoria = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            grbDatosCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // pnContenedor
            // 
            pnContenedor.Anchor = AnchorStyles.None;
            pnContenedor.BackColor = SystemColors.Control;
            pnContenedor.Controls.Add(btnVisualizar);
            pnContenedor.Controls.Add(btnEliminar);
            pnContenedor.Controls.Add(btnCancelar);
            pnContenedor.Controls.Add(btnEditar);
            pnContenedor.Controls.Add(btnRegistrar);
            pnContenedor.Controls.Add(dgvDatos);
            pnContenedor.Controls.Add(btnAgregar);
            pnContenedor.Controls.Add(grbDatosCategorias);
            pnContenedor.Location = new Point(36, 52);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(786, 517);
            pnContenedor.TabIndex = 0;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(650, 450);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(105, 33);
            btnVisualizar.TabIndex = 15;
            btnVisualizar.Text = "Ver Registros";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(627, 150);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(361, 150);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 36);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(494, 150);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 36);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(35, 450);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 33);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(35, 207);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(720, 237);
            dgvDatos.TabIndex = 10;
            dgvDatos.CellContentDoubleClick += dgvDatos_CellContentDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(35, 150);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 36);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar a la lista";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grbDatosCategorias
            // 
            grbDatosCategorias.Controls.Add(cbEstado);
            grbDatosCategorias.Controls.Add(label1);
            grbDatosCategorias.Controls.Add(txtNombreCategoria);
            grbDatosCategorias.Controls.Add(label3);
            grbDatosCategorias.Controls.Add(txtDescripcion);
            grbDatosCategorias.Controls.Add(label2);
            grbDatosCategorias.Location = new Point(35, 35);
            grbDatosCategorias.Name = "grbDatosCategorias";
            grbDatosCategorias.Size = new Size(719, 109);
            grbDatosCategorias.TabIndex = 8;
            grbDatosCategorias.TabStop = false;
            grbDatosCategorias.Text = "Datos de la Categoria";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cbEstado.Location = new Point(479, 60);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(198, 23);
            cbEstado.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre de la Categoría";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(20, 60);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(204, 23);
            txtNombreCategoria.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(479, 35);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Estado";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(249, 60);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(204, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 35);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción";
            // 
            // uctrlCategorias
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(pnContenedor);
            Name = "uctrlCategorias";
            Size = new Size(868, 616);
            Load += uctrlCategorias_Load;
            pnContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            grbDatosCategorias.ResumeLayout(false);
            grbDatosCategorias.PerformLayout();
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
        private GroupBox grbDatosCategorias;
        private Label label5;
        private TextBox txtPrecio;
        private ComboBox cbEstado;
        private TextBox txtStock;
        private Label label1;
        private Label label6;
        private ComboBox cbMarca;
        private TextBox txtNombreCategoria;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label4;
        private Label label2;
    }
}
