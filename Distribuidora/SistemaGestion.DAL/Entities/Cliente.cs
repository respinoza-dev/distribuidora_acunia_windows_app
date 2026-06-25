namespace SistemaGestion.DAL.Entities
{
    public class Cliente
    {
        public int    IdCliente     { get; set; }
        public string NombreCliente { get; set; } = string.Empty;
        public string Telefono      { get; set; } = string.Empty;
        public string Email         { get; set; } = string.Empty;
        public string Direccion     { get; set; } = string.Empty;
        public bool   Activo        { get; set; }
    }
}
