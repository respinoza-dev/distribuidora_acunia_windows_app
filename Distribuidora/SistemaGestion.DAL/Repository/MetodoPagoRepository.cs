using Microsoft.Data.SqlClient;
using SistemaGestion.DAL.Configuration;
using SistemaGestion.DAL.Entities;

namespace SistemaGestion.DAL.Repository
{
    public class MetodoPagoRepository
    {
        public List<MetodoPago> ObtenerLista()
        {
            var lista = new List<MetodoPago>();
            try
            {
                using (SqlConnection connection = DBConnection.Connect())
                {
                    connection.Open();
                    string sql = "SELECT Id_Metodo_Pago, Nombre_Metodo FROM Metodo_Pago";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new MetodoPago
                        {
                            IdMetodoPago  = Convert.ToInt32(reader["Id_Metodo_Pago"]),
                            NombreMetodo  = reader["Nombre_Metodo"].ToString()!
                        });
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
