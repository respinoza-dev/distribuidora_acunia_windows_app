namespace SistemaGestion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            tsmiInicio = new ToolStripMenuItem();
            tsmiCatalogos = new ToolStripMenuItem();
            tsmiCategorias = new ToolStripMenuItem();
            tmsiProveedores = new ToolStripMenuItem();
            tmsiMarca = new ToolStripMenuItem();
            tmsiProducto = new ToolStripMenuItem();
            tsmiVentas = new ToolStripMenuItem();
            pnControlContainer = new Panel();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { tsmiInicio, tsmiCatalogos });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(971, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // tsmiInicio
            // 
            tsmiInicio.Name = "tsmiInicio";
            tsmiInicio.Size = new Size(48, 20);
            tsmiInicio.Text = "Inicio";
            tsmiInicio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsmiCatalogos
            // 
            tsmiCatalogos.DropDownItems.AddRange(new ToolStripItem[] { tsmiCategorias, tmsiProveedores, tmsiMarca, tmsiProducto, tsmiVentas });
            tsmiCatalogos.Name = "tsmiCatalogos";
            tsmiCatalogos.Size = new Size(131, 20);
            tsmiCatalogos.Text = "Gestión de Catálogos";
            tsmiCatalogos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsmiCategorias
            // 
            tsmiCategorias.Name = "tsmiCategorias";
            tsmiCategorias.Size = new Size(180, 22);
            tsmiCategorias.Text = "Categorías";
            tsmiCategorias.Click += tsmiCategorias_Click;
            // 
            // tmsiProveedores
            // 
            tmsiProveedores.Name = "tmsiProveedores";
            tmsiProveedores.Size = new Size(180, 22);
            tmsiProveedores.Text = "Proveedores";
            tmsiProveedores.Click += tmsiProveedores_Click;
            // 
            // tmsiMarca
            // 
            tmsiMarca.Name = "tmsiMarca";
            tmsiMarca.Size = new Size(180, 22);
            tmsiMarca.Text = "Marca";
            tmsiMarca.Click += tmsiMarca_Click;
            // 
            // tmsiProducto
            // 
            tmsiProducto.Name = "tmsiProducto";
            tmsiProducto.Size = new Size(180, 22);
            tmsiProducto.Text = "Producto";
            tmsiProducto.Click += tmsiProducto_Click;
            // 
            // tsmiVentas
            // 
            tsmiVentas.Name = "tsmiVentas";
            tsmiVentas.Size = new Size(180, 22);
            tsmiVentas.Text = "Ventas";
            tsmiVentas.Click += tsmiVentas_Click;
            // 
            // pnControlContainer
            // 
            pnControlContainer.Anchor = AnchorStyles.None;
            pnControlContainer.BackColor = SystemColors.GradientInactiveCaption;
            pnControlContainer.Location = new Point(0, 23);
            pnControlContainer.Margin = new Padding(3, 2, 3, 2);
            pnControlContainer.Name = "pnControlContainer";
            pnControlContainer.Size = new Size(453, 239);
            pnControlContainer.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 490);
            Controls.Add(pnControlContainer);
            Controls.Add(menuStrip);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Text = "Sistema de Gestion";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem tsmiInicio;
        private ToolStripMenuItem tsmiCatalogos;
        private ToolStripMenuItem tsmiCategorias;
        private Panel pnControlContainer;
        private ToolStripMenuItem tmsiProveedores;
        private ToolStripMenuItem tmsiMarca;
        private ToolStripMenuItem tmsiProducto;
        private ToolStripMenuItem tsmiVentas;
    }
}
