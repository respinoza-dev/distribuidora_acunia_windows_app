namespace SistemaGestion.DAL.Entities
{
    public class Usuario
    {
        public int      IdUsuario       { get; set; }
        public string   NombreUsuario   { get; set; } = string.Empty;
        public int      IdRol           { get; set; }
        public bool     Activo          { get; set; }
        public DateTime FechaCreacion   { get; set; }
    }
}
