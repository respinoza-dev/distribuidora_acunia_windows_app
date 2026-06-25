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
    public partial class uctrlUnidadDeMedida : UserControl
    {

        List<UnidaDeMedida> ListaUnidadMedidaTemp = new List<UnidaDeMedida>();
        List<UnidaDeMedida> ListaUnidadMedida = new List<UnidaDeMedida>();
        // creando un objeto de tipo CategoryServices para poder usar sus metodos
        UnidadMedidaServices _serviciosUnidadMedida = new UnidadMedidaServices();

        int indiceSeleccionado;
        public uctrlUnidadDeMedida()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // creando un objeto de tipo Categoria
            UnidaDeMedida unidaDeMedida = new UnidaDeMedida();

            // aca el profe esta agregando datos que el usuario ingrese a las propiedades del objeto
            unidaDeMedida.NombreUnidad = txtNombreUnidad.Text;
            unidaDeMedida.Abreviatura = txtAbreviatura.Text;



            // agregamos la categoria a la listacategoriasTemp
            ListaUnidadMedidaTemp.Add(unidaDeMedida);

            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaUnidadMedidaTemp;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            _serviciosUnidadMedida.RegistrarLista(ListaUnidadMedidaTemp);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ListaUnidadMedida = _serviciosUnidadMedida.ObtenerLista();
            // alimentar el DataGridView con la listacategoriasTemp
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = ListaUnidadMedida;
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;

            txtNombreUnidad.Text = ListaUnidadMedida[indiceSeleccionado].NombreUnidad.ToString();
            txtAbreviatura.Text = ListaUnidadMedida[indiceSeleccionado].Abreviatura.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // creando un objeto de tipo Categoria
            UnidaDeMedida UnidaDeMedida = new UnidaDeMedida();

            UnidaDeMedida.IdUnidad = indiceSeleccionado + 1; // sumamos 1 porque el indice del DataGridView empieza en 0 y el IdCategoria empieza en 1 
            UnidaDeMedida.NombreUnidad = txtNombreUnidad.Text;
            UnidaDeMedida.Abreviatura = txtAbreviatura.Text;


            // invocamos al servicio de categorias para editar
            _serviciosUnidadMedida.Editar(UnidaDeMedida);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var IdUnidad = ListaUnidadMedida[indiceSeleccionado].IdUnidad;

            DialogResult resultado = MessageBox.Show("Quieres eliminar la Unidad seleccionada? (Esta accion es irremediable)", "Eliminar Unidad", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                DialogResult resultado2 = MessageBox.Show("Marca eliminado", "Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _serviciosUnidadMedida.Eliminar(IdUnidad);
            }
        }
    }
}
