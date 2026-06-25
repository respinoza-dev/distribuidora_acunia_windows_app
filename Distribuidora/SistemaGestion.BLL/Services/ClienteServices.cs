using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;

namespace SistemaGestion.BLL.Services
{
    public class ClienteServices
    {
        private readonly ClienteRepository _repository;

        public ClienteServices()
        {
            _repository = new ClienteRepository();
        }

        public List<Cliente> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }

        public List<Cliente> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return _repository.ObtenerLista();

            return _repository.BuscarPorNombre(nombre);
        }
    }
}
