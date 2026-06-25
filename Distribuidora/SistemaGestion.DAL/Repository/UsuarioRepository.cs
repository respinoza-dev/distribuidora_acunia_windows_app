using Microsoft.Data.SqlClient;
using SistemaGestion.DAL.Configuration;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.DAL.Repository
{
    public class UsuarioRepository
    {
        private const string SqlBase =
            @"SELECT TOP 1 Id_Usuario, Nombre_Usuario, Id_Rol, Activo, Fecha_Creacion
              FROM   [dbo].[Usuario]
              WHERE  Activo = 1
              ORDER BY Id_Usuario ASC";

        public Usuario? ObtenerPrimero()
        {
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();
                    SqlCommand    cmd    = new SqlCommand(SqlBase, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        return MapearUsuario(reader);
                }
            }
            catch (Exception) { throw; }
            return null;
        }

        private Usuario MapearUsuario(SqlDataReader reader)
        {
            return new Usuario
            {
                IdUsuario     = Convert.ToInt32(reader["Id_Usuario"]),
                NombreUsuario = reader["Nombre_Usuario"].ToString()!,
                IdRol         = Convert.ToInt32(reader["Id_Rol"]),
                Activo        = Convert.ToBoolean(reader["Activo"]),
                FechaCreacion = Convert.ToDateTime(reader["Fecha_Creacion"])
            };
        }
    }
}
