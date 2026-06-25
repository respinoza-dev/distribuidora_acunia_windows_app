using Microsoft.Data.SqlClient;
using SistemaGestion.DAL.Configuration;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.DAL.Repository
{
    public class ClienteRepository
    {
        private const string SqlBase =
            @"SELECT Id_Cliente, Nombre_Cliente, Telefono, Email, Direccion, Activo
              FROM   Cliente
              WHERE  Activo = 1";

        public List<Cliente> ObtenerLista()
        {
            var lista = new List<Cliente>();
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();
                    SqlCommand    cmd    = new SqlCommand(SqlBase, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        lista.Add(MapearCliente(reader));
                    connection.Close();
                }
            }
            catch (Exception) { throw; }
            return lista;
        }

        public List<Cliente> BuscarPorNombre(string nombre)
        {
            var lista = new List<Cliente>();
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();
                    string        sql    = SqlBase + " AND Nombre_Cliente LIKE @Nombre";
                    SqlCommand    cmd    = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Nombre", $"%{nombre}%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        lista.Add(MapearCliente(reader));
                    connection.Close();
                }
            }
            catch (Exception) { throw; }
            return lista;
        }

        private Cliente MapearCliente(SqlDataReader reader)
        {
            return new Cliente
            {
                IdCliente     = Convert.ToInt32(reader["Id_Cliente"]),
                NombreCliente = reader["Nombre_Cliente"].ToString()!,
                Telefono      = reader["Telefono"]  == DBNull.Value ? string.Empty : reader["Telefono"].ToString()!,
                Email         = reader["Email"]     == DBNull.Value ? string.Empty : reader["Email"].ToString()!,
                Direccion     = reader["Direccion"] == DBNull.Value ? string.Empty : reader["Direccion"].ToString()!,
                Activo        = Convert.ToBoolean(reader["Activo"])
            };
        }
    }
}
