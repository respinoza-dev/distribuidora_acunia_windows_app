namespace SistemaGestion.UI
{
    partial class frmBuscarCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblBuscar      = new Label();
            txtBuscar      = new TextBox();
            btnBuscar      = new Button();
            dgvClientes    = new DataGridView();
            btnSeleccionar = new Button();
            btnCerrar      = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(12, 16);
            lblBuscar.Name     = "lblBuscar";
            lblBuscar.TabIndex = 0;
            lblBuscar.Text     = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location       = new Point(65, 13);
            txtBuscar.Margin         = new Padding(3, 2, 3, 2);
            txtBuscar.Name           = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingrese nombre del cliente...";
            txtBuscar.Size           = new Size(390, 23);
            txtBuscar.TabIndex       = 1;
            txtBuscar.KeyDown        += txtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Location             = new Point(465, 12);
            btnBuscar.Margin               = new Padding(3, 2, 3, 2);
            btnBuscar.Name                 = "btnBuscar";
            btnBuscar.Size                 = new Size(110, 25);
            btnBuscar.TabIndex             = 2;
            btnBuscar.Text                 = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click               += btnBuscar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows    = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location       = new Point(12, 46);
            dgvClientes.Margin         = new Padding(3, 2, 3, 2);
            dgvClientes.Name           = "dgvClientes";
            dgvClientes.ReadOnly       = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode  = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size           = new Size(563, 330);
            dgvClientes.TabIndex       = 3;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location             = new Point(340, 386);
            btnSeleccionar.Margin               = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name                 = "btnSeleccionar";
            btnSeleccionar.Size                 = new Size(115, 30);
            btnSeleccionar.TabIndex             = 4;
            btnSeleccionar.Text                 = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click               += btnSeleccionar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location             = new Point(460, 386);
            btnCerrar.Margin               = new Padding(3, 2, 3, 2);
            btnCerrar.Name                 = "btnCerrar";
            btnCerrar.Size                 = new Size(115, 30);
            btnCerrar.TabIndex             = 5;
            btnCerrar.Text                 = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click               += btnCerrar_Click;
            // 
            // frmBuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(587, 425);
            Controls.Add(btnCerrar);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            FormBorderStyle   = FormBorderStyle.FixedDialog;
            MaximizeBox       = false;
            MinimizeBox       = false;
            Name              = "frmBuscarCliente";
            StartPosition     = FormStartPosition.CenterParent;
            Text              = "Buscar Cliente";
            Load             += frmBuscarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label         lblBuscar;
        private TextBox       txtBuscar;
        private Button        btnBuscar;
        private DataGridView  dgvClientes;
        private Button        btnSeleccionar;
        private Button        btnCerrar;
    }
}
