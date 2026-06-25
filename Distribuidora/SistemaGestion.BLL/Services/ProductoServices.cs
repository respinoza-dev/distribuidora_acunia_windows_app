using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;

namespace SistemaGestion.BLL.Services
{
    public class ProductoServices
    {
        private readonly ProductRepository _repository;

        public ProductoServices()
        {
            _repository = new ProductRepository();
        }

        public List<Producto> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return _repository.ObtenerLista();

            return _repository.BuscarPorNombre(nombre);
        }
    }
}
