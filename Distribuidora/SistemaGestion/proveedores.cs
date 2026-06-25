using SistemaGestion.BLL.Services;
using SistemaGestion.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.UI
{
    public partial class uctrlProveedores : UserControl
    {
        List<proveedores> ListaProveedoresTemp = new List<proveedores>();
        List<proveedores> ListaProveedores = new List<proveedores>();
        // creando un objeto de tipo CategoryServices para poder usar sus metodos
        proveedoresSevices _servicioProveedor = new proveedoresSevices();

        int indiceSeleccionado;
        public uctrlProveedores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // creando un objeto de tipo Categoria
            proveedores proveedores = new proveedores();

            // aca el profe esta agregando datos que el usuario ingrese a las propiedades del objeto
            proveedores.NombreEmpresa = textNombreEmpresa.Text;
            proveedores.NombreContacto = textNombreContacto.Text;
            proveedores.Direccion = textDireccionProveedor.Text;
            proveedores.Gmail = textGmail.Text;
            proveedores.Telefono = txtTelefonoProveedor.Text;

            // este ultimo bloque de codigo es para convertir el estado que el usuario seleccione
            // en el comboBox a un valor booleano para la propiedad Estado del objeto categoria
            if (cbProveedorEstado.Text == "Activa")
                proveedores.Estado = true;
            else if (cbProveedorEstado.Text == "Inactiva")
                proveedores.Estado = false;
            else
                MessageBox.Show("Seleccione un estado para la categoria");

            // agregamos la categoria a la listacategoriasTemp
            ListaProveedoresTemp.Add(proveedores);

            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaProveedoresTemp;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ListaProveedores = _servicioProveedor.ObtenerLista();
            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaProveedores;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            proveedores proveedores = new proveedores();

            proveedores.IdProveedores = indiceSeleccionado + 1; // sumamos 1 porque el indice del DataGridView empieza en 0 y el IdCategoria empieza en 1 
            proveedores.NombreEmpresa = textNombreEmpresa.Text;
            proveedores.NombreContacto = textNombreContacto.Text;
            proveedores.Telefono = txtTelefonoProveedor.Text;
            proveedores.Gmail = textGmail.Text;
            proveedores.Direccion = textDireccionProveedor.Text;

            if (cbProveedorEstado.Text == "Activa")
                proveedores.Estado = true;
            else if (cbProveedorEstado.Text == "Inactiva")
                proveedores.Estado = false;


            // invocamos al servicio de categorias para editar
            _servicioProveedor.Editar(proveedores);
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;

            textNombreEmpresa.Text = ListaProveedores[indiceSeleccionado].NombreEmpresa.ToString();
            textNombreContacto.Text = ListaProveedores[indiceSeleccionado].NombreContacto.ToString();
            txtTelefonoProveedor.Text = ListaProveedores[indiceSeleccionado].Telefono.ToString();
            textGmail.Text = ListaProveedores[indiceSeleccionado].Gmail.ToString();

            if (ListaProveedores[indiceSeleccionado].Estado == true)
                cbProveedorEstado.Text = "Activa";
            else
                cbProveedorEstado.Text = "Inactiva";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _servicioProveedor.RegistrarLista(ListaProveedoresTemp);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var IdProveedor = ListaProveedores[indiceSeleccionado].IdProveedores;

            DialogResult resultado = MessageBox.Show("Quieres eliminar el proveedor seleccionado? (Esta accion es irremediable)", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                DialogResult resultado2 = MessageBox.Show("Proveedor eliminado", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _servicioProveedor.Eliminar(IdProveedor);
            }
        }
    }
}
