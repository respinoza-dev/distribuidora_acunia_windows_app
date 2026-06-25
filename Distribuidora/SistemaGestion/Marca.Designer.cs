namespace SistemaGestion.UI
{
    partial class uctrlMarca
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
            label1 = new Label();
            label4 = new Label();
            textDescripcionMarca = new TextBox();
            textNombreMarca = new TextBox();
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
            pnContenedor.Location = new Point(86, 15);
            pnContenedor.Name = "pnContenedor";
            pnContenedor.Size = new Size(786, 498);
            pnContenedor.TabIndex = 2;
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
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            grbDatosCategorias.Controls.Add(label1);
            grbDatosCategorias.Controls.Add(label4);
            grbDatosCategorias.Controls.Add(textDescripcionMarca);
            grbDatosCategorias.Controls.Add(textNombreMarca);
            grbDatosCategorias.Location = new Point(35, 3);
            grbDatosCategorias.Name = "grbDatosCategorias";
            grbDatosCategorias.Size = new Size(719, 141);
            grbDatosCategorias.TabIndex = 8;
            grbDatosCategorias.TabStop = false;
            grbDatosCategorias.Text = "Datos de la Marca";
            grbDatosCategorias.Enter += grbDatosCategorias_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 33);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 10;
            label1.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 33);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 12;
            label4.Text = "Nombre de la marca";
            // 
            // textDescripcionMarca
            // 
            textDescripcionMarca.Location = new Point(239, 50);
            textDescripcionMarca.Name = "textDescripcionMarca";
            textDescripcionMarca.Size = new Size(161, 23);
            textDescripcionMarca.TabIndex = 9;
            // 
            // textNombreMarca
            // 
            textNombreMarca.Location = new Point(45, 50);
            textNombreMarca.Name = "textNombreMarca";
            textNombreMarca.Size = new Size(161, 23);
            textNombreMarca.TabIndex = 11;
            // 
            // uctrlMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnContenedor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "uctrlMarca";
            Size = new Size(958, 528);
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
        private Label label1;
        private Label label4;
        private TextBox textDescripcionMarca;
        private TextBox textNombreMarca;
    }
}
