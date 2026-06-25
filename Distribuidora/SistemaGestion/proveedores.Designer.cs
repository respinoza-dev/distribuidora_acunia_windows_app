namespace SistemaGestion.UI
{
    partial class uctrlProveedores
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
            label6 = new Label();
            cbProveedorEstado = new ComboBox();
            label5 = new Label();
            textGmail = new TextBox();
            txtTelefonoProveedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textDireccionProveedor = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textNombreContacto = new TextBox();
            textNombreEmpresa = new TextBox();
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
            pnContenedor.Location = new Point(3, 3);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(786, 498);
            pnContenedor.TabIndex = 1;
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
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(627, 150);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
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
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
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
            grbDatosCategorias.Controls.Add(label6);
            grbDatosCategorias.Controls.Add(cbProveedorEstado);
            grbDatosCategorias.Controls.Add(label5);
            grbDatosCategorias.Controls.Add(textGmail);
            grbDatosCategorias.Controls.Add(txtTelefonoProveedor);
            grbDatosCategorias.Controls.Add(label3);
            grbDatosCategorias.Controls.Add(label2);
            grbDatosCategorias.Controls.Add(textDireccionProveedor);
            grbDatosCategorias.Controls.Add(label1);
            grbDatosCategorias.Controls.Add(label4);
            grbDatosCategorias.Controls.Add(textNombreContacto);
            grbDatosCategorias.Controls.Add(textNombreEmpresa);
            grbDatosCategorias.Location = new Point(35, 3);
            grbDatosCategorias.Name = "grbDatosCategorias";
            grbDatosCategorias.Size = new Size(719, 141);
            grbDatosCategorias.TabIndex = 8;
            grbDatosCategorias.TabStop = false;
            grbDatosCategorias.Text = "Datos del proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 83);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 20;
            label6.Text = "Estado";
            // 
            // cbProveedorEstado
            // 
            cbProveedorEstado.FormattingEnabled = true;
            cbProveedorEstado.Items.AddRange(new object[] { "Activa", "Inactiva" });
            cbProveedorEstado.Location = new Point(430, 101);
            cbProveedorEstado.Name = "cbProveedorEstado";
            cbProveedorEstado.Size = new Size(198, 23);
            cbProveedorEstado.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 83);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 18;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // textGmail
            // 
            textGmail.Location = new Point(45, 101);
            textGmail.Name = "textGmail";
            textGmail.Size = new Size(161, 23);
            textGmail.TabIndex = 17;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Location = new Point(239, 101);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(161, 23);
            txtTelefonoProveedor.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 83);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 16;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 32);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Direccion";
            // 
            // textDireccionProveedor
            // 
            textDireccionProveedor.Location = new Point(440, 50);
            textDireccionProveedor.Name = "textDireccionProveedor";
            textDireccionProveedor.Size = new Size(168, 23);
            textDireccionProveedor.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 32);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre del Contacto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 32);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 12;
            label4.Text = "Nombre de la empresa";
            // 
            // textNombreContacto
            // 
            textNombreContacto.Location = new Point(239, 50);
            textNombreContacto.Name = "textNombreContacto";
            textNombreContacto.Size = new Size(161, 23);
            textNombreContacto.TabIndex = 9;
            // 
            // textNombreEmpresa
            // 
            textNombreEmpresa.Location = new Point(45, 50);
            textNombreEmpresa.Name = "textNombreEmpresa";
            textNombreEmpresa.Size = new Size(161, 23);
            textNombreEmpresa.TabIndex = 11;
            // 
            // uctrlProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnContenedor);
            Name = "uctrlProveedores";
            Size = new Size(847, 504);
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
        private TextBox txtTelefonoProveedor;
        private Label label3;
        private Label label2;
        private TextBox textDireccionProveedor;
        private Label label1;
        private Label label4;
        private TextBox textNombreContacto;
        private TextBox textNombreEmpresa;
        private Label label5;
        private TextBox textGmail;
        private Label label6;
        private ComboBox cbProveedorEstado;
    }
}
