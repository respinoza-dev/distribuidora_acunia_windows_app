using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.BLL.Services
{
    public class UnidadMedidaServices
    {
        private UnidaDeMedida _repository;
        public UnidadMedidaServices()
        {
            // construyendo el objeto de tipo CategoryRepository
            // inyeccion de dependencias
            _repository = new UnidaRepository();
        }

        public void RegistrarLista(List<UnidaDeMedida> lista)
        {
            // Validacion
            foreach (var UnidadMedida in lista)
            {
                if (string.IsNullOrEmpty(UnidadMedida.NombreUnidad))
                {
                    throw new Exception("Error: Las Marcas no pueden llevar nombres vacios");
                }
            }

            // invocamos al metodo para registrar la lista de categorias
            _repository.RegistrarLista(lista);
        }
        public List<UnidaDeMedida> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }

        public void Editar(UnidaDeMedida unidaDeMedida)
        {
            if (string.IsNullOrEmpty(unidaDeMedida.NombreUnidad))
            {
                throw new ArgumentException("Error: No se admiten valores nulos en Nombre de la unidad.");
            }

            // si no hay problema de la excepcion anterior, se invoca el metodo de editar
            _repository.Editar(unidaDeMedida);
        }
        public void Eliminar(int IdUnidad)
        {
            if (IdUnidad < 0)
            {
                throw new Exception("Error: El ID de la unidad no puede ser negativo");
            }
            _repository.Eliminar(IdUnidad);
        }
    }
}
