namespace SistemaGestion.DAL.Entities
{
    public class DetalleVenta
    {
        public int     IdDetalleVenta  { get; set; }
        public int     IdVenta         { get; set; }
        public int     IdProducto      { get; set; }
        public int     IdEscala        { get; set; }
        public int     CantidadVendida { get; set; }
        public decimal PrecioUnitario  { get; set; }
        public decimal Descuento       { get; set; }
        public decimal Subtotal        { get; set; }
        // Campo de visualización
        public string  NombreProducto  { get; set; } = string.Empty;
    }
}
