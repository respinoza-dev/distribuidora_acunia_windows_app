using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestion.BLL.Services;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.UI
{
    public partial class uctrlCategorias : UserControl
    {
        // crear la lista de tipo Categoria
        List<Categoria> ListaCategoriasTemp = new List<Categoria>();
        List<Categoria> ListaCategorias = new List<Categoria>();
        // creando un objeto de tipo CategoryServices para poder usar sus metodos
        CategoryServices _serviciosCategorias = new CategoryServices();

        // variable global para almacenar el indice seleccionado del DataGridView
        int indiceSeleccionado;
        public uctrlCategorias()
        {
            InitializeComponent();
        }

        private void uctrlCategorias_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // creando un objeto de tipo Categoria
            Categoria categoria = new Categoria();

            // aca el profe esta agregando datos que el usuario ingrese a las propiedades del objeto
            categoria.NombreCategoria = txtNombreCategoria.Text;
            categoria.Descripcion = txtDescripcion.Text;

            // este ultimo bloque de codigo es para convertir el estado que el usuario seleccione
            // en el comboBox a un valor booleano para la propiedad Estado del objeto categoria
            if (cbEstado.Text == "Activa")
                categoria.Estado = true;
            else if (cbEstado.Text == "Inactiva")
                categoria.Estado = false;
            else
                MessageBox.Show("Seleccione un estado para la categoria");

            // agregamos la categoria a la listacategoriasTemp
            ListaCategoriasTemp.Add(categoria);

            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaCategoriasTemp;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _serviciosCategorias.RegistrarLista(ListaCategoriasTemp);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ListaCategorias = _serviciosCategorias.ObtenerLista();
            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaCategorias;
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;

            txtNombreCategoria.Text = ListaCategorias[indiceSeleccionado].NombreCategoria.ToString();
            txtDescripcion.Text = ListaCategorias[indiceSeleccionado].Descripcion.ToString();
            if (ListaCategorias[indiceSeleccionado].Estado == true)
                cbEstado.Text = "Activa";
            else
                cbEstado.Text = "Inactiva";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // creando un objeto de tipo Categoria
            Categoria categoria = new Categoria();

            categoria.IdCategoria = indiceSeleccionado + 1; // sumamos 1 porque el indice del DataGridView empieza en 0 y el IdCategoria empieza en 1 
            categoria.NombreCategoria = txtNombreCategoria.Text;
            categoria.Descripcion = txtDescripcion.Text;

            if (cbEstado.Text == "Activa")
                categoria.Estado = true;
            else if (cbEstado.Text == "Inactiva")
                categoria.Estado = false;


            // invocamos al servicio de categorias para editar
            _serviciosCategorias.Editar(categoria);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var IdCategoria =ListaCategorias[indiceSeleccionado].IdCategoria;

            DialogResult resultado = MessageBox.Show("Quieres eliminar la Categoria seleccionada? (Esta accion es irremediable)", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                DialogResult resultado2 = MessageBox.Show("Categoria eliminado", "Eliminar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _serviciosCategorias.Eliminar(IdCategoria);
            }
        }
    }
}
