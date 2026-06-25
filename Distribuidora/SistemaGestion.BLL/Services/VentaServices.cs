using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;

namespace SistemaGestion.BLL.Services
{
    public class VentaServices
    {
        private readonly VentaRepository _repository = new VentaRepository();

        public int GuardarVenta(Venta venta, List<DetalleVenta> detalles)
            => _repository.GuardarVenta(venta, detalles);

        public void ActualizarVenta(Venta venta, List<DetalleVenta> detalles)
            => _repository.ActualizarVenta(venta, detalles);

        public void EliminarVenta(int idVenta)
            => _repository.EliminarVenta(idVenta);

        public List<Venta> ObtenerPorFecha(DateTime desde, DateTime hasta)
            => _repository.ObtenerPorFecha(desde, hasta);

        public List<DetalleVenta> ObtenerDetallesPorVenta(int idVenta)
            => _repository.ObtenerDetallesPorVenta(idVenta);

        public Venta? ObtenerPorId(int idVenta)
            => _repository.ObtenerPorId(idVenta);
    }
}
