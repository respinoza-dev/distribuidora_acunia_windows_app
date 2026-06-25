using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;

namespace SistemaGestion.BLL.Services
{
    public class UsuarioServices
    {
        private readonly UsuarioRepository _repository;

        public UsuarioServices()
        {
            _repository = new UsuarioRepository();
        }

        public Usuario? ObtenerPrimero()
        {
            return _repository.ObtenerPrimero();
        }
    }
}
