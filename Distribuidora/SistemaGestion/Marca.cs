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
    public partial class uctrlMarca : UserControl
    {
        List<Marca> ListaMarcaTemp = new List<Marca>();
        List<Marca> ListaMarca = new List<Marca>();
        // creando un objeto de tipo CategoryServices para poder usar sus metodos
        MarcaServices _serviciosMarca = new MarcaServices();

        int indiceSeleccionado;
        public uctrlMarca()
        {
            InitializeComponent();
        }

        private void grbDatosCategorias_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // creando un objeto de tipo Categoria
            Marca Marca = new Marca();

            // aca el profe esta agregando datos que el usuario ingrese a las propiedades del objeto
            Marca.NombreMarca = textNombreMarca.Text;
            Marca.Descripcion = textDescripcionMarca.Text;


            // agregamos la categoria a la listacategoriasTemp
            ListaMarcaTemp.Add(Marca);

            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaMarcaTemp;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _serviciosMarca.RegistrarLista(ListaMarcaTemp);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ListaMarca = _serviciosMarca.ObtenerLista();
            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaMarca;
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;

            textNombreMarca.Text = ListaMarca[indiceSeleccionado].NombreMarca.ToString();
            textDescripcionMarca.Text = ListaMarca[indiceSeleccionado].Descripcion.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // creando un objeto de tipo Categoria
            Marca Marca = new Marca();

            Marca.IdMarca = indiceSeleccionado + 1; // sumamos 1 porque el indice del DataGridView empieza en 0 y el IdCategoria empieza en 1 
            Marca.NombreMarca = textNombreMarca.Text;
            Marca.Descripcion = textDescripcionMarca.Text;

            // invocamos al servicio de categorias para editar
            _serviciosMarca.Editar(Marca);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var IdMarca = ListaMarca[indiceSeleccionado].IdMarca;

            DialogResult resultado = MessageBox.Show("Quieres eliminar la Marca seleccionada? (Esta accion es irremediable)", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                DialogResult resultado2 = MessageBox.Show("Marca eliminado", "Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _serviciosMarca.Eliminar(IdMarca);
            }
        }
    }
}
