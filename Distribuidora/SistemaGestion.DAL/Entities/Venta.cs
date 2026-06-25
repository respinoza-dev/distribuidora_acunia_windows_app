namespace SistemaGestion.DAL.Entities
{
    public class Venta
    {
        public int      IdVenta          { get; set; }
        public int      IdCliente        { get; set; }
        public int      IdUsuario        { get; set; }
        public int      IdMetodoPago     { get; set; }
        public string   TipoVenta        { get; set; } = string.Empty;
        public string   EstadoVenta      { get; set; } = "Activo";
        public DateTime FechaVenta       { get; set; }
        public string   Observaciones    { get; set; } = string.Empty;
        // Campos de visualización (JOIN)
        public string   NombreCliente    { get; set; } = string.Empty;
        public string   NombreUsuario    { get; set; } = string.Empty;
        public string   NombreMetodoPago { get; set; } = string.Empty;
        public decimal  Total            { get; set; }
    }
}
