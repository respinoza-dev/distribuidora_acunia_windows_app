using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.BLL.Services
{
    public class MarcaServices
    {
        private MarcaRepository _repository;
        public MarcaServices()
        {
            // construyendo el objeto de tipo CategoryRepository
            // inyeccion de dependencias
            _repository = new MarcaRepository();
        }

        public void RegistrarLista(List<Marca> lista)
        {
            // Validacion
            foreach (var Marca in lista)
            {
                if (string.IsNullOrEmpty(Marca.NombreMarca))
                {
                    throw new Exception("Error: Las Marcas no pueden llevar nombres vacios");
                }
            }

            // invocamos al metodo para registrar la lista de categorias
            _repository.RegistrarLista(lista);
        }
        public List<Marca> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }

        public void Editar(Marca Marca)
        {
            if (string.IsNullOrEmpty(Marca.NombreMarca) )
            {
                throw new ArgumentException("Error: No se admiten valores nulos en Nombre Marca.");
            }

            // si no hay problema de la excepcion anterior, se invoca el metodo de editar
            _repository.Editar(Marca);
        }
        public void Eliminar(int IdMarca)
        {
            if (IdMarca < 0)
            {
                throw new Exception("Error: El ID Marca no puede ser negativo");
            }
            _repository.Eliminar(IdMarca);
        }




    }

    



}
