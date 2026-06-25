using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;

namespace SistemaGestion.BLL.Services
{
    public class MetodoPagoServices
    {
        private readonly MetodoPagoRepository _repository;

        public MetodoPagoServices()
        {
            _repository = new MetodoPagoRepository();
        }

        public List<MetodoPago> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }
    }
}
