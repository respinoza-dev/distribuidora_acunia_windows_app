using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;

namespace SistemaGestion.BLL.Services
{
    public class CategoryServices
    {
        private CategoryRepository _repository;
        public CategoryServices()
        {
            // construyendo el objeto de tipo CategoryRepository
            // inyeccion de dependencias
            _repository = new CategoryRepository();
        }

        public void RegistrarLista(List<Categoria> lista)
        {
            // Validacion
            foreach (var categoria in lista)
            {
                if (string.IsNullOrEmpty(categoria.NombreCategoria))
                {
                    throw new Exception("Error: Las categorias no pueden llevar nombres vacios");
                }
            }

            // invocamos al metodo para registrar la lista de categorias
            _repository.RegistrarLista(lista);
        }

        public List<Categoria> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }
        public List<Categoria> ObtenerCategoriasActivas()
        {
            return _repository.ObtenerCategoriasActivas();
        }

        public void Editar(Categoria categoria)
        {
            if(string.IsNullOrEmpty(categoria.NombreCategoria) || categoria.Estado == null)
            {
                throw new ArgumentException("Error: No se admiten valores nulos en Nombre Categoria y Estado.");
            }

            // si no hay problema de la excepcion anterior, se invoca el metodo de editar
            _repository.Editar(categoria);
        }
        public void Eliminar(int IdCategoria)
        {
            if (IdCategoria < 0)
            {
                throw new Exception("Error: El ID Categoria no puede ser negativo");
            }
            _repository.Eliminar(IdCategoria);
        }
    }
}